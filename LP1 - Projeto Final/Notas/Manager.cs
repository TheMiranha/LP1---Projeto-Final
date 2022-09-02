using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP1___Projeto_Final.Notas
{
    internal class Manager
    {

        public static List<Nota> notas = new List<Nota>();

        public static void AddNota(Nota nota)
        {
            notas.Add(nota);
        }

    }
}
