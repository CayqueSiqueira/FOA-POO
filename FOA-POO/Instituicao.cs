using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FOA_POO
{
    public class Instituicao : Gerência
    {
        public string NomeInstituicao = "UniFOA";

        private List<Curso> _cursos;
        public Instituicao()
        {           
            _cursos = new List<Curso>();
        }
        public List<Curso> Cursos
        {
            get => _cursos;
        }

        public void Adicionar()
        {
            var curso = new Curso();
            Console.WriteLine("\nDigite o nome do Curso que deseja adicionar:\n");
            var nomeCurso = Console.ReadLine();
            curso.NomeCurso = nomeCurso;
            Console.WriteLine("\nDigite o código do curso\n");
            var codigoCurso = Console.ReadLine();
            curso.CodigoCurso = codigoCurso;
            Console.Clear();
            // Verificar se o curso já existe na lista
            if (_cursos.Any(c => c.CodigoCurso == codigoCurso))
            {
                Console.WriteLine("Este curso já foi adicionado.");
                return;
            }

            _cursos.Add(curso);
            Console.WriteLine($"Você adicionou o curso {curso.NomeCurso} com código {curso.CodigoCurso}");
        }

        public void Excluir(string codigoCurso)
        {
            var curso = _cursos.Find(c => c.CodigoCurso == codigoCurso);
            if (_cursos.Remove(curso))
            {
                Console.WriteLine($"Curso {curso.NomeCurso} de código {curso.CodigoCurso} removido com sucesso!");
            }
            else
                Console.WriteLine("Este curso não existe na lista.");
        }

        public void Listar()
        {
            foreach (var curso in _cursos)
            {
                Console.WriteLine($"Nome: {curso.NomeCurso}, Código: {curso.CodigoCurso}");
            }
        }

        public int ExibirQuantidade()
        {
            return _cursos.Count;
        }

      
    }
}
