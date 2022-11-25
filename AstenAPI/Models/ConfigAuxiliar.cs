namespace AstenAssinaturaAPI.Models
{
    public class ConfigAuxiliar
    {
        private string _urlCarimboTempo = "https://plataforma.astenassinatura.com.br/";

        public string documentosComXMLs { get; set; } = "N";
        public string urlCarimboTempo
        {
            set
            {
                urlCarimboTempo = _urlCarimboTempo;
            }
        }
    }
}