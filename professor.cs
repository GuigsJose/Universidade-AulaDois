// ./ professor.cs

public class professor{

    private string cpf{get;set;}

    private string nome;

    public professor(string cpf)
    {
        this.nome = nome;
        this.cpf = cpf;
        if(cpf == "888"){
            this.nome = "Pedro de lara";
        }else if(cpf=="999"){
            this.nome = "Araci de almeida";
        }
    }
    public professor(string cpf, string nome)
    {
        this.cpf = cpf;
        this.nome = nome;
    }

    //atribui string ao nome

    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public string getNome()
    {
        return this.nome;
    }

    public void setCpf(string cpf)
    {
        this.cpf = cpf;
    }

    public string getCpf()
    {
        return this.cpf;
    }

}