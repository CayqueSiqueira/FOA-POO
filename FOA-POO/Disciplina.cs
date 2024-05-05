using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOA_POO
{
    public class Disciplina : Gerência
    {
        private string _nomeDisciplina;
        private string _codigoDisciplina;
        private List<Aluno> _alunos;
        private List<Professor> _professores;

        public Disciplina()
        {
            _alunos = new List<Aluno>();
            _professores = new List<Professor>();
        }

        public List<Aluno> Alunos
        {
            get => _alunos;
            set => _alunos = value;
        }

        public List<Professor> Professores
        {
            get => _professores;
            set => _professores = value;
        }


        public string NomeDisciplina
        {
            get => _nomeDisciplina.ToUpper();
            set
            {
                while (value.Length < 3)
                {
                    Console.WriteLine("Nome da Disciplina deve ter no mínimo 3 caracteres");
                    Console.WriteLine("Digite o Nome da Disciplina novamente");
                    value = Console.ReadLine();
                }
                _nomeDisciplina = value;
            }
        }
        public string CodigoDisciplina
        {
            get => _codigoDisciplina;
            set
            {
                while (value.Length < 1)
                {
                    Console.WriteLine("Código da Disciplina deve ser maior que 1");
                    Console.WriteLine("Digite o Código da Disciplina novamente");
                    value = Console.ReadLine();
                }
                _codigoDisciplina = value;
            }

        }
        public void Adicionar()
        {
            Console.WriteLine("Você deseja adicionar aluno ou professor?");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "aluno":
                    
                        var aluno = new Aluno();
                        Console.WriteLine("\nDigite o nome do Aluno que deseja adicionar:\n");
                        var nomeAluno = Console.ReadLine();
                        aluno.Nome = nomeAluno;
                        Console.WriteLine("\nDigite a idade do Aluno\n");
                        var idadeAluno = int.Parse(Console.ReadLine());
                        aluno.Idade = idadeAluno;
                        Console.WriteLine("\nDigite o CPF do Aluno\n");
                        var cpfAluno = Console.ReadLine();
                        aluno.CPF = cpfAluno;
                        Console.WriteLine("\nDigite a matrícula do Aluno\n");
                        var matriculaAluno = Console.ReadLine();
                        aluno.Matricula = matriculaAluno;
                        Console.Clear();
                        // Verificar se o aluno já existe na lista
                        if (_alunos.Any(a => a.CPF == cpfAluno))
                        {
                            Console.WriteLine("Este aluno já foi adicionado.");
                            return;
                        }

                        _alunos.Add(aluno);

                        Console.WriteLine($"Você adicionou o aluno {aluno.Nome} com CPF {aluno.CPF} e matrícula {aluno.Matricula}");
                    
                    break;
                case "professor":
                    
                        var professor = new Professor();
                        Console.WriteLine("\nDigite o nome do Professor que deseja adicionar:\n");
                        var nomeProfessor = Console.ReadLine();
                        professor.Nome = nomeProfessor;
                        Console.WriteLine("\nDigite a idade do Professor\n");
                        var idadeProfessor = int.Parse(Console.ReadLine());
                        professor.Idade = idadeProfessor;
                        Console.WriteLine("\nDigite o CPF do Professor\n");
                        var cpfProfessor = Console.ReadLine();
                        professor.CPF = cpfProfessor;
                        Console.WriteLine("\nDigite a matrícula do Professor\n");
                        var matriculaProfessor = Console.ReadLine();
                        professor.Matricula = matriculaProfessor;
                        Console.Clear();
                        // Verificar se o professor já existe na lista
                        if (_professores.Any(p => p.CPF == cpfProfessor))
                        {
                            Console.WriteLine("Este professor já foi adicionado.");
                            return;
                        }

                        _professores.Add(professor);

                        Console.WriteLine($"Você adicionou o professor {professor.Nome} com CPF {professor.CPF} e matrícula {professor.Matricula}");
                    
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
           

            
            

            
            
        }

        public void Excluir(string matricula)
        {

            if (matricula.Length == 3)
            {
                var aluno = _alunos.Find(a => a.Matricula == matricula);
                if (_alunos.Remove(aluno))
                {
                    Console.WriteLine($"Aluno {aluno.Nome} de CPF {aluno.CPF} e matricula {aluno.Matricula} removido com sucesso!");
                }
                else
                    Console.WriteLine("Este aluno não existe na lista.");
            }

            else
            {
                var professor = _professores.Find(p => p.Matricula == matricula);
                if (_professores.Remove(professor))
                {
                    Console.WriteLine($"Professor {professor.Nome} de CPF {professor.CPF} e matricula {professor.Matricula} removido com sucesso!");
                }
                else
                    Console.WriteLine("Este professor não existe na lista.");
            }


        }

        public void Listar()
        {
            foreach (var aluno in _alunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome}, CPF: {aluno.CPF}, Matrícula: {aluno.Matricula}");
            }
            foreach (var professor in _professores)
            {
                Console.WriteLine("Professores: ");
                Console.WriteLine($"Nome: {professor.Nome}, CPF: {professor.CPF}, Matrícula: {professor.Matricula}");
            }
        }

        public int ExibirQuantidade()
        {
            Console.WriteLine("Deseja exibir a quantidade de alunos ou professores?");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "alunos":
                    return _alunos.Count;
                case "professores":
                    return _professores.Count;
                default:
                    return 0;
            }
        }









    }
}