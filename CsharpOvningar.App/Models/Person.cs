using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOvningar.App.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public List<Person> Family { get; set; } = new List<Person>();

        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
        
            var person2 = (Person)obj;
            
            return person2.Id == Id && person2.Name == Name && person2.Age == Age;                    
        }
    }
}
