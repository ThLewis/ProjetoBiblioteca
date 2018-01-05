using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Biblioteca
{
    class Genero
    {
        public int cod_gen { get; set; }
        public string nm_gen { get; set; }

        public Genero(int cod, string nome)
        {
            cod_gen = cod;
            nm_gen = nome;
        }
    }
}
