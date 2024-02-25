using ControllerProject;
using ModelProject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //exemplos de dados
            string[] turnos = new string[] { "manha", "tarde", "noite" };
            string[] materias = new string[] { "analise 2p ads", "programação orientada a objetos 2p ads", "analise 2p ads" };
            string[] cursos = new string[] { "ads", "ti manha", "ti tarde" };
            string[] turmas = new string[] { "manha", "tarde", "noite" };

            ProfessorController professorController = new ProfessorController();
            //criando professor
            Professor professor1 = new Professor("10");
            professor1.Preferencias[0].PrefTurno = turnos[0];
            professor1.Preferencias[1].PrefTurno = turnos[1];
            professor1.Preferencias[2].PrefTurno = turnos[2];

            Professor professor2 = new Professor("5");

            //adicionando professores à lista do controller
            professorController.addProfessorToList(professor1);
            professorController.addProfessorToList(professor2);
            
            Console.WriteLine(professorController.getProfessorById("10").Preferencias[0].PrefTurno);
            Console.WriteLine(professorController.getProfessorById("10").Preferencias[1].PrefTurno);
            Console.WriteLine(professorController.getProfessorById("10").Preferencias[2].PrefTurno);
            Console.WriteLine(professorController.getProfessorById("5").Id);




            Console.ReadLine();
        }  

        static void DisplayDataTable(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    Console.Write($"{column.ColumnName}: {row[column]} | ");
                }
                Console.WriteLine();
            }
        }
    }
}
