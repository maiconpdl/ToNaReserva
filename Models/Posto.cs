namespace Models
{
    public class Posto
    {
        public int id {get; set;}
        public string? nome {get; set;}
        public string? telefone {get; set;}
        public string? pais {get; set;}
        public string? estado {get; set;}
        public string? cidade {get; set;}
        public string? cep {get; set;}
        public string? bairro {get; set;}
        public string? rua {get; set;}
        public string? numero {get; set;}
        public double gasolina {get; set;}
        public double diesel {get; set;}
        public double etanol {get; set;}
        public int estrelas {get; set;}
        public int usuarioid {get; set;}
        
        public ICollection<Produto>? produtos {get; set;}

    }
}