using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Biblioteca
{
    class Editora
    {
        public int cod_editora { get; set; }
        public string nm_editora { get; set; }
        public string end_editora { get; set; }

        public Editora(int cod, string nome, string end)
        {
            cod_editora = cod;
            nm_editora = nome;
            end_editora = end;
        }

    }
}
