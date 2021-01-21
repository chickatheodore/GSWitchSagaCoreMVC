using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{

    public class SagaViewModel
    {
        public Person FirstPerson { get; set; }
        public Person SecondPerson { get; set; }

        public decimal Average { get; set; }
    }

}
