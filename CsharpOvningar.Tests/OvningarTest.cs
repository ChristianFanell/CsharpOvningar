using Challenge.App;
using CsharpOvningar.App;
using CsharpOvningar.App.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Xunit;

namespace CsharpOvningar.Tests
{
    public class OvningarTest
    {
        private readonly Func<List<Person>> _personData;

        public OvningarTest()
        {
            _personData = GetPersonData();
        }


        [Fact]
        public void TestSimpleExample1()
        {
            var actual = Ovningar.SimpleExampleWithAddingTwoNumbers(1, 1);
            Assert.Equal(2, actual);
        }

        [Fact]
        public void TestChallenge1()
        {
            var input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 543, 5768, 2354, 66, 4, 2, 556, 788, 90 };
            var expected = new List<int>() { 5768 };
            var number = 5766;
            var actual = Ovningar.Challenge1(input, number);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestChallenge2()
        {
            var input = "solution experts";
            var expected = "sltnxprts";
            var actual = Ovningar.Challenge2(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestChallenge3_1()
        {
            var actual = Ovningar.Challenge3(new List<int> { 1, 88, 9, 100, 190, 1000 });

            Assert.False(actual);
        }

        [Fact]
        public void TestChallenge3_2()
        {
            var input = Enumerable.Range(1, 1000).ToList();
            var actual = Ovningar.Challenge3(input);

            Assert.True(actual);
        }

        [Fact]
        public void TestChallenge4_1()
        {
            var input = "4556364607935616";
            var actual = Ovningar.Challenge4(input);
            var expected = "############5616";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestChallenge4_2()
        {
            var input = "Nananananananananananananananana Batman!";
            var expected = "####################################man!";
            var actual = Ovningar.Challenge4(input);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void TestExtraChallenge1()
        {
            var data = _personData();
            var actual = Ovningar.ExtraChallenge1(data, Guid.Parse("a605de48-1234-4c65-8889-43cd09e6096c"));
            var expectedName = "Sophia";
            var expectedAge = 2;

            Assert.Equal(expectedAge, actual.Age);
            Assert.Equal(expectedName, actual.Name);
        }

        [Fact]
        public void TestExtraChallenge2_1()
        {
            var api = new API(new List<int>() { 2, 1, 19, 2, 5, 6, 11 });
            var expectedBuyDay = 2;
            var expectedSellDay = 3;
            var (buyDay, sellDay) = Ovningar.ExtraChallenge2(api);

            Assert.Equal(expectedBuyDay, buyDay);
            Assert.Equal(expectedSellDay, sellDay);
        }

        [Fact]
        public void TestExtraChallenge2_2()
        {
            API api = new(new List<int>() { 2, 4, 1, 3, 9, 0, 4, 3 });
            var expectedBuyDay = 3;
            var expectedSellDay = 5;
            var (buyDay, sellDay) = Ovningar.ExtraChallenge2(api);

            Assert.Equal(expectedBuyDay, buyDay);
            Assert.Equal(expectedSellDay, sellDay);
        }

        private Func<List<Person>> GetPersonData()
        {
            var data = GetData<List<Person>>("data.json");

            return () => data;
        }

        private static T GetData<T>(string file)
        {
            var path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            path = Path.Combine(path, file);
            var jsonString = File.ReadAllText(path);
            var data = JsonConvert.DeserializeObject<T>(jsonString);

            return data;
        }
    }
}
