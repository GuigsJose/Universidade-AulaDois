// ./Universidade.cs
public class Universidade{
    public string Nome{get;set;}
    public string Localizacao{get;set;}
    public int AnoFundacao{get;set;}

    public Universidade(string Nome, string Localizacao, int AnoFundacao)
    {
            this.Nome = Nome;
            this.Localizacao = Localizacao;
            this.AnoFundacao = AnoFundacao;
    }
    //esta propriedade requer refatoração
    public List<Curso> Cursos = new List<Curso>();


    public string exibirInformacoes()  
    {
        return "";
    }

    //Método que recebe um curso e o adiciona na List<Cursos>
    public void adicionarCurso(Curso curso)
    {
        this.Cursos.Add(curso);
    }

    //Método que retorna a lista Cursos
    public List<Curso> GetCursos(){
        return this.Cursos;
    }
}