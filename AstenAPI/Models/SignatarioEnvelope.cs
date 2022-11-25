namespace AstenAssinaturaAPI.Models
{
    public class SignatarioEnvelope
    {
        public Envelope Id { get; set; } = new Envelope();
        public int Ordem { get; set; }
        public string TagAncoraCampos { get; set; }
        public ConfigAssinatura ConfigAssinatura { get; set; } = new ConfigAssinatura();

    }
}