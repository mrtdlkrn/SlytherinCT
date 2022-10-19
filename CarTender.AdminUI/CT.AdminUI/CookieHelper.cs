using Microsoft.AspNetCore.Http;
using System;

namespace CT.AdminUI
{
    public class CookieHelper
    {
        private readonly IHttpContextAccessor accessor;

        public CookieHelper(IHttpContextAccessor accessor)
        {
            this.accessor = accessor;
        }

        public string ReadCookie(string key)
        {
            return accessor.HttpContext.Request.Cookies[key];
        }

        public void SetCookie(string key, string value, int? expDays)
        {
            CookieOptions opt = new CookieOptions();

            if (expDays.HasValue)
            {
                // token day ile tutuluyrsa day, hour ise hour olmalı.
                // exp süresi, token exp süresi ile aynı olsa çok faydalı olur.
                opt.Expires = DateTime.Now.AddDays(expDays.Value);
            }
            else
            {
                opt.Expires = DateTime.Now.AddDays(1);
            }

            accessor.HttpContext.Response.Cookies.Append(key, value, opt);
        }
    }
}
