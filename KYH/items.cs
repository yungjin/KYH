using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYH
{
    class items
    {
        string col1;
        string col2, col3 ;
        public items(string[] a)
        {
            col1 = a[0];
            col2 = a[1];
            col3 = a[2];
        }
        public string getCol()
        {
             return col1;
        }
        public string getCol2()
        {
            return col2;
        }
        public string getCol3()
        {
            return col3;
        }

    }
}
