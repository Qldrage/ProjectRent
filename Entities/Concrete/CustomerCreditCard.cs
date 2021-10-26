using Core.Entities;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class CustomerCreditCard:IEntity
    {
        public int CustomerId { get; set; }
        public int CardId { get; set; }  
    }
}