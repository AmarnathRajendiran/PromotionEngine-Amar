using PromotionEngine_Amar.Entities;
using System.Collections.Generic;

namespace PromotionEngine_Amar.PromotionRules
{
    interface ISkuCandDCountRule
    {
        int GetPromotionAppliedAmountForSkuCandD(List<Cartitem> cartitem);
    }
}
