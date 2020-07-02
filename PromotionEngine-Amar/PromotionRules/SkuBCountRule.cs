using PromotionEngine_Amar.Constants;
using PromotionEngine_Amar.Entities;
using System;

namespace PromotionEngine_Amar.PromotionRules
{
    class SkuBCountRule : KsuCountRuleBase, ISkuBCountRule
    {
        public int GetPromotionAppliedAmountForSkuB(Cartitem cartitem)
        {
            int amount = 0;
            int remainigQuantity;
            int promotionQuantity = Math.DivRem(cartitem.Quantity, PromotionQuantity.KsuBPromotionQuantity, out remainigQuantity);

            amount = (promotionQuantity * 45) + (remainigQuantity * 30);
            return amount;
        }
    }
}
