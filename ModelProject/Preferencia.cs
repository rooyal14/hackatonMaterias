using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class Preferencia
    {
        private string prefTurno;
        private string prefMateria;
        private string prefCurso;
        private string prefTurma;

        public string PrefTurno
        {
            get { return prefTurno; }
            set { prefTurno = value; }
        }

        public string PrefMateria
        {
            get { return prefMateria; }
            set { prefMateria = value; }
        }
        public string PrefCurso
        {
            get { return prefCurso; }
            set { prefCurso = value; }
        }
        public string PrefTurma
        {
            get { return prefTurma; }
            set { prefTurma = value; }
        }
    }
}
