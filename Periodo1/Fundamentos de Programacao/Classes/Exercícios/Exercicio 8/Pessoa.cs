class Pessoa
{
    private int idade;
    private string nome;
    public int Idade
    {
        get { return idade; }
        set { idade = value; }
    }
    public string Nome
    {
        get { return nome; }
        set
        {
            if(nome.Length>100)
                Console.WriteLine("\n***Nome inválido!***");
            else
                nome = value;
        }
    }
}