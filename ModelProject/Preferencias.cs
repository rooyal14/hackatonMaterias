using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class Preferencias
    {
        private IList<string> prefTurno;
        private IList<string> prefMateria;
        private IList<string> prefCurso;
        private IList<string> prefTurma;

        public Preferencias()
        {
            prefTurno = new List<string>();
            prefMateria = new List<string>();
            prefCurso = new List<string>();
            prefTurma = new List<string>();
        }
        public IList<string> PrefTurno
        {
            get { return prefTurno; }
            set { prefTurno = value; }
        }

        public IList<string> PrefMateria
        {
            get { return prefMateria; }
            set { prefMateria = value; }
        }
        public IList<string> PrefCurso
        {
            get { return prefCurso; }
            set { prefCurso = value; }
        }
        public IList<string> PrefTurma
        {
            get { return prefTurma; }
            set { prefTurma = value; }
        }
    }
}
