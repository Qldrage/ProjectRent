using Core.Entities;
using Core.Entities.Abstract;
using Core.Entities.Concrete;

namespace Entities.DTOs
{
    public class UserForUpdateDto : IDto
    {
        public User User { get; set; }
        public string Password { get; set; }
    }
}