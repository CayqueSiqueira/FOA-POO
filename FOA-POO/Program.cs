using FOA_POO;

var faculdade = new Instituicao(); //faculdade new Faculdade();
var aluno = new Aluno();
var professor = new Professor();
var disciplina = new Disciplina();
var curso = new Curso();


bool continuaMenu = true;
/*do
    {
     try
     {
      Console.WriteLine("\nEscolha a Opção desejada:\n\n1 - Adicionar Curso\n2 - Listar Curso\n3 - Detalhes do Curso\n4 - Excluir Curso\n9 - Fechar o menu\n");
     var resposta = int.Parse(Console.ReadLine());
     switch (resposta)

     {
         case 1:
             Console.Clear();
             Console.WriteLine("Você escolheu a opção de Adicionar Curso");
             Console.WriteLine("\nOlá, você está no Menu Principal de cadastro de Cursos do UniFOA");

             faculdade.Adicionar();

     

             bool continuaCurso = true;
        do
             {
             Console.WriteLine("\nPressione 0 para voltar ao Menu de Cadastro de Curso \nPressione 1 para Opções de Aluno \nPressione 2 para Opções de Professor \nPressione 3 para Opções de Disciplina\n");
             int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                      Console.Clear();
                      Console.WriteLine("Você escolheu a opção de Aluno\n");
                      Console.WriteLine("1 para Adicionar Aluno");
                      Console.WriteLine("2 para Remover Aluno");
                      Console.WriteLine("3 para Listar Alunos\n");
                      var escolhaAluno = int.Parse(Console.ReadLine());

                      switch (escolhaAluno)
                      {
                        case 1:
                            disciplina.Adicionar();
                            break;
                        case 2:
                            Console.Clear();    
                            Console.WriteLine("\nDigite a matricula do Aluno que deseja remover");
                            var matriculaAluno = Console.ReadLine();
                            var alunoRemover = disciplina.Alunos.FirstOrDefault(a => a.Matricula == matriculaAluno);
                            if (alunoRemover != null)
                            {
                                //disciplina.Excluir(alunoRemover);
                                Console.WriteLine("\nAluno removido com sucesso.");
                            }
                            else
                            {
                                Console.WriteLine("\nAluno não encontrado.");
                            }
                            break;
                            case 3:
                                disciplina.Listar();
                            break;
                            default:
                                Console.Clear();
                                Console.WriteLine("\nValor não aceito");
                            break;
                      }
                break;

                case 2:
                      Console.Clear();
                      Console.WriteLine("Você escolheu a opção de Professor\n");
                      Console.WriteLine("1 para Adicionar Professor");
                      Console.WriteLine("2 para Remover Professor");
                      Console.WriteLine("3 para Listar Professor\n");
                      var escolhaProfessor = int.Parse(Console.ReadLine());

                      switch (escolhaProfessor)
                      {
                            case 1:
                                disciplina.Adicionar();
                            break;
                            case 2:
                                Console.WriteLine("Digite a matricula do Professor que deseja remover");
                                var matriculaProfessor = Console.ReadLine();
                                var professorRemover = disciplina.Professores.FirstOrDefault(a => a.Matricula == matriculaProfessor);
                                    if (professorRemover != null)
                                    {
                                        //disciplina.Excluir(professorRemover);
                                        Console.WriteLine("Professor removido com sucesso.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Professor não encontrado.");
                                    }
                                    break;
                            case 3:
                                disciplina.Listar();
                            break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Valor não aceito");
                            break;
                      }
                break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Você escolheu a opção de Disciplina");
                    Console.WriteLine("1 para Adicionar Disciplina");
                    Console.WriteLine("2 para Remover Disciplina");
                    Console.WriteLine("3 para Listar Disciplina");
                    var escolhaDisciplina = int.Parse(Console.ReadLine());

                    switch (escolhaDisciplina)
                    {
                        case 1:
                            curso.Adicionar();
                        break;
                        case 2:
                            Console.WriteLine("Digite o nome da Disciplina que deseja remover");
                            var nomeDisciplina = Console.ReadLine();
                            var disciplinaRemover = curso.Disciplinas.FirstOrDefault(a => a.NomeDisciplina == nomeDisciplina);
                            if (disciplinaRemover != null)
                            {
                                //faculdade.RemoverDisciplina(disciplinaRemover);
                                Console.WriteLine("Disciplina removida com sucesso.");
                            }
                            else
                            {
                                Console.WriteLine("Disciplina não encontrada.");
                            }
                            break;
                            case 3:
                                curso.Listar();
                            break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Valor não aceito");
                            break;
                            }
                break;

                case 0:
                    continuaCurso = false;
                break;
                }
         }

        while (continuaCurso == true);

         break;

         case 2:
             Console.Clear();
             Console.WriteLine("Você escolheu a opção de Listar Curso");
             faculdade.Listar();
         break;

         case 3:
             Console.Clear();
             Console.WriteLine("Você escolheu a opção de Obter Detalhes de um curso");
             Console.WriteLine("Digite o código do curso que deseja ver os detalhes");
             var codigo = Console.ReadLine();
                            
                            
         break;

         case 4:
             Console.Clear();
             Console.WriteLine("Você escolheu a opção de Excluir Curso");

             Console.WriteLine("Digite o código do curso que deseja excluir");   
                            
             var codigoCurso = Console.ReadLine();
             faculdade.Excluir(codigoCurso);                          
             break;

         case 9:
             Console.Clear();
             Console.WriteLine("Obrigado por utilizar o sistema. Até a próxima!");
             continuaMenu = false;
         break;

         default:
             Console.Clear();
             Console.WriteLine("Valor não aceito. Digite apenas as opçoes disponíveis");
         break;
            }
     }
     catch (FormatException)
     {
        Console.Clear();
        Console.WriteLine("Formato Inválido. Digite apenas números de 1 a 3");
     }

    }
while (continuaMenu == true);*/
///////// ------------------------------------------------------------------------------- ///////////
///////// ------------------------------------------------------------------------------- ///////////
///////// ------------------------------------------------------------------------------- ///////////
do
{
    Console.WriteLine("\nBem vindo ao menu principal, escolha o menu desejado:\n\n1 - Menu de Curso\n2 - Menu de Disciplina\n3 - Menu de aluno\n4 - Menu de professor\n0 - Fechar o menu\n");
    var resposta = int.Parse(Console.ReadLine());
    switch (resposta)
    {
        case 1:

            bool continuaMenuCurso = true;
            do {
                Console.Clear();
                Console.WriteLine("\nMenu de curso, escolha a Opção desejada:\n\n1 - Adicionar Curso\n2 - Listar Curso\n3 - Detalhes do Curso\n4 - Excluir Curso\n\n9 - Voltar ao menu principal\n0 - Fechar o menu\n");
                var respostaCurso = int.Parse(Console.ReadLine());
                switch (respostaCurso)

                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Você escolheu a opção de Adicionar Curso");
                        Console.WriteLine("\nOlá, você está no Menu Principal de cadastro de Cursos do UniFOA");

                        faculdade.Adicionar();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Você escolheu a opção de Listar Curso");
                        faculdade.Listar();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Você escolheu a opção de Obter Detalhes de um curso");
                        Console.WriteLine("Digite o código do curso que deseja ver os detalhes");
                        var codigo = Console.ReadLine();

                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Você escolheu a opção de Excluir Curso");

                        Console.WriteLine("Digite o código do curso que deseja excluir");

                        var codigoCurso = Console.ReadLine();
                        faculdade.Excluir(codigoCurso);
                        break;
        
                    case 9:
                        continuaMenuCurso = false;
                        break;

                    case 0:
                        continuaMenuCurso = false;
                        continuaMenu = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Valor não aceito. Digite apenas as opçoes disponíveis");
                        break;
                }
            }
            while (continuaMenuCurso == true);
            break;
        case 2:
            
            bool continuaMenuDisciplina = true;
            do
            {
                Console.Clear();
                Console.WriteLine("\nMenu de Disciplina, escolha a Opção desejada:\n\n1 - Adicionar Disciplina\n2 - Remover Disciplina\n3 - Listar Disciplina\n\n9 - Voltar ao menu principal\n0 - Fechar o menu\n");
                var respostaDisciplina = int.Parse(Console.ReadLine());
                switch (respostaDisciplina)

                {
                    case 1:
                        curso.Adicionar();
                        break;

                    case 2:
                        Console.WriteLine("Digite o nome da Disciplina que deseja remover");
                        var nomeDisciplina = Console.ReadLine();
                        var disciplinaRemover = curso.Disciplinas.FirstOrDefault(a => a.NomeDisciplina == nomeDisciplina);
                        if (disciplinaRemover != null)
                        {
                            //faculdade.RemoverDisciplina(disciplinaRemover);
                            Console.WriteLine("Disciplina removida com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("Disciplina não encontrada.");
                        }
                        break;

                    case 3:
                        curso.Listar();
                        break;

                    case 4:

                        break;

                    case 9:
                        continuaMenuDisciplina = false;
                        break;

                    case 0:
                        continuaMenuDisciplina = false;
                        continuaMenu = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Valor não aceito. Digite apenas as opçoes disponíveis");
                        break;
                }
            }
            while (continuaMenuDisciplina == true);
            break;
        case 3:
            
            bool continuaMenuAluno = true;
            do
            {
                Console.Clear();
                Console.WriteLine("\nMenu de aluno, escolha a Opção desejada:\n\n1 - Adicionar aluno\n2 - Remover aluno\n3 - Listar Disciplina\n\n9 - Voltar ao menu principal\n0 - Fechar o menu\n");
                var respostaAluno = int.Parse(Console.ReadLine());
                switch (respostaAluno)

                {
                    case 1:
                        disciplina.Adicionar();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("\nDigite a matricula do Aluno que deseja remover");
                        var matriculaAluno = Console.ReadLine();
                        var alunoRemover = disciplina.Alunos.FirstOrDefault(a => a.Matricula == matriculaAluno);
                        if (alunoRemover != null)
                        {
                            //disciplina.Excluir(alunoRemover);
                            Console.WriteLine("\nAluno removido com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("\nAluno não encontrado.");
                        }
                        break;

                    case 3:
                        disciplina.Listar();
                        break;

                    case 4:

                        break;

                    case 9:
                        continuaMenuAluno = false;
                        break;

                    case 0:
                        continuaMenuAluno = false;
                        continuaMenu = false;
                        break;
                }
            }
            while (continuaMenuAluno == true);
            break;

        case 4:
           
            bool continuaMenuProfessor = true;
            do
            {
                Console.Clear();
                Console.WriteLine("\nMenu de aluno, escolha a Opção desejada:\n\n1 - Adicionar professor\n2 - Remover professor\n3 - Listar professor\n\n9 - Voltar ao menu principal\n0 - Fechar o menu\n");
                var respostaProfessor = int.Parse(Console.ReadLine());
                switch (respostaProfessor)

                {
                    case 1:
                        disciplina.Adicionar();
                        break;

                    case 2:
                        Console.WriteLine("Digite a matricula do Professor que deseja remover");
                        var matriculaProfessor = Console.ReadLine();
                        var professorRemover = disciplina.Professores.FirstOrDefault(a => a.Matricula == matriculaProfessor);
                        if (professorRemover != null)
                        {
                            //disciplina.Excluir(professorRemover);
                            Console.WriteLine("Professor removido com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("Professor não encontrado.");
                        }
                        break;

                    case 3:
                        disciplina.Listar();
                        break;

                    case 4:

                        break;

                    case 9:
                        continuaMenuProfessor = false;
                        break;

                    case 0:
                        continuaMenuDisciplina = false;
                        continuaMenu = false;
                        break;
                }
            }
            while (continuaMenuProfessor == true);
            break;

        case 0:
            continuaMenu = false;
            break;
    }

}
while (continuaMenu == true);


