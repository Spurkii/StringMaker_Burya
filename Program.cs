using System;

// Mark Burya
// IT113
// NOTES: for reverse, I used some code that my group and I made from our group project from our in class assignment.
//        for the second test, I'm assuming that "one two five three" is supposed to be "one two five four"
//        because Sunbeam Tiger can't be "one two five three" and can only be "one two five four".
//        Symmetric was simple and was just comparing the string to its reverse.
// BEHAVIORS NOT IMPLIMENTED AND WHY: I believe I did everything correctly as asked from the assignment aside
// from test 2 as noted before
namespace StringMaker_Burya
{
    class Program
    {
        static void Main(string[] args)
        {

            StringManager manager = new StringManager();

            Console.WriteLine("Test 1: " + manager.Reverse("Sunbeam Tiger"));
            Console.WriteLine("Test 2: " + manager);
            Console.WriteLine("Test 3: " + manager.Reverse("Sunbeam Tiger", true));
            Console.WriteLine("Test 4: " + manager.Equals("Sunbeam Tiger"));
            Console.WriteLine("Test 5: " + manager.Symmetric("ABBA"));
            Console.WriteLine("Test 6: " + manager.Symmetric("ABA"));
            Console.WriteLine("Test 7: " + manager.Symmetric("ABba"));
        }
    }
}
