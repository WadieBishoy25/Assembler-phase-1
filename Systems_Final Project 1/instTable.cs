using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systems_Final_Project_1
{
    class instTable
    {
        string instsOfF1;
        string[] instsOfF2 ;
        string[] instsOfF3F4 ;
        string[] directives ;

        public instTable()
        {
            instsOfF1 = "RSUB";
            instsOfF2 = new string[] { "RMO", "ADDR", "SUBR", "COMR", "TIXR" };
            instsOfF3F4 = new string[] { "LDR", "STR", "LDCH", "STCH", "ADD", "SUB", "COMP", "J", "JEQ", "JLT", "JGT", "TIX" };
            directives = new string[] { "START", "END", "BYTE", "WORD", "RESW", "RESB", "EQU", "ORG", "BASE" };
        }

        public Tuple<bool , int> isInstruction (string operation , string operand)
        {
            if (instsOfF2.Contains(operation, StringComparer.OrdinalIgnoreCase))
                return Tuple.Create(true, 2);
            else if (instsOfF1.Equals(operation, StringComparison.OrdinalIgnoreCase))
                return Tuple.Create(true, 1);
            else if (instsOfF3F4.Contains(operation, StringComparer.OrdinalIgnoreCase))
                return Tuple.Create(true, 3);
            else if (operation.ElementAt(0) == '+' && instsOfF3F4.Contains(operation.Substring(1), StringComparer.OrdinalIgnoreCase))
                return Tuple.Create(true, 4);
            else if (directives.Contains(operation, StringComparer.OrdinalIgnoreCase))
                return Tuple.Create(true, DirectiveLength(operation,operand));
            else
                return Tuple.Create(false, 0);
        }

        public int DirectiveLength (string operation , string operand)
        {
            if (operation.Equals(directives[0]) || operation.Equals(directives[1]))
                return 0;
            else if (operation.Equals(directives[4]) || operation.Equals(directives[5]))
                return Int32.Parse(operand);
            else
                return 0;
        }
    }
}
