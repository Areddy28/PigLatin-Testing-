using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PigLatin
{
    public class TestPigLatin
    {

        [Fact]
        public void AppleWay()
        {


            //Arrange
            PigLatin v = new PigLatin();


            string expected = "appleway";

            // Act
            string actual = v.ToPigLatin("apple");

            //Assert

            Assert.Equal(expected, actual);



        }

        [Fact] 
        public void AaardvarkWay()
        {


            //Arrange
            PigLatin v = new PigLatin();


            string expected = "aardvarkway";

            // Act
            string actual = v.ToPigLatin("aardvark");

            //Assert

            Assert.Equal(expected, actual);

        }

        [Fact] 

        public void HeckAy()
        {

            //Arrange
            PigLatin v = new PigLatin();


            string expected = "eckhay";

            // Act
            string actual = v.ToPigLatin("heck");

            //Assert

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Gym()
        {
            //Arrange
            PigLatin v = new PigLatin();


            string expected = "gym";

            // Act
            string actual = v.ToPigLatin("gym");

            //Assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Tommy()
        {
            //Arrange
            PigLatin v = new PigLatin();


            string expected = "ommytay";

            // Act
            string actual = v.ToPigLatin("Tommy");

            //Assert

            Assert.Equal(expected, actual);

        }

        [Fact]

        public void Strong()
        {
            //Arrange
            PigLatin v = new PigLatin();


            string expected = "ongstray";

            // Act
            string actual = v.ToPigLatin("strong");

            //Assert

            Assert.Equal(expected, actual);

        }



        [Fact]
        public void SpecialCharacterTest()
        {
            PigLatin p = new PigLatin();

            string expected = "tommy@email.com";

            string actual = p.ToPigLatin("tommy@email.com");

            Assert.Equal(expected, actual);
        }

        
        //[Theory]
        //[InlineData("apple", "appleway")]
        //[InlineData("eckway", "eckway")] 
        //public void PigTest(string fruit, string expected)
        //{
        //    PigLatin p = new PigLatin(); 



        //    string actual = p.ToPigLatin(fruit);

        //    Assert.Equal(expected, actual); 


        //}
    }
}

