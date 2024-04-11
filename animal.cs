// .animal.cs

public class animal{
    public string Especie{get;set;}
    public string Porte{get;set;}
    public string Classe{get;set;}
    public string Alimentacao{get;set;}
    public int Peso{get;set;}
    public int Patas{get;set;}

    public virtual string somEmitido(){
        return "ZZZZZZ";
    }

}