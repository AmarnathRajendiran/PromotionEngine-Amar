using PromotionEngine_Amar.Entities;
using PromotionEngine_Amar.Interface;
using PromotionEngine_Amar.Process;
using PromotionEngine_Amar.PromotionRules;

namespace PromotionEngine_Amar
{
    public class Promotion : IPromotion
    {
        public int Process(Cart cart)
        {
            ProcessBasedOnQuantity processBasedOnQuantity = new ProcessBasedOnQuantity(new PromotionRuleFactory());
            return processBasedOnQuantity.ProcessAmoutBasedOnCountPromotion(cart);
        }
    }
}
