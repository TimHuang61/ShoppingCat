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
        public void Buy_The_First_Book_Should_100()
        {
            //arrange
            var book = new Book
            {
                Name = "哈利波特-第一集",
                Count = 1,
                Price = 100
            };

            //act
            var actual = book.Price * book.Count;

            //assert
            actual.Should().Be(100);
        }
    }
}
