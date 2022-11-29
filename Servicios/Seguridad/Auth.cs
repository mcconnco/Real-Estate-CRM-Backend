using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CRMApi.Servicios.Seguridad
{
    public class Auth : IJwtAuth
    {
        private readonly string key;
        public Auth(string key)
        {
            this.key = key;
        }

        /// <summary>
        /// Genera el Token de autenticación
        /// </summary>
        /// <param name="username">Nombre de Uusario</param>
        /// <param name="idUser">Id del usuario que se autentica</param>
        /// <param name="idRol">Rol del usuario que se autentica</param>
        /// <returns>Token de autentiación</returns>
        public string Authentication(string username, int idUser, int idRol)
        {
            // 1. Create Security Token Handler
            var tokenHandler = new JwtSecurityTokenHandler();

            // 2. Create Private Key to Encrypted
            var tokenKey = Encoding.ASCII.GetBytes(key);

            //3. Create JETdescriptor
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim("Name", username),
                        new Claim("idUser", idUser.ToString()),
                        new Claim("idRol", idRol.ToString()),
                    }),
                Expires = DateTime.UtcNow.AddHours(12),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };

            //4. Create Token
            var token = tokenHandler.CreateToken(tokenDescriptor);

            // 5. Return Token from method
            return tokenHandler.WriteToken(token);
        }
    }
}
