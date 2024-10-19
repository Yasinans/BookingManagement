using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingManagement.Backend.Options
{
    abstract class Option
    {
        private  int id { get; set; }
        private  string value;
        public Option(int id, string value) {
            this.id = id;
            this.value = value;
        }

    }
}
