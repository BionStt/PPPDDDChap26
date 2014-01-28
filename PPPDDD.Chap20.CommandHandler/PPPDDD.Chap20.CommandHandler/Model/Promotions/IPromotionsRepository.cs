using System;
using PPPDDD.Chap20.CommandHandler.Infrastructure;

namespace PPPDDD.Chap20.CommandHandler.Model.Promotions
{
    public interface IPromotionsRepository : IRepository<Promotion, Guid>
    {
        Promotion find_by(string voucher_code);
    }
}