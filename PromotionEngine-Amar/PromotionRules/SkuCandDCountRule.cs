using PromotionEngine_Amar.Entities;
using System.Collections.Generic;

namespace PromotionEngine_Amar.PromotionRules
{
    class SkuCandDCountRule : KsuCountRuleBase, ISkuCandDCountRule
    {
        public int GetPromotionAppliedAmountForSkuCandD(List<Cartitem> cartitem)
        {
            int amount = 0;
            var ksuCCount = cartitem.FindAll(x => x.Skuname.Equals("C")).Count;
            var ksuDCount = cartitem.FindAll(x => x.Skuname.Equals("D")).Count;
            if (ksuCCount != 0 && ksuDCount == 0)
            {
                amount = 20 * ksuCCount;
            }
            else if (ksuCCount != 0 && ksuDCount == 0)
            {
                amount = 15 * ksuDCount;
            }
            else if (ksuCCount == ksuDCount)
            {
                amount = ksuDCount * 30;
            }
            else if (ksuCCount > ksuDCount)
            {
                var diffCount = ksuCCount - ksuDCount;
                var ksuCandDCount = ksuCCount - diffCount;
                amount = (ksuCandDCount * 30) + (diffCount * 20);
                return amount;
            }
            else if (ksuCCount < ksuDCount)
            {
                var diffCount = ksuDCount - ksuCCount;
                var ksuCandDCount = ksuDCount - diffCount;
                amount = (ksuCandDCount * 30) + (diffCount * 15);
                return amount;
            }
            return amount;
        }
    }
}
