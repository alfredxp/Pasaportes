using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PasaportesApiSol.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace PasaportesApiSol.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        public UsuarioDto user = new UsuarioDto();

        private readonly PasaportesDbContext _context;
        private readonly IConfiguration _config;
        public UsuarioController(IConfiguration configuration, PasaportesDbContext context)
        {
            _config = configuration;
            _context = context;
        }

        //[HttpPost]
        //public async Task<ActionResult<Usuario>> Registrar(Usuario request, Usuario usuarios)
        //{

        //    CreatePasswordHash(request.UsuarioPassword, out byte[] passwordHash, out byte[] passwordSalt);
        //    usuarios.UsuarioLogin = request.UsuarioLogin;
        //    usuarios.UsuarioHash = passwordHash.ToString();
        //    usuarios.UsuarioSalt = passwordSalt.ToString();

        //    _context.Usuarios.Add(usuarios);
        //    await _context.SaveChangesAsync();

        //    return Ok(usuarios);
        //}


        [HttpPost("Registrar")]
        public async Task<ActionResult<Usuario>> Registrar(Usuario request)
        {

            CreatePasswordHash(request.UsuarioPassword, out byte[] passwordHash, out byte[] passwordSalt);
            //user.PasswordHash = passwordHash;
            //user.PasswordSalt = passwordSalt;
            //request.UsuarioHash = user.PasswordHash.ToString();
            //request.UsuarioSalt = user.PasswordSalt.ToString();

            //_context.Usuarios.Add(request);
            //await _context.SaveChangesAsync();

            return Ok();
        }


        //[HttpPost]
        //public async Task<ActionResult<string>> Login(Usuario request, Usuario usuarios)
        //{
        //    if (usuarios.UsuarioLogin != request.UsuarioLogin)
        //    {
        //        return BadRequest("User not found.");

        //    }

        //    if (!VerifyPasswordHash(request.UsuarioPassword, byteToString(usuarios.UsuarioHash), byteToString(usuarios.UsuarioSalt)))
        //    {
        //        return BadRequest("Contraseña incorrecta");
        //    }

        //    string token = CreateToken(usuarios);

        //    return Ok(token);
        //}

        #region TOKEN, CREATE AND VERIFY PASSWORD
        private string CreateToken(Usuario usuarios)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, usuarios.UsuarioLogin)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));

            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: cred
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;

        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }

        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }

        }

        private static byte[] stringToByte(string bytes)
        {
            byte[] bytereceived = Encoding.UTF8.GetBytes(bytes);
            return bytereceived;
        }

        private static string byteToString(byte[] stringy)
        {
            string stringreceived = Encoding.UTF8.GetString(stringy);
            return stringreceived;
        }

        
        #endregion

    }
}
