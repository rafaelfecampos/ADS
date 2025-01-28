/*
//Programa chamando classe Aluno com encapsulamento
internal class Program
{
    private static void Main(string[] args)
    {
        Aluno a = new Aluno();
        a.SetMatricula(123);
        a.SetNome("Rafael");
        Console.WriteLine("Nome: {0}\nMatrícula: {1}", a.GetNome(), a.GetMatricula());
    }
}*/

//Programa chamando classe Aluno com encapsulamento utilizando get e set
internal class Program
{
    private static void Main(string[] args)
    {
        Aluno a = new Aluno();
        a.Matricula = 123;
        a.Nome = "Rafael";
        Console.WriteLine("Nome: {0}\nMatrícula: {1}", a.Nome, a.Matricula);
    }
}