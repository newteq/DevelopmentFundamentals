﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.House
{
    public class SanitationService
    {
        private readonly ILogger logger;

        public SanitationService(ILogger logger)
        {
            this.logger = logger;
        }

        public void UseSanitation()
        {
            this.logger.LogInformation("There are people that do sanitation so, you don't have to. Imagine driving to the waste dumps every day to through out your trash.");
        }
    }
}
