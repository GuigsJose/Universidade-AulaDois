// ./ave.cs
public class ave : animal{
    public string tipoPlumagem{get;set;}
    override
    public string somEmitido()
    {
        string retorno = base.somEmitido() + " gorjeia";
        return retorno;
    }
}