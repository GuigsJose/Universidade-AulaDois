// //instanciar uma universidade
// Universidade UP = new Universidade();
// UP.Nome = "Universidade Positivo";
// UP.Localizacao = "Praça osório";
// UP.AnoFundacao = 2016;

// Console.WriteLine(UP.Nome);

// // criar um curso e adicionar na universidade
// //instanciar e construir o curso
// Curso curso = new Curso();
// curso.Nome = "Analise e desenvolvimento de sistemas";
// curso.Area = "Computação";
// curso.Duracao = 2;
// UP.adicionarCurso(curso);
// // criar turma 2021
// Turma turma = new Turma();
// turma.AnoFormacao = 2021;
// turma.Sala = "401";
// turma.Turno = "Noturno";
// //adiciona turma ao curso
// //turma 2022
// curso.adicionarTurma(turma);
// turma = new Turma();
// turma.AnoFormacao = 2022;
// turma.Sala = "402";
// turma.Turno = "Manhã";
// // add turma ao curso
// curso.adicionarTurma(turma);
 
// curso = new Curso();
// curso.Nome = "Sistemas de informação";
// curso.Area = "Computação";
// curso.Duracao = 4;
// UP.adicionarCurso(curso);
// //adicionar curso na universidade

// foreach(var Curso in UP.Cursos)
// {
//     Console.WriteLine(Curso.Nome + " - " + Curso.Area);
//     foreach(var T in Curso.Turmas){
//         Console.WriteLine("      "+ T.AnoFormacao);
//     }
// }

professor Professor = new professor("999");
Console.WriteLine(Professor.getNome());
Professor.setNome("vasco");
Professor = new professor("2025","guilherme");
Console.WriteLine(Professor.getNome());