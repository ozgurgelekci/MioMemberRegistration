﻿using System;
using System.Text;
using System.Web;
using System.Web.Security;

namespace MioBlog.Core.CrossCuttingConcerns.Security.Web
{
    public class AuthenticationHelper
    {
        public static void CreateAuthCookie(Guid id, string userName, string email, DateTime expiration, string[] roles, bool rememberMe, string firstName, string lastName)
        {
            var authTicket = new FormsAuthenticationTicket(1, userName, DateTime.Now, expiration, rememberMe,
                CreateAutgTags(email, roles, firstName, lastName, id)
            );

            string encTicket = FormsAuthentication.Encrypt(authTicket);
            HttpContext.Current.Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));
        }

        private static string CreateAutgTags(string email, string[] roles, string firstName, string lastName, Guid id)
        {
            var stringBuilder = new StringBuilder();
            
            stringBuilder.Append(email);
            stringBuilder.Append("|");

            for (int i = 0; i < roles.Length; i++)
            {
                stringBuilder.Append(roles[i]);

                if (i < roles.Length - 1)
                {
                    stringBuilder.Append(",");
                }
            }
            stringBuilder.Append("|");

            stringBuilder.Append(firstName);
            stringBuilder.Append("|");

            stringBuilder.Append(lastName);
            stringBuilder.Append("|");

            stringBuilder.Append(id);

            return stringBuilder.ToString();
        }
    }
}
