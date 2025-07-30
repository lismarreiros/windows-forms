using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFocare1
{
    internal class Pessoa
    {
        public int Idade { get; set; }
        public string Sexo { get; set; }

        public Pessoa(int idade, string sexo)
        {
            Idade = idade;
            Sexo = sexo;
        }
    }
}
