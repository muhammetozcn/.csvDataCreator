using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDataCreator
{
    public class DataModel
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }

        public string City { get; set; }

        public DateTime ConnectionDate { get; set; }

        public char gender { get; set; }

        public int age { get; set; }
    }
}
