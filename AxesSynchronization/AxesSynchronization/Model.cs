using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxesSynchronization
{
    public class Model
    {
        public string Name { get; set; }
        public double Value { get; set; }

        public Model(string a, double b)
        {
            Name = a;
            Value = b;
        }
    }
}
