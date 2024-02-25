using ModelProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerProject
{
    public class DisciplinaController
    {
        private IList<Disciplina> disciplinas;

        public DisciplinaController()
        {
            disciplinas = new List<Disciplina>();
        }

        public void addDisciplinaToList(Disciplina Disciplina)
        {
            disciplinas.Add(Disciplina);
        }

        public void removeDisciplinaFromList(Disciplina Disciplina)
        {
            disciplinas.Remove(Disciplina);
        }

        public Disciplina getDisciplinaById(string id)
        {
            var DisciplinaSelecionado = disciplinas.Where(x => x.Id == id).FirstOrDefault();
            return DisciplinaSelecionado;
        }

    }
}
