namespace Models
{
    public class Avaliacao
    {
        public int id {get; set;}
        public string? comentario {get; set;}
        public int estrelas {get; set;}
        public int postoid {get; set;}
        public int usuarioid {get; set;}
        public Posto? posto {get; set;}
        public Usuario? usuario {get; set;}
    }
}