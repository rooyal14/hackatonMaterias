using ControllerProject;
using ModelProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] turnos = new string[] { "manha", "tarde", "noite" };
            string[] materias = new string[] { "analise 2p ads", "programação orientada a objetos 2p ads", "analise 2p ads" };
            string[] cursos = new string[] { "ads", "ti manha", "ti tarde" };
            string[] turmas = new string[] { "manha", "tarde", "noite" };

            ProfessorController professorController = new ProfessorController();
            //criando professor
            Professor professor1 = new Professor("10");
            
            turnos.ToList<string>().ForEach((x) => professor1.PrefTurno.Add(x));



            //adicionando professor à lista do controller
            professorController.addProfessorToList(professor1);
            
            Professor professor2 = new Professor("5");





            professorController.addProfessorToList(professor2);
            Console.WriteLine(professorController.getProfessorById("10").PrefTurno[0]);
            Console.WriteLine(professorController.getProfessorById("10").PrefTurno[1]);
            Console.WriteLine(professorController.getProfessorById("10").PrefTurno[2]);
            Console.WriteLine(professorController.getProfessorById("5").Id);




            Console.ReadLine();
        }
    }
}
