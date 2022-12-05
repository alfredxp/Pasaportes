namespace PasaportesApiSol.Models
{
    public class UsuarioDto
    {
        public string? UsuarioLogin { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
    }
}
