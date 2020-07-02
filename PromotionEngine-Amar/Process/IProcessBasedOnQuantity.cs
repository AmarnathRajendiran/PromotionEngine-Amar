using PromotionEngine_Amar.Entities;

namespace PromotionEngine_Amar.ProcessInterface
{
    interface IProcessBasedOnQuantity
    {
        int ProcessAmoutBasedOnCountPromotion(Cart cart);
    }
}
