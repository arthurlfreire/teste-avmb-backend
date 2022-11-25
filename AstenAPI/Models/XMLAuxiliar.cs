namespace AstenAssinaturaAPI.Models
{
    public class XMLAuxiliar
    {
        public string? nomeArquivo { get; set; }
        public string? conteudoXML { get; set; } 
        public List<XMLSignatario>? listaXMLSignatario { get; set; } = new List<XMLSignatario>();
    }
}