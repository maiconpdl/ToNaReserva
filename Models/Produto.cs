namespace Models
{
    public class Produto
    {
        public int id {get; set;}
        public string? nome {get; set;}
        public string? categoria {get; set;}
        public double? valor {get; set;}
        public string? quantidade {get; set;}
        public string? datacadastro {get; set;}
        public int postoid {get; set;}
        //public Byte[] imagem { get; set; }
        //public Posto? posto {get; set;}
    }
}