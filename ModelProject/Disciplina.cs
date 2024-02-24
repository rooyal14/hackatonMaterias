using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class Disciplina
    {
        private string id;
        private string turno;
        private string nomeMateria;
        private string curso;
        private string turma;
        
        public Disciplina(string id)
        {
            this.id = id;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }
        public string NomeMateria
        {
            get { return nomeMateria; }
            set { nomeMateria = value; }
        }
        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        public string Turma
        {
            get { return turma; }
            set { turma = value; }
        }
    }
}
