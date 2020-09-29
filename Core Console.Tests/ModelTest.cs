using System;
using Xunit;
using Model; 
 

namespace Core_Console.Tests
{
    public class ModelTest
    {
        [Fact]
        public void PersonConstructor()
        {
            //Arrange
            string firstname = "Jane";
            string lastname = "Doe";

            //Act
            Person result = new Person(firstname, lastname);

            //Assert
            Assert.NotNull(result);
            Assert.Contains(firstname, result.PersonInformation());
            Assert.Contains(lastname, result.PersonInformation()); 

        }
    }
}
