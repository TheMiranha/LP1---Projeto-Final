using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP1___Projeto_Final.Notas
{
    internal class Nota
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public Boolean Check { get; set; }
        public Nota(string Title)
        {
            this.Title = Title;
            this.Description = "";
            this.Date = DateTime.Now;
            this.Check = false;
        }
        public Nota(string Title, string Description)
        {
            this.Title = Title;
            this.Description = Description;
            this.Date = DateTime.Now;
            this.Check = false;
        }
        public Nota(string Title, string Description, DateTime Date)
        {
            this.Title = Title;
            this.Description = Description;
            this.Date = Date;
            this.Check = false;
        }
        public Nota(string Title, string Description, DateTime Date, Boolean Check)
        {
            this.Title = Title;
            this.Description = Description;
            this.Date = Date;
            this.Check = Check;
        }
    }
}
