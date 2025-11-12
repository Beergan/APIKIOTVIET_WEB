using Microsoft.IdentityModel.Tokens;
using System;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
public class JwtHandler
{
	public string GenJWT(string email, int Id, string username)
	{
		var secretKey = ConfigurationManager.AppSettings["JwtSecretKey"];
		var issuer = ConfigurationManager.AppSettings["JwtIssuer"];
		var audience = ConfigurationManager.AppSettings["JwtAudience"];
		var expireMinutes = int.Parse(ConfigurationManager.AppSettings["JwtExpireMinutes"]);

		var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
		var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

		var claims = new[]
		{
			new Claim(JwtRegisteredClaimNames.Sub, email),
			new Claim("uid", Id.ToString()),
			new Claim("displayName", username),
			new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
		};

		var token = new JwtSecurityToken(
			issuer: issuer,
			audience: audience,
			claims: claims,
			expires: DateTime.UtcNow.AddDays(30),
			signingCredentials: creds
		);

		return new JwtSecurityTokenHandler().WriteToken(token);
	}

	public ClaimsPrincipal ValidateJWT(string token)
	{
		var handler = new JwtSecurityTokenHandler();
		var validationParameters = new TokenValidationParameters
		{
			ValidateIssuer = true,
			ValidateAudience = true,
			ValidateLifetime = true,
			ValidateIssuerSigningKey = true,
			ValidIssuer = ConfigurationManager.AppSettings["JwtIssuer"],
			ValidAudience = ConfigurationManager.AppSettings["JwtAudience"],
			IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(ConfigurationManager.AppSettings["JwtSecretKey"]))
		};

		SecurityToken validatedToken;
		return handler.ValidateToken(token, validationParameters, out validatedToken);
	}
}
