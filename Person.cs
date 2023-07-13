using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashset_Distionary
{
    internal class Person
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public Person(long id, string name, string gender)
        {
            Id = id;
            Name = name;
             Gender= gender;
        }
        public override string ToString()
        {
            return $" name : {Name} age : {Gender} ";
        }
    }
}
