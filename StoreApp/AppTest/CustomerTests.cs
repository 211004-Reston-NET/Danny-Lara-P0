using System;
using Models;
using Xunit;

namespace AppTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Testing for valid name formats
        /// </summary>
        /// <param name="p_name">The names to be tested</param>
        [Theory]
        [InlineData("George")]
        [InlineData("Stan Smith")]
        [InlineData("Neil Patrick Harris")]
        public void CustNameValid(string p_name)
        {
            Customer cust = new Customer();

            cust.Name = p_name;

            Assert.NotNull(cust.Name);
            Assert.Equal(cust.Name, p_name);
        }

        /// <summary>
        /// Testing for invalid name data (aka names with non-letter characters)
        /// </summary>
        /// <param name="p_name">The invalid names</param>
        [Theory]
        [InlineData("D@nny")]
        [InlineData("$tan")]
        [InlineData("Walter Wh1te")]
        public void CustNameInvalid(string p_name)
        {
            Customer cust = new Customer();

            Assert.Throws<Exception>(() => cust.Name = p_name);

        }

        /// <summary>
        /// Testing for valid phone number formats.
        /// </summary>
        /// <param name="p_number">Valid phone numbers</param>
        [Theory]
        [InlineData("(555)123-4567")]
        [InlineData("555-555-5555")]
        [InlineData("3211234567")]
        public void CustPhoneNumberValid(string p_number)
        {
            Customer cust = new Customer();

            cust.PhoneNumber = p_number;

            Assert.NotNull(cust.PhoneNumber);
            Assert.Equal(cust.PhoneNumber, p_number);
        }

        /// <summary>
        /// Testing for invalid phone number formats.
        /// </summary>
        /// <param name="p_number">Invalid phone numbers</param>
        [Theory]
        [InlineData("(8o5)123-4567")]
        [InlineData("555 123 - 4567")]
        public void CustPhoneNumberInvalid(string p_number)
        {
            Customer cust = new Customer();

            Assert.Throws<Exception>(() => cust.PhoneNumber = p_number);
        }
    }
}
