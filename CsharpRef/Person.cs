using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpRef
{
    public class Person : IName
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
       
        public Person()
        {
            Id = -1;
            Name = String.Empty;
           
        }
        public Person(int id, string name)
        {
            this.Id = id;
            this.Name = name;
           
        }
        

        public override bool Equals(object obj)
        {
            Artist other = (Artist)obj;
            return this.Id == other.Id && this.Name == other.Name;
        }

        public override int GetHashCode()
        {
            return (this.Id + this.Name ).GetHashCode();
        }

        public void UpdateName(string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return this.Name;
        }

    }
}
