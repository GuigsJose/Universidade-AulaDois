// ./Turma

public class Turma
{
    public int AnoFormacao{get;set;}
    public string Turno{get;set;}
    public string Sala{get;set;}
    public List<Estudante> Estudantes = new List<Estudante>();

    public string exibirInformacoes()
    {
        return "";
    }

    public void adicionarEstudantes(Estudante estudante){
        this.Estudantes.Add(estudante);
    }

    public List<Estudante> GetEstudantes()
    {
        return this.Estudantes;
    }

    


}