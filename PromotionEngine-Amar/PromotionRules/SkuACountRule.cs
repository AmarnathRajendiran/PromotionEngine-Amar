using PromotionEngine_Amar.Constants;
using PromotionEngine_Amar.Entities;
using System;

namespace PromotionEngine_Amar.PromotionRules
{
    class SkuACountRule : KsuCountRuleBase, ISkuACountRule
    {
        public int GetPromotionAppliedAmountForSkuA(Cartitem cartitem)
        {
            int amount = 0;
            int remainigQuantity;
            int promotionQuantity = Math.DivRem(cartitem.Quantity, PromotionQuantity.KsuAPromotionQuantity, out remainigQuantity);
            amount = (promotionQuantity * 130) + (remainigQuantity * 50);
            return amount;
        }
    }
}
