using NUnit.Framework;

[TestFixture]
public class TestAll
{
    [Test, Description("Test TwoSum method")]
    public static void test1()
    {
        {
            int[] arr = { -1, -1, -9, -7, 3, -6 };
            int X = 2;
            string expected = "-1 3";
            Assert.AreEqual(expected, ConsoleApp.Program.TwoSum(arr, X));
        }
        {
            int[] arr = { 6, 2, 8, -3, 1, 1, 6, 10 };
            int X = 100;
            string expected = "None";
            Assert.AreEqual(expected, ConsoleApp.Program.TwoSum(arr, X));
        }
    }
}
