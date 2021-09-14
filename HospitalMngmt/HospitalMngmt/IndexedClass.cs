using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMngmt
{
    class IndexedClass
    {
        private String[] names = new string[10];
        public String this[int index]
        {
            get
            {
                return (index >= 0 && index <= 9) ? names[index] : "";
            }
            set
            {
                if (index >= 0 && index <= 9)
                {
                    names[index] = value;
                }
            }
        }

        public int this[string name]
        {
            get
            {
                int index = 0;
                while (index < 10)
                {
                    if(names[index] == name)
                    {
                        return index;
                    }
                }
            }
            set
            {
                if (index >= 0 && index <= 9)
                {
                    names[index] = value;
                }
            }
        }
    }
}
