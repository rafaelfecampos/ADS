namespace RecInfra
{
    public class Recado
    {
        public int Id { get; set; }
        public string Mensagem { get; set; } = "";
        public string Remetente { get; set; } = "";
        public string Destinatario { get; set; } = "";
    }
}
