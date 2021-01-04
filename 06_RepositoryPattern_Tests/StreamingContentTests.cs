using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            StreamingContent content = new StreamingContent();   //<---right clicked on RepositoryPattern_Tests and added reference (to allow this file to access 06_RepositoryPattern_Repository).
                                                                 // Then, right clicked on StreamingContent and hit control . Clicked on using 06_RepositoryPattern_Repository

            content.Title = "Toy Story";

            string expected = "Toy Story";
            string actual = content.Title;

            Assert.AreEqual(expected, actual);  //<-- these names do not have to match above parameters
        }

    }
}
