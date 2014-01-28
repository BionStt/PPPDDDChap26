using PPPDDD.Chap20.CommandHandler.Infrastructure;

namespace PPPDDD.Chap20.CommandHandler.Model.Promotions
{
    public class PromotionNotApplicableException : DomainException
    {
        public PromotionNotApplicableException(string message_for_customer) : base(message_for_customer)
        {
        }
    }
}
