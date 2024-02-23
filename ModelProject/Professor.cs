using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class Professor
    {
        private string id;
        private IList<string> prefTurno;
        private IList<string> prefMateria;
        private IList<string> prefCurso;
        private IList<string> prefTurma;

        public Professor(string id)
        {
            this.id = id;
            prefTurno = new List<string>();
            prefMateria = new List<string>();
            prefCurso = new List<string>();
            prefTurma = new List<string>();
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
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
