namespace PromotionEngine_Amar.PromotionRules
{
    interface IpromotionRuleFactory
    {
        KsuCountRuleBase GetPromotionRule(string skuname);
    }
}
