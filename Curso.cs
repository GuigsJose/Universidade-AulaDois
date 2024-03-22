// ./Curso.cs

public class Curso{
    public string Nome{get;set;}
    public int Duracao{get;set;}
    public string Area{get;set;}
    public List<Turma> Turmas = new List<Turma>();

       public string exibirInformacoes()  
    {
        return "";
    }
    // método para adicionar turmas a classe Turma
    public void adicionarTurma(Turma turma)
    {
        this.Turmas.Add(turma);
    }
    // método para retornar Lista de turmas
    public List<Turma> GetTurmas()
    {
        return this.Turmas;
    }
}