using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class InClassTypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {

            int age = 32;

            byte someByte = 23;

            int anotherNumber = 23;

            anotherNumber = 256;

            double someDouble = 23.3456534564; //Can add d at the end of number but not necessary
            float someFloat = 23.656548f;
            decimal someDecimal = 23.6587879m;

            char letter = 'm';  //use single quotes
            bool trueOrFalseValue = true;
        }

        [TestMethod]
        public void ReferenceTypes()
        {
            string randomCharacters = "uihsfose eugs123 @&*";
            string specialCharacters = "\"Michael\""; // <--write like this if you want quotations to show up in string when ran
            string otherSpecialCharacter = "\n"; //line return
            Console.WriteLine(specialCharacters);

            DateTime rightNow = DateTime.Now;
            Console.WriteLine(rightNow);
            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            TimeSpan age = DateTime.Now - new DateTime(1988, 04, 11);
            Console.WriteLine(age);

            string[] names = { "Casey", "Michael", "Simon" };
            List<string> fruits = new List<string>();
            fruits.Add("grape");
            fruits.Add("apple");

            Dictionary<char, double> dictionary = new Dictionary<char, double>();   //first one listed is key, second is value; both is a pair
            dictionary.Add('x', 3.1459);
            dictionary['x'] = 3426462.234; //changing the value in the key value pair

            Console.WriteLine(fruits[1]); //runs as apple, if 0, it runs as grape
            Console.WriteLine(dictionary['x']);//runs as 3.1459
        }

    }
}
