using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using ShoppingCart;

namespace ShoppingCat.Test
{
    [TestFixture]
    public class ShoppingCartTest
    {
        [Test]
        public void Buy_The_First_1_Book_Should_100()
        {
            //arrange
            var book = new Book
            {
                Name = "哈利波特-第一集",
                Count = 1,
                Price = 100
            };

            //act
            var actual = new ShoppingCartCalculator().CalculateTotal(new List<Book> { book });

            //assert
            actual.Should().Be(100);
        }

        [Test]
        public void Buy_The_First_1_and_The_Second_1_Should_190()
        {
            //arrange
            var books = new List<Book>
            {
                new Book
                {
                    Name = "哈利波特-第一集",
                    Count = 1,
                    Price = 100
                },
                new Book
                {
                    Name = "哈利波特-第二集",
                    Count = 1,
                    Price = 100
                }
            };

            //act
            var actual = new ShoppingCartCalculator().CalculateTotal(books);

            //assert
            actual.Should().Be(190);
        }

        [Test]
        public void Buy_The_First_1_and_The_Second_1_and_The_Third_3_Should_270()
        {
            //arrange
            var books = new List<Book>
            {
                new Book
                {
                    Name = "哈利波特-第一集",
                    Count = 1,
                    Price = 100
                },
                new Book
                {
                    Name = "哈利波特-第二集",
                    Count = 1,
                    Price = 100
                },
                new Book
                {
                    Name = "哈利波特-第三集",
                    Count = 1,
                    Price = 100
                }
            };

            //act
            var actual = new ShoppingCartCalculator().CalculateTotal(books);

            //assert
            actual.Should().Be(270);
        }
    }
}
