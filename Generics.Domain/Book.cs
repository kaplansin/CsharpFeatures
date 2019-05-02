using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Domain
{
    public class Book : IComparable<Book>, IComparable
    {
        public string Name { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public Book(string name, string isbn, string author)
        {
            this.Name = name;
            this.ISBN = isbn;
            this.Author = author;
        }


        public override bool Equals(object obj)
        {
            Book other = (Book)obj;
            if(this.Name == other.Name && this.Author == other.Author)
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (this.Name + this.Author).GetHashCode();
        }
        public int CompareTo(Book other)
        {
            return this.Name.CompareTo(other.Name);
        }
        public int CompareTo(object other)
        {
            return this.CompareTo((Book)other);
        }
    }
}
