using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    class Student
    {
        public string Name { get; }
        public int Age { get; }
        public Group Group { get; set; }
        public Student(string name, int age)
        {
            //Check input arguments
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
