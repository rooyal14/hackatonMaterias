using ModelProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerProject
{
    public class ProfessorController
    {
        private IList<Professor> professores;

        public ProfessorController()
        {
            professores = new List<Professor>();
        }

        public void addProfessorToList(Professor professor)
        {
            professores.Add(professor);
        }

        public void removeProfessorFromList(Professor professor)
        {
            professores.Remove(professor);
        }

        //public Professor getProfessorById(string id)
        {
            
        }

    }
}
