/*Estrutura básica de classe*/
/*Exemplo de programa utilizando classe, imprimir nome e matricula de dois aluno*/
internal class Program
{
    private static void Main(string[] args)
    {
        Aluno obj1 = new Aluno();
        Aluno obj2 = new Aluno();

        obj1.Matricula = 123;
        obj1.Nome = "Ana";

        obj2.Matricula = 125;
        obj2.Nome = "Bruno";

        Console.WriteLine("{0} - {1}", obj1.Matricula, obj1.Nome);
        Console.WriteLine("{0} - {1}", obj2.Matricula, obj2.Nome);
    }
}