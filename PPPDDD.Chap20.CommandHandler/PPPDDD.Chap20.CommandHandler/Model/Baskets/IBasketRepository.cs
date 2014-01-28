using System;
using PPPDDD.Chap20.CommandHandler.Infrastructure;

namespace PPPDDD.Chap20.CommandHandler.Model.Baskets
{
    public interface IBasketRepository : IRepository<Basket, Guid>
    {
        //Basket find_by(int basketId);
        //void add(Basket basket);
    }
}