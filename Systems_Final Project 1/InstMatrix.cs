using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systems_Final_Project_1
{
    class InstMatrix
    {

        public object[,] insm;

        public InstMatrix (int n)
        {
             this.insm = new object [n,6]; 
        }
    }
}
