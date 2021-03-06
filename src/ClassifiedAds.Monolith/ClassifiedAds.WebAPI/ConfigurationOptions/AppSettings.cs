﻿using ClassifiedAds.Infrastructure.Logging;
using System.Collections.Generic;

namespace ClassifiedAds.WebAPI.ConfigurationOptions
{
    public class AppSettings
    {
        public ConnectionStrings ConnectionStrings { get; set; }

        public LoggerOptions LoggerOptions { get; set; }

        public IdentityServerAuthentication IdentityServerAuthentication { get; set; }

        public string AllowedHosts { get; set; }

        public CORS CORS { get; set; }

        public Dictionary<string, string> SecurityHeaders { get; set; }
    }
}
