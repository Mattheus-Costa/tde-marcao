namespace MeuProjeto;

public class Livro
{
    private string nome;
    private string genero;
    private int ano;

    private Autor autor;

    public Livro (string nome, int ano, string genero, Autor autor)
    {
        this.nome = nome;
        this.ano = ano;
        this.genero = genero;
        this.autor = autor;
        
    }

    public string GetNome()
    {
        return nome;
    }

     public string GetGenero()
    {
        return genero;
    }

     public int GetAno()
    {
        return ano;
    }


     public Autor GetAutor()
    {
        return autor;
    }


    public void Apresentar()
    {
        Console.WriteLine($"Título: {GetNome()}, Gênero: {GetGenero()}, Ano: {GetAno()}, Autor: {autor.GetNomeAutor()}, Nacionalidade do Autor: {autor.GetNacionalidade()} ");
    }
}
