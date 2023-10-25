using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    //somut nesne
    internal class Customer
    {
        //bu tip classlar sadece özellik içerir
        //Referans tutucu
        //set:değer atamak , get: değeri göndermek

        //field :alan değişken 
        //public string FirstName;

        //property : özellik, cllass özelikleri tanımlanmak istenirse kullanılır.
        public int Id { get; set; }

        private string _firstname;
        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string LastName { get; set; }
        public string City { get; set; }

    }
}
