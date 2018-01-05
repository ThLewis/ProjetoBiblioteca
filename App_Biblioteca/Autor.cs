using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Biblioteca
{
    class Autor
    {
        public int cod_autor { get; set; }
        public string nm_autor { get; set; }
        public string pais_ori { get; set; }

        public Autor(int cod, string nome, string pais)
        {
            cod_autor = cod;
            nm_autor = nome;
            pais_ori = pais;
        }

        public Autor(int cod, string nome)
        {
            cod_autor = cod;
            nm_autor = nome;
        }
    }
}
