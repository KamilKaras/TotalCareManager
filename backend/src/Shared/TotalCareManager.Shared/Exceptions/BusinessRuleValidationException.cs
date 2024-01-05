using TotalCareManager.Shared.Domain;

namespace TotalCareManager.Shared.Exceptions
{
    public sealed class BusinessRuleValidationException : AppException
    {
        public BusinessRuleValidationException(IBusinessRule rule) : base(rule.Message)
        {
            Rule = rule;
            RuleMessage = rule.Message;
        }

        public IBusinessRule Rule { get; }

        public string RuleMessage { get; }

        public override string ToString() => $"{Rule.GetType().FullName}: {Rule.Message}";
    }
}