﻿using tdd_oop_inheritance.CSharp.Main;
using NUnit.Framework;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class BookTest
    {
        [Test]
        public void shouldCheckOutIfAvailable()
        {
            Book book = new Book("JUnit Rocks", "Sahar Bidén", "sarahrBoooks@telia.com", "sarahrBoooks.com");
            Assert.AreEqual("item has been checked out", book.checkOut());
        }

        [Test]
        public void shouldDeclineIfNotAvailableToCheckout()
        {
            Book book = new Book("JUnit Rocks", "Sahar Bidén", "sarahrBoooks@telia.com", "sarahrBoooks.com");
            book.checkOut();

            Assert.AreEqual("item is currently on loan", book.checkOut());
        }

        [Test]
        public void shouldCheckInIfOnLoan()
        {
            Book book = new Book("JUnit Rocks", "Sahar Bidén", "sarahrBoooks@telia.com", "sarahrBoooks.com");
            book.checkOut();

            Assert.AreEqual("item has been checked in", book.checkIn());
        }

        [Test]
        public void shouldDeclineCheckInIfNotOnLoan()
        {
            Book book = new Book("JUnit Rocks", "Sahar Bidén", "sarahrBoooks@telia.com", "sarahrBoooks.com");

            Assert.AreEqual("item is not currently on loan", book.checkIn());
        }
    }
}