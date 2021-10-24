//Corrected by <Leonides Martinez>

//use for IC08
//Lydi's code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity10
{
    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {
            // Corrected
            // Must Flag variable to indicate whether the it contains element.
            bool containsElement = false;

            for (int i = 0; i < elements.Count; i++)
            {
                
                if (val == elements[i])
                {
                    // Corrected
                    // return is causing the for loop to only loop once. Causing i++ to
                    // be unreachable.
                    //return true;
                    containsElement = true;
                }
                else
                {
                    // Corrected
                    //return false;
                    // Instead, else statement could be deleted or left blank.
                }
                    
            }
            return containsElement;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {
            for (int i = 0; i < rhs.elements.Count; i++)
            {
                this.addElement(rhs.elements[i]);

            }
            // Corrected
            // return is displaying Set passed into method instead of new list.
            //return rhs;
            return this;
        }
    }
}
