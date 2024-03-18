public class Estudante {
    public string nome{get;set;}
    public string matricula{get;set;}
    public int idade{get;set;}

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