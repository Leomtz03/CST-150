//Corrected by <Leonides Martinez>

//use for IC08
//Lydi's code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity10
{
    class Program
    {
        static void Main(string[] args)
        {
            //make some sets
            Set A = new Set();
            Set B = new Set();
            Set C = new Set();

            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            // Corrected
            // Transferred Set A to Set C to later reference the original list for Set A.
            C.union(A);
            Console.WriteLine("A union B: " + A.union(B));
            
            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            //Corrected
            // Displayed Set C which was Set A before union.
            Console.WriteLine("A: " + C);
            Console.WriteLine("B: " + B);

        }
    }
}
