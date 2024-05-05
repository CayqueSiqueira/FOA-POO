using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOA_POO
{
    public class Curso : Gerência
    {
        private string _nomeCurso;
        private string _codigoCurso;
        private List<Disciplina> _disciplinas;

        public Curso()
        {
            _disciplinas = new List<Disciplina>();
        }

        public List<Disciplina> Disciplinas
        {
            get => _disciplinas;
            set => _disciplinas = value;
        }


        public string NomeCurso
        {
            get => _nomeCurso;
            set
            {
                while (value.Length < 3)
                {
                    Console.WriteLine("Nome do curso deve ter no mínimo 3 caracteres");
                    Console.WriteLine("Digite o Nome do curso novamente");
                    value = Console.ReadLine();
                }
                _nomeCurso = value;

            }
        }
        public string CodigoCurso
        {
            get => _codigoCurso;
            set
            {
                while (value.Length != 6)
                {
                    Console.WriteLine("Código do curso deve ter 6 caracteres");
                    Console.WriteLine("Digite o Código do curso novamente");
                    value = Console.ReadLine();
                }
                _codigoCurso = value;
            }
        }

        public void Adicionar()
        {
            var disciplina = new Disciplina();
            Console.WriteLine("\nDigite o nome da Disciplina que deseja adicionar:\n");
            var nomeDisciplina = Console.ReadLine();
            disciplina.NomeDisciplina = nomeDisciplina;
            Console.WriteLine("\nDigite o código da disciplina\n");
            var codigoDisciplina = Console.ReadLine();
            disciplina.CodigoDisciplina = codigoDisciplina;
            Console.Clear();
            // Verificar se o curso já existe na lista
            if (_disciplinas.Any(d => d.CodigoDisciplina == codigoDisciplina))
            {
                Console.WriteLine("Esta disciplina já foi adicionada.");
                return;
            }

            _disciplinas.Add(disciplina);

            Console.WriteLine($"Você adicionou a disciplina {disciplina.NomeDisciplina} com código {disciplina.CodigoDisciplina}");      
        }
        public void Excluir(string codigoDisciplina)
        {
            var disciplina = _disciplinas.Find(d => d.CodigoDisciplina == codigoDisciplina);
                
            if (_disciplinas.Remove(disciplina))
            {
                Console.WriteLine($"Disciplina {disciplina.NomeDisciplina} de código {disciplina.CodigoDisciplina} removida com sucesso!");
            }
            else
                Console.WriteLine("Esta disciplina não existe na lista.");
        }

        public void Listar()
        {
            foreach (var disciplina in _disciplinas)
            {
                Console.WriteLine($"Disciplina: {disciplina.NomeDisciplina}, Código: {disciplina.CodigoDisciplina}");
            }
        }
        public int ExibirQuantidade()
        {
            return _disciplinas.Count;
        }





     
    }
}
