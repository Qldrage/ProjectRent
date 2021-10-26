using Core.Entities;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class CarDto:IEntity
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
