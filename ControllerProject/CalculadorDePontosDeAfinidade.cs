using ModelProject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerProject
{
    public class CalculadorDePontosDeAfinidade
    {
        private IList<Disciplina> disciplinas;
        private IList<Professor> professores;

        public CalculadorDePontosDeAfinidade(IList<Professor> professores, IList<Disciplina> disciplinas)
        {
            this.professores = professores;
            this.disciplinas = disciplinas;
        }


        public DataTable getTabela()
        {
            // Create a DataTable
            DataTable dt = new DataTable();

            // Add columns to the DataTable
            dt.Columns.Add("matriculaProf", typeof(string));
            disciplinas.ToList().ForEach((disciplina) =>
            {
                dt.Columns.Add(disciplina.Id.ToString(), typeof(int));
            });

            professores.ToList().ForEach((Professor) => {
                



            });



            // Create a new DataRow
            var newRow = dt.NewRow().ItemArray;
            newRow[0] = 2022106090024.ToString(); //numero da matricula

            //numero da afinidade
            newRow[1] = 5;
            newRow[2] = 4;
            newRow[3] = 6;
            newRow[4] = 7;
            newRow[5] = 9;


            // Add the new DataRow to the DataTable
            dt.Rows.Add(newRow);

            newRow = dt.NewRow().ItemArray;
            newRow[0] = 202210654.ToString();
            newRow[1] = 3;
            newRow[2] = 7;
            newRow[3] = 9;
            newRow[4] = 2;
            newRow[5] = 5;
            dt.Rows.Add(newRow);

            // Display the DataTable before inserting a new cell
            Console.WriteLine("Before inserting a new cell:");
            DisplayDataTable(dt);
            for (int i = 0; i < professores.Count; i++)
            {
                
            }
            


            return dt;
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
