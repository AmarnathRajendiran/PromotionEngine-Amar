using PromotionEngine_Amar.Entities;
using PromotionEngine_Amar.ProcessInterface;
using PromotionEngine_Amar.PromotionRules;

namespace PromotionEngine_Amar.Process
{
    class ProcessBasedOnQuantity : IProcessBasedOnQuantity
    {
        private readonly IpromotionRuleFactory _promotionRuleFactory;
        public ProcessBasedOnQuantity(IpromotionRuleFactory ipromotionRuleFactory)
        {
            _promotionRuleFactory = ipromotionRuleFactory;
        }
        public int ProcessAmoutBasedOnCountPromotion(Cart cart)
        {
            int TotalAmountAfterPromotionApplied = 0;
            int amountForA = 0;
            int amountForB = 0;
            int amountForCandD = 0;
            //   PromotionRuleFactory promotionRuleFactory = new PromotionRuleFactory();

            var skuACartItems = cart.Cartitems.FindAll(x => x.Skuname.Equals("A"));
            if (skuACartItems != null && skuACartItems.Count > 0)
            {
                var skuAcountRule = _promotionRuleFactory.GetPromotionRule(skuACartItems[0].Skuname);
                var obj = skuAcountRule as SkuACountRule;
                amountForA = obj.GetPromotionAppliedAmountForSkuA(skuACartItems[0]);
            }

            var skuBCartItems = cart.Cartitems.FindAll(x => x.Skuname.Equals("B"));
            if (skuBCartItems != null && skuBCartItems.Count > 0)
            {
                var skuBcountRule = _promotionRuleFactory.GetPromotionRule(skuBCartItems[0].Skuname);
                var obj = skuBcountRule as SkuBCountRule;

                amountForB = obj.GetPromotionAppliedAmountForSkuB(skuBCartItems[0]);
            }

            var skuCandDCartItems = cart.Cartitems.FindAll(x => x.Skuname.Equals("C") || x.Skuname.Equals("D"));
            if (skuCandDCartItems != null && skuCandDCartItems.Count > 0)
            {
                var skuCandDcountRule = _promotionRuleFactory.GetPromotionRule(skuCandDCartItems[0].Skuname);
                var obj = skuCandDcountRule as SkuCandDCountRule;
                amountForCandD = obj.GetPromotionAppliedAmountForSkuCandD(skuCandDCartItems);
            }


            return TotalAmountAfterPromotionApplied = amountForA + amountForB + amountForCandD;
        }
    }
}
