
using System.Collections;
using MeuProjeto;

int opcao;
List<Livro> livros = new List<Livro>();

do
{
    Console.WriteLine("===SISTEMA LIVRARIA===");
    Console.WriteLine("1 - Cadastrar Livros");
    Console.WriteLine("2 - Listar Livros");
    Console.WriteLine("3 - Sair");
    opcao =  int.Parse(Console.ReadLine()  ?? "");

    switch (opcao)
    {
        case 1:
           
            Console.WriteLine("Digite o nome do livro: ");
            string nomeLivro = Console.ReadLine() ?? "";

            Console.WriteLine("Digite o nome do autor: ");
            string autorLivro = Console.ReadLine()  ?? "";

            Console.WriteLine("Digite a nacionalidade do autor: ");
            string autorNacionalidade = Console.ReadLine()  ?? "";


            Console.WriteLine("Digite o gênero do livro: ");
            string generoLivro = Console.ReadLine()  ?? "";

            Console.WriteLine("Digite o ano de lançamento do livro: ");
            int anoLivro = int.Parse(Console.ReadLine()  ?? "");

            Autor autor = new Autor(
                autorLivro,
                autorNacionalidade
            );

            Livro livro = new Livro (
                nomeLivro,
                anoLivro,
                generoLivro,
                autor
            );

            livros.Add(livro);

            break;

         case 2:


                if (livros.Count == 0)
                {
                    Console.WriteLine("Nenhum livro cadastrado.");
                }
                else
                {
                    int i = 1;
                    foreach (Livro livroCadastrado in livros)
                    {   
                
                    
                            Console.WriteLine($"===LIVRO {i}===");
                            livroCadastrado.Apresentar();

                            i++;
                }}

            break;

        
        case 3:
             Console.WriteLine("Encerrando...");
             break;

        default:

            Console.WriteLine("Opção Inválida!");
            break;
    }

       

}while(opcao != 3);



