using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class CustomerManager : ICustomerServis
    {
        IUserValidationService _userValidationService;

        public CustomerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Customer entity)
        {
            if (_userValidationService.Validate(entity))
            {
                Console.WriteLine("Kullanıcı kayıt edildi.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarız.Kayıt başarısız.");
            }
        }

        public void Delete(Customer entity)
        {
            Console.WriteLine("Customer deleted");
        }

        public void Update(Customer entity)
        {
            Console.WriteLine("Customer updated");
        }
    }
}
