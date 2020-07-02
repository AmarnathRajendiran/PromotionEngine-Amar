using PromotionEngine_Amar.Entities;

namespace PromotionEngine_Amar.PromotionRules
{
    interface ISkuACountRule
    {
        int GetPromotionAppliedAmountForSkuA(Cartitem cartitem);
    }
}
