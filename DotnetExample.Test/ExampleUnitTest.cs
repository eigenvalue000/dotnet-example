using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotnetExample.Repository;

namespace DotnetExample.Test;

public class UnitTest 
{
    [TestMethod]
    public void TestStartsWithUpper()
    {
        // Tests that we expect to return true.
        string[] words = {"Alphabet", "Zebra", "ABC"};
        foreach (var word in words) {
            bool result = word.StartsWithUpper();
            Assert.IsTrue(result,
                          string.Format("Expected for '{0}: true; Actual: {1}",
                          word, result));
        }
    }

    [TestMethod]
    public void TestDoesNotStartWithUpper()
    {
        // Tests that we expect to return false.
        string[] words = {"alphabet", "zebra", "abc", "1234", ".", ";", " "};
        foreach (var word in words) {
            bool result = word.StartsWithUpper();
            Assert.IsFalse(result,
                    string.Format("Expected for '{0}: false; Actual: {1}",
                    word, result));
        }
    }

    [TestMethod]
    public void DirectCallWithNullOrEmpty() {
        // Tests that we expect to return false.
        string?[] words = { string.Empty, null };
        foreach (var word in words) {
            bool result = ExampleLibrary.StartsWithUpper(word);
            Assert.IsFalse(result,
                    string.Format("Expected for '{0}: false; Actual: {1}",
                    word == null ? "<null>" : word, result));
        }
    }
}