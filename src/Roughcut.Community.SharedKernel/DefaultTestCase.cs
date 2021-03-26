using System;

namespace Roughcut.Community.SharedKernel
{
    public class DefaultTestCase
    {
        public static string FailedTest()
        {
            return "This Does NOT Work!...";
        }

        public static string SuccessfulTest()
        {
            return "This works!...";
        }
    }
}
