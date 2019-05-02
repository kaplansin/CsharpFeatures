using CsharpRef;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Generics.Test
{
    public class ParameterTest
    {

        /*
        bool byte char decimal double enum floatint long sbyte short struct uint ulong ushort
         */
        [Fact]
        public void ValueTypeParameterUpdateTest()
        {
            //value type
            int x = 10;
            DataUpdateManager.UpdateValue(x, 20);
            x.Should().Be(10);
        }

        [Fact]
        public void StructParameterUpdateTest()
        {
            //value type
            Point p1 = new Point(1, 5);
            Point p2 = new Point(5, 10);
            DataUpdateManager.UpdateValue(p1, p2);
            p1.X.Should().Be(1);
            p1.Y.Should().Be(5);
        }

        [Fact]
        public void StringParameterUpdateTest()
        {
            //string immutable refenrece type
            string str = "Hello world";
            DataUpdateManager.UpdateValue(str, "Test string new value");
            str.Should().Be("Hello world");
            
        }

        //Class pass by reference
        [Fact]
        public void ReferenceTypeParameterUpdateTest()
        {
            Person person = new Person(1, "Person 1");
            DataUpdateManager.UpdateName(person, "Person 2");
            person.GetName().Should().Be("Person 2");
        }
        [Fact]
        public void SetDefaultReferenceTest()
        {
            Person person = new Person(1, "Person 1");
            DataUpdateManager.SetDefault(person);
            person.Should().NotBeNull();
            person.GetName().Should().Be("Person 1");
        }
       
        [Fact]
        public void ReferenceTypeParameterClassUpdateTest()
        {
            Person person1 = new Person(1, "person 1");
            Person person2 = new Person(2, "person 2");

            DataUpdateManager.UpdateValue(person1, person2);
            person1.GetName().Should().Be("person 1");
        }

        /// Pass by reference test
        [Fact]
        public void ValueTypeParameterPassByReferenceUpdateTest()
        {
            //value type
            int x = 10;
            DataUpdateManager.UpdateValue(ref x, 20);
            x.Should().Be(20);
        }

        [Fact]
        public void StructParameterPassByReferenceUpdateTest()
        {
            //value type
            Point p1 = new Point(1, 5);
            Point p2 = new Point(5, 10);
            DataUpdateManager.UpdateValue(ref p1, p2);
            p1.X.Should().Be(5);
            p1.Y.Should().Be(10);
        }

        [Fact]
        public void StringParameterPassByReferenceUpdateTest()
        {
            //string immutable refenrece type
            string str = "Hello world";
            DataUpdateManager.UpdateValue(ref str, "Test string new value");
            str.Should().Be("Test string new value");

        }

        //Class pass by reference
        [Fact]
        public void ReferenceTypeParameterPassByReferenceValueUpdateTest()
        {
            Person person = new Artist(1, "Person 1");
            DataUpdateManager.UpdateName(ref person, "Person 2");
            person.GetName().Should().Be("Person 2");
        }
        [Fact]
        public void SetDefaultReferencePassByReferenceTest()
        {
            Person person = new Person(1, "Person 1");
            DataUpdateManager.SetDefault(ref person);
            person.Should().BeNull();
        }

        [Fact]
        public void ReferenceTypeParameterPassByReferenceClassUpdateTest()
        {
            Person person1 = new Person(1, "person 1");
            Person person2 = new Person(2, "person 2");

            DataUpdateManager.UpdateValue(ref person1, person2);
            person1.GetName().Should().Be("person 2");
            DataUpdateManager.UpdateName(person2, "person 2 update");
            person2.GetName().Should().Be("person 2 update");
            person1.GetName().Should().Be("person 2 update");

            DataUpdateManager.UpdateName(person1, "person 1 update");
            person2.GetName().Should().Be("person 1 update");
            person1.GetName().Should().Be("person 1 update");
        }


        [Fact]
        public void ValueTypeInReferenseTypeParameterTest()
        {
            Rectangle rect = new Rectangle(new Point(1, 2), 3, 4);
            Point p = new Point(5, 6);
            DataUpdateManager.UpdateStart(rect, p);
            rect.Start.X.Should().Be(5);
            p.X = 10;
            rect.Start.X.Should().Be(5);
        }

        [Fact]
        public void ValueTypeInReferenseSwitchParameterTest()
        {
            Rectangle rect1 = new Rectangle(new Point(1, 2), 3, 4);
            Rectangle rect2 = new Rectangle(new Point(5, 6), 7, 8);
            DataUpdateManager.UpdateValue(rect1, rect2);
            rect1.Start.X.Should().Be(1);
            rect2.Start.X.Should().Be(5);
        }

        [Fact]
        public void ValueTypeInReferensePassByReferenceSwitchParameterTest()
        {
            Rectangle rect1 = new Rectangle(new Point(1, 2), 3, 4);
            Rectangle rect2 = new Rectangle(new Point(5, 6), 7, 8);
            DataUpdateManager.UpdateValue(ref rect1, rect2);
            rect1.Start.X.Should().Be(5);
            rect2.Start = new Point(10, 11);
            rect1.Start.X.Should().Be(10);
        }

        [Fact]
        public void InitValueTypeArrayTest()
        {
            int[] numbers = { 1,2,3,4,5,6,7,8,9,10 };
            DataUpdateManager.InitArray(numbers, 0);
            numbers[0].Should().Be(0);

        }
        [Fact]
        public void ReferenceReturnTest()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ref int num  = ref DataUpdateManager.GetNthElement(numbers, 0);
            num = 10;
            numbers[0].Should().Be(10);
        }
        [Fact]
        public void ReferenceReturnClassTest()
        {
            Person[] people = { new Person(1, "Person 1"), new Person(2, "Person 2"), new Person(3,"Person 3") };
            Person person = DataUpdateManager.GetNthElement(people, 0);
            person.UpdateName("Person 1 update");
            people[0].GetName().Should().Be("Person 1 update");
        }

        [Fact]
        public void ReferenceInValueTypeParameterTest()
        {
            UnrealType unreal1 = new UnrealType(new Person(1, "person 1"), 30);
            UnrealType unreal2 = new UnrealType(new Person(2, "person 2"), 40);
            DataUpdateManager.UpdateValue(unreal1, unreal2);
            unreal1.Person.GetName().Should().Be("person 1");
           

        }

        [Fact]
        public void ReferenceContainReferenceType()
        {
            Person p = new Person(1, "Person 1");
            UnrealType unreal1 = new UnrealType(p, 30);
            UnrealType unreal2 = new UnrealType(p, 40);

            unreal1.Person.GetName().Should().Be("Person 1");
            p.UpdateName("Person 1 update");

            unreal1.Person.GetName().Should().Be("Person 1 update");
            unreal2.Person.GetName().Should().Be("Person 1 update");
        }

        [Fact]
        public void ReferenceContainValueType()
        {
            Point p = new Point(1, 2);
            Rectangle r1 = new Rectangle(p, 3, 4);
            Rectangle r2 = new Rectangle(p, 4, 5);

            r1.Start.X.Should().Be(1);
            p.X = 10;

            r1.Start.X.Should().Be(1);
            r2.Start.X.Should().Be(1);
        }
        [Fact]
        public void ConstReferenceTest()
        {
            Point p = new Point(1, 2);
           
            //const Rectangle r1 = new Rectangle(p, 3, 4);
            //const Rectangle r2 = new Rectangle(p, 4, 5);
        }
    }
}
