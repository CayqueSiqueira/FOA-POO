using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOA_POO
{
    public class Professor : Pessoa
    {
        
        private string _matricula;
        public string Matricula
        {
            get => _matricula;
            set
            {
                while (value.Length != 6)
                {
                    Console.WriteLine("Matrícula deve ter 6 caracteres");
                    Console.WriteLine("Digite a Matrícula novamente");
                    value = Console.ReadLine();
                }
                _matricula = value;
            }
        }

    }
}
