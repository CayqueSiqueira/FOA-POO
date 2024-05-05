using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOA_POO
{
    public class Aluno : Pessoa
    {
        private string _matricula;
        private string _curso;
        private List<Disciplina> _disciplinas;

        public Aluno()
        {
            _disciplinas = new List<Disciplina>();
        }
        


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
        public string Curso
        {
            get => _curso;
            set
            {
                while (value.Length < 3)
                {
                    Console.WriteLine("Curso deve ter no mínimo 3 caracteres");
                    Console.WriteLine("Digite o Curso novamente");
                    value = Console.ReadLine();
                }
                _curso = value;
            }
        }

    }
}
