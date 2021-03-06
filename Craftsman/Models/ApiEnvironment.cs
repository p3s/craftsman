﻿namespace Craftsman.Models
{
    using System;
    using System.Collections.Generic;

    public class ApiEnvironment
    {
        private string _environmentName;

        public string EnvironmentName {
            get => _environmentName;
            set
            {
                if (value.Equals("Startup", StringComparison.InvariantCultureIgnoreCase))
                    _environmentName = "Startup";
                else
                    _environmentName = value;
            }
        }
        public string ConnectionString { get; set; }
        public string ProfileName { get; set; }
        public JwtSettings JwtSettings { get; set; } = new JwtSettings();
        public MailSettings MailSettings { get; set; } = new MailSettings();
    }
}
