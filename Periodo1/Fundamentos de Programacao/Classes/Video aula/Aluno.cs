/*class Aluno
//Esncapsulamento
{
    public int GetMatricula()
    {
        return matricula;
    }
    public void SetMatricula(int novaMat)
    {
        if (novaMat < 0)
            matricula = novaMat * -1;
        else
            matricula = novaMat;
    }
    public string GetNome()
    {
        return nome;
    }
    public void SetNome(string novoNome)
    {
        nome = novoNome;
    }
    private int matricula;
    private string nome;
}*/

//Encapsulamento utilizando a propriedade get e set
class Aluno
{
    private int matricula;
    private string nome;
    public int Matricula
    {
        get { return matricula; }
        set
        {
            if (value < 0)
                matricula = value * -1;
            else
                matricula = value;
        }
    }
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
}