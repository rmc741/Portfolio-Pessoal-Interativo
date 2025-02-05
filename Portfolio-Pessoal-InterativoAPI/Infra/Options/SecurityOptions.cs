using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Options
{
    public class SecurityOptions
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public string SecretKey { get; set; }
    }
}
