using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class UserValidationService : IUserValidationService
    {
        public bool Validate(Customer customer)
        {
            if (customer.FirstName == "Ayşenur" && customer.LastName == "Elmas" && customer.NationalityId == "12345678909" && customer.DateOfBirth.Year == 2000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
