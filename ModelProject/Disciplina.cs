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
        private string nome;
        private string curso;
        private string turma;
        
        public Disciplina(string id)
        {
            this.id = id;
        }
    }
}
