
using MeuProjeto;

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

livro.Apresentar();
