using Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace LP1___Projeto_Final.Notas
{
    public class NotasDAO
    {
        public List<Nota> List()
        {
            List<Nota> lista = new List<Nota>();
            try
            {
                DataTable objDataTable = null;
                string strSQL = "select * from notes";
                objDataTable = SQL.ExecutaConsultar(CommandType.Text, strSQL);
                if (objDataTable.Rows.Count <= 0)
                {
                    return lista;
                }
               
                foreach (DataRow objLinha in objDataTable.Rows)
                {
                    //public Nota(string Title, string Description, DateTime Date, Boolean Check)
                    string title = objLinha["title"] != DBNull.Value ? Convert.ToString(objLinha["title"]) : "";
                    string description = objLinha["description"] != DBNull.Value ? Convert.ToString(objLinha["description"]) : "";
                    bool check = objLinha["ready"] != DBNull.Value ? Convert.ToBoolean(objLinha["ready"]) : false;
                    DateTime date = objLinha["date"] != DBNull.Value ? Convert.ToDateTime(objLinha["date"]) : DateTime.Now;
                    Nota nota = new Nota(title, description, date, check);
                    lista.Add(nota);
                }
                return lista;

            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return lista;
            }
        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMdd");
        }

        public bool Create(Nota nota)
        {
            try
            {
                SQL.LimparParametros();
                object objRetorno = null;
                if (nota != null)
                {
                    SQL.AdicionarParametros("@title", nota.Title);
                    SQL.AdicionarParametros("@description", nota.Description);
                    SQL.AdicionarParametros("@ready", nota.Check);
                    SQL.AdicionarParametros("@date", GetTimestamp(nota.Date));

                    string strSQL = "insert into notes (title, description, ready, date) VALUES (@title, @description, @ready, @date)";
                    objRetorno = SQL.ExecutarManipulacao(CommandType.Text, strSQL);
                }
                int intResultado = 0;
                if (objRetorno != null)
                {
                    if (int.TryParse(objRetorno.ToString(), out intResultado))
                        return true;
                }
                return false;
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public void UpdateNote(String title, Nota nota)
        {
            try
            {
                SQL.LimparParametros();
                SQL.AdicionarParametros("@title", nota.Title);
                SQL.AdicionarParametros("@description", nota.Description);
                SQL.AdicionarParametros("@ready", nota.Check);
                SQL.AdicionarParametros("@date", GetTimestamp(nota.Date));
                SQL.AdicionarParametros("@c", title);
                SQL.ExecutarManipulacao(CommandType.Text, "UPDATE notes SET title = @title, description = @description, ready = @ready, date = @date WHERE title = @c");
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void DeleteNote(Nota nota)
        {
            try
            {
                SQL.LimparParametros();
                SQL.AdicionarParametros("@title", nota.Title);
                SQL.ExecutarManipulacao(CommandType.Text, "DELETE FROM notes where title = @title"); ;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
