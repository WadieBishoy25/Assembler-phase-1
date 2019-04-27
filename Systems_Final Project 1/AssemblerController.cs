using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systems_Final_Project_1
{
    class AssemblerController
    {
        InstMatrix instMatrix;
        string[] instructions;
        SplitterClass SC;
        bool Free;

        public AssemblerController (string[] s)
        {
            instructions = s;
            instMatrix = new InstMatrix(s.Length);
            SC = new SplitterClass(this.instMatrix);
            Free = false;
        }

        public void isFreeFormat (bool t)
        {
            this.Free = t;
        }

        public void Split ()
        {
            if (!Free)
           this.instMatrix = SC.FixedFormat(instructions);
        }

    }
}
