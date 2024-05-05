using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOA_POO
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        private string _cpf;

        public string Nome
        {
            get => _nome.ToUpper();
            set
            {
                while (value.Length < 3)
                {
                    Console.WriteLine("Nome deve ter no mínimo 3 caracteres");
                    Console.WriteLine("Digite o Nome novamente");
                    value = Console.ReadLine();
                }
                _nome = value;
            }

        }
        public int Idade
        {
            get => _idade;
            set
            {
                while (value < 0 || value > 100)
                {
                    Console.WriteLine("A Idade não é válida");
                    Console.WriteLine("Digite a Idade novamente");
                    value = int.Parse(Console.ReadLine());
                }
                _idade = value;
            }
        }
        public string CPF
        {
            get => _cpf;
            set
            {
                while (value.Length != 11)
                {
                    Console.WriteLine("CPF deve ter 11 caracteres");
                    Console.WriteLine("Digite o CPF novamente");
                    value = Console.ReadLine();
                }

                _cpf = value;
            }
        }

    }
}
