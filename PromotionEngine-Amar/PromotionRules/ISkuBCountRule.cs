using PromotionEngine_Amar.Entities;

namespace PromotionEngine_Amar.PromotionRules
{
    interface ISkuBCountRule
    {
        int GetPromotionAppliedAmountForSkuB(Cartitem cartitem);
    }
}
