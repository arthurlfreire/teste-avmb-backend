namespace AstenAssinaturaAPI.Models
{
    public class Documento
    {
        public string nomeArquivo { get; set; }
        public string mimeType { get; set; }
        public string conteudo { get; set; }
        public List<XMLAuxiliar> listaXMLAuxiliar { get; set; } = new List<XMLAuxiliar>();
    }
}