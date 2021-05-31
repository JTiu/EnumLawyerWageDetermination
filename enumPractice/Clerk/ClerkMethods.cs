using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumPractice.Clerk
{
    public class ClerkMethods
    {
        int clerkTotalEmployees;
        public ClerkMethods(int clerkTotalEmployees)
        {
            Console.WriteLine($"This office has a total employee count: {clerkTotalEmployees}");
        }
    }
}
