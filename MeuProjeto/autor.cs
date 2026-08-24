namespace MeuProjeto;

public class Autor
{
    private string nome;
    private string nacionalidade;

    public Autor (string nome, string nacionalidade)
    {
        this.nome = nome;
        this.nacionalidade = nacionalidade;
    }
 public string GetNomeAutor()
    {
        return nome;
    }
 public string GetNacionalidade()
    {
        return nacionalidade;
    }



}
