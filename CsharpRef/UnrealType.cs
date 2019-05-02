using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpRef
{
    public struct UnrealType
    {
        public Person Person { get; set; }
        public int Age { get; set; }
        public UnrealType(Person p , int age)
        {
            this.Person = p;
            this.Age = age;
        }
    }
}
