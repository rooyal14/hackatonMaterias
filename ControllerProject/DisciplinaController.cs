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
        private IList<Disciplina> Disciplinas;

        public DisciplinaController()
        {
            Disciplinas = new List<Disciplina>();
        }

        public void addDisciplinaToList(Disciplina Disciplina)
        {
            Disciplinas.Add(Disciplina);
        }

        public void removeDisciplinaFromList(Disciplina Disciplina)
        {
            Disciplinas.Remove(Disciplina);
        }

        public Disciplina getDisciplinaById(string id)
        {
            var DisciplinaSelecionado = Disciplinas.Where(x => x.Id == id).FirstOrDefault();
            return DisciplinaSelecionado;
        }

    }
}
