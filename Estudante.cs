// ./Estudante

public class Estudante {
    public string Nome{get;set;}
    public string Matricula{get;set;}
    public int Idade{get;set;}

    public List<Curso> cursos = new List<Curso>();
    public List<Turma> turmas = new List<Turma>();
    public string exibirInformacoes(){
        return "";
    }

    public void Matricular(Curso curso, Turma turma){
        cursos.Add(curso);
        turmas.Add(turma);
    }
}