using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systems_Final_Project_1
{
    class SplitterClass 
    {
        InstMatrix M;

        public SplitterClass(InstMatrix m)
        {
            this.M = m;

        }

        public InstMatrix FixedFormat (String[] s)
        {
            char[] tempC = new char[30];
            string tempS;

             for (int i = 0; i < s.Length; i++)
                {
                char[] c = s[i].ToCharArray();
                if (c[0] == '.')
                {
                    M.insm[i, 3] = s[i];
                }
                else
                {
                    for (int j = 0; j < 8; j++)
                    {
                        tempC[j] = c[j];
                    }

                    tempS = tempC.ToString();
                    M.insm[i, 0] = tempS;

                    for (int j = 9; j < 15; j++)
                    {
                        tempC[j] = c[j];
                    }

                    tempS = tempC.ToString();
                    M.insm[i, 1] = tempS;

                    for (int j = 17; j < 35; j++)
                    {
                        tempC[j] = c[j];
                    }

                    tempS = tempC.ToString();
                    M.insm[i, 2] = tempS;

                    for (int j = 35; j < s[i].Length; j++)
                    {
                        tempC[j] = c[j];
                    }

                    tempS = tempC.ToString();
                    M.insm[i, 3] = tempS;
                }
            }

            return M;

        }

    }
}
