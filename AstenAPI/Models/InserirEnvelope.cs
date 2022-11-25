namespace AstenAssinaturaAPI.Models
{
    public class InserirEnvelope
    {
        public String token { get; set; } = "GYtZ6+1SZRx5QypP2huHk2OOJfr1FyeQ79p1tt3JCiIoH93GbnkwxF6S60yFQoZwYCzUwZVb-Lk9KvOx1EDnve3c9kCXhw84MFRT-Zj7IojmKvbK7pyRIsKdVqJAEyE5Lr4sMM5c0mzbUt0ZrLpsF1vZ9rPNAn-5-4rlgk2N-8RZjs8R5BbKuU";
        public Params Params { get; set; } = new Params();
        public string gerarTags { get; set; } = "S";
        public string encaminharImediatamente { get; set; } = "N";
        public string detectarCampos { get; set; } = "N";

    }
}
