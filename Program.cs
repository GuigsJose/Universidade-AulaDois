//instanciar uma universidade
Universidade UP = new Universidade();
UP.Nome = "Universidade Positivo";
UP.Localizacao = "Praça osório";
UP.AnoFundacao = 2016;

Console.WriteLine(UP.Nome);

// criar um curso e adicionar na universidade
//instanciar e construir o curso
Curso ADS = new Curso();
ADS.Nome = "Analise e desenvolvimento de sistemas";
ADS.Area = "Computação";
ADS.Duracao = 2;
Curso BSI = new Curso();
BSI.Nome = "Analise e desenvolvimento de sistemas";
BSI.Area = "Computação";
BSI.Duracao = 4;
//adicionar curso na universidade
UP.adicionarCurso(ADS);
UP.adicionarCurso(BSI);

foreach(var Curso in UP.Cursos)
{
    Console.WriteLine(Curso.Nome + " - " + Curso.Area);
}