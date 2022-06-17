using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusAluno
{
    internal class Aluno
    {
        public string Nome;
        public double Nota01, Nota02, Nota03;

        public double NotaFinal()
        {
            return Nota01 + Nota02 + Nota03;
        }
        public double RestoNota()
        {
            return 60.0 % NotaFinal();
        }
    }
}
