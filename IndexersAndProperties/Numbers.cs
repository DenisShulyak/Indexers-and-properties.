using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersAndProperties
{
    class Numbers
    {
        private int[] numbers;
        public Numbers()
        {
            numbers = new int[10];
        }

        public int this[int index]
        {
            get
            {
                return numbers[index];
            }
            set
            {
                numbers[index] = value * value;
            }
        }
    }
}
