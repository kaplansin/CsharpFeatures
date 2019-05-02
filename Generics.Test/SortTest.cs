using FluentAssertions;
using Generics.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Generics.Test
{
    public class SortTest
    {
        [Fact]
        public void QuickSortIntTest()
        {
            int[] input = new int[] { 1, 9, 2, 8, 5, 4 };
            QuickSort<int>.Sort(input);
            input.Should().BeEquivalentTo(input.OrderBy(x => x).ToArray());
        }
        [Fact]
        public void QuickSortStringTest()
        {
            string[] input = new string[] { "Emma", "Olivia", "Ava", "Isabella", "Sophia", "Mia" };
            QuickSort<string>.Sort(input);
            input.Should().BeEquivalentTo(input.OrderBy(x => x).ToArray());
        }

        [Fact]
        public void QuickSortBookTest()
        {
            Book[] input = new Book[] { new Book("When Breath Becomes Air","081298840X","Paul Kalanithi"),
                                        new Book("Harry Potter and the Cursed Child, Parts 1 & 2", "1338099132", "J.K. Rowling"),
                                        new Book("The Whistler: A Novel","0385541570","John Grisham")
                                        };
            QuickSort<Book>.Sort(input);
            input.Should().BeEquivalentTo(input.OrderBy(x => x.Name).ToArray());
        }
        [Fact]
        public void GenericResponseTest()
        {
            Book[] input = new Book[] { new Book("When Breath Becomes Air","081298840X","Paul Kalanithi"),
                                        new Book("Harry Potter and the Cursed Child, Parts 1 & 2", "1338099132", "J.K. Rowling"),
                                        new Book("Harry Potter and the Cursed Child, Parts 1 & 2", "1338099132", "J.K. Rowling"),
                                        new Book("The Whistler: A Novel","0385541570","John Grisham"),
                                        new Book("The Whistler: A Novel","0385541570","John Grisham")
                                        };
            GenericResponse<IEnumerable<Book>> result = input.GetDistinct();
            result.IsSuccess().Should().BeTrue();
            result.GetResult().Should().BeEquivalentTo(input.GroupBy(x=>x.Name).Select(x => x.First()), options => options.WithoutStrictOrdering());

        }
    }
}
