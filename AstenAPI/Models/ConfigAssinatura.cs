namespace AstenAssinaturaAPI.Models
{
    public class ConfigAssinatura
    {
        public string? emailSignatario { get; set; }
        public string? nomeSignatario { get; set; }
        public string tipoAssinatura { get; set; } = "1";
        public string permitirDelegar { get; set; } = "N";
        public string apenasCelular { get; set; } = "N";
        public string exigirLogin { get; set; } = "N";
        public string exigirCodigo { get; set; } = "N";
        public string exigirDadosIdentif { get; set; } = "N";
        public string assinaturaPresencial { get; set; } = "N";
        public string? nomeSignPresencial { get; set; }
        public string? cpfSignPresencial { get; set; }
        public int? codigoExigido { get; set; }
        public string incluirImagensAutentEnvelope { get; set; } = "N";
        public string analisarFaceImagem { get; set; } = "N"; 
        public int percentualPrecisaoFace { get; set; } = 0;
    }
}