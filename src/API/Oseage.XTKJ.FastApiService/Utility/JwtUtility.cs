﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Oseage.XTKJ.FastApiService.Utility
{
    /// <summary>
    /// JSON Web Token
    /// </summary>
    public class JwtUtility
    {
        private string mIssuer = null;

        private string mAudience = null;

        private SecurityKey mSecurityKey;

        private SigningCredentials mSigningCredentials;

        private TokenValidationParameters mTokenValidation = new TokenValidationParameters();

        private JwtSecurityTokenHandler mJwtSecurityTokenHandler = new JwtSecurityTokenHandler();

        public JwtUtility() : this(null, null)
        {
        }

        public JwtUtility(string issuer, string audience, string key = "2qyg4coej88uqrono0xdmx4y0il5dn5y7b72tlb3imba677ht1p1xlfcnh36mk5u3xzjktfara29axvzk85apfplun7oslbe1m20c148p5d519kja5wvg7lmn5v4a5ou")
        {
            mIssuer = issuer;
            mAudience = audience;
            mSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            if (string.IsNullOrEmpty(mIssuer))
            {
                mTokenValidation.ValidateIssuer = false;
            }
            else
            {
                mTokenValidation.ValidIssuer = mIssuer;
            }
            if (string.IsNullOrEmpty(mAudience))
            {
                mTokenValidation.ValidateAudience = false;
            }
            else
            {
                mTokenValidation.ValidAudience = mAudience;
            }
            mTokenValidation.IssuerSigningKey = mSecurityKey;
            mSigningCredentials = new SigningCredentials(mSecurityKey, SecurityAlgorithms.HmacSha256);
            Expires = 60 * 24;
        }

        public int Expires { get; set; }

        public string CreateToken(string name, string role)
        {
            ClaimsIdentity claimsIdentity = new ClaimsIdentity();
            claimsIdentity.AddClaim(new Claim("Name", name));
            claimsIdentity.AddClaim(new Claim("Role", role));
            var item = mJwtSecurityTokenHandler
                .CreateEncodedJwt(
                mIssuer,
                mAudience,
                claimsIdentity,
                DateTime.Now.AddMinutes(-5),
                DateTime.Now.AddMinutes(100),
                DateTime.Now,
                mSigningCredentials);
            return item;
        }

        public ClaimsPrincipal ValidateToken(string token)
        {
            return mJwtSecurityTokenHandler.ValidateToken(token, mTokenValidation, out var securityToken);
        }

        public UserInfo? GetUserInfo(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
                return null;

            UserInfo user = new UserInfo();
            //var info = ValidateToken(token);
            //ClaimsIdentity identity = info?.Identity as ClaimsIdentity;
            //user.Name = identity?.Claims?.FirstOrDefault(c => c.Type == "Name")?.Value;
            //user.Role = identity?.Claims?.FirstOrDefault(c => c.Type == "Role")?.Value;
            return user;
        }

        public struct UserInfo
        {
            public string Name;

            public string Role;
        }
    }
}
