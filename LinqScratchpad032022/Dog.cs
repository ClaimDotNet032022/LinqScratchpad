using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqScratchpad032022
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsVaccinated { get; set; }

        public Dog() : this("", 0, false)
        {

        }

        public Dog(string name, int age, bool isVaccinated)
        {
            Name = name;
            Age = age;
            IsVaccinated = isVaccinated;
        }
    }
}
