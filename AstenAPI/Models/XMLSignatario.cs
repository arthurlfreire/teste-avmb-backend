namespace AstenAssinaturaAPI.Models
{
    public class XMLSignatario
    {
        public string? emailSignatario { get; set; }
        public long? idNodeAssinatura { get; set; }  
        public string? restringirTiposCertificados { get; set; }
        public string? restringirPessoaFisica { get; set; }
        public string? restringirPessoaJuridica { get; set; }  
    }
}