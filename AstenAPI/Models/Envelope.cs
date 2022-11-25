namespace AstenAssinaturaAPI.Models
{
    public class Envelope
    {
        public string? descricao { get; set; }
        public Repositorio Repositorio { get; set; } = new Repositorio();
        public string? mensagem { get; set; }
        public string? mensagemObservadores { get; set; }
        public string? mensagemNotificacaoSMS { get; set; }
        public DateTime? dataExpiracao { get; set; }
        public DateTime? horaExpiracao { get; set; }
        public string usarOrdem { get; set; } = "S"; 
        public ConfigAuxiliar ConfigAuxiliar { get; set; } = new ConfigAuxiliar();
        public List<Documento> listaDocumentos { get; set; } = new List<Documento>();
        public List<SignatarioEnvelope> listaSignatariosEnvelope { get; set; } = new List<SignatarioEnvelope>(); 
        public List<Observador> listaObservadores { get; set; } = new List<Observador>();
        public List<Tag> listaTags { get; set; } = new List<Tag>();
        public List<InfoAdicional> listaInfoAdicional { get; set; } = new List<InfoAdicional>();
        public string incluirHashTodasPaginas { get; set; } = "S";
        public string permitirDespachos { get; set; } = "S";
        public string ignorarNotificacoes { get; set; } = "N";
        public string ignorarNotificacoesPendentes { get; set; } = "N";
        public double? qrCodePosLeft { get; set; }
        public double? qrCodePosTop { get; set; }
        public DateTime? dataIniContrato { get; set; }
        public DateTime? dataFimContrato { get; set; }
        public string? objetoContrato { get; set; }
        public int? numContrato { get; set; }
        public decimal? valorContrato { get; set; }
        public string? descricaoContratante { get; set; }
        public string? descricaoContratado { get; set; }
    }
}
