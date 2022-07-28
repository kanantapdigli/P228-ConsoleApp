using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Base
{
    public abstract class Person
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public byte Age { get; set; }
    }
}
