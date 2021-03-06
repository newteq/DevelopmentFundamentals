﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.House
{
    public class ElectricityService
    {
        private readonly ILogger logger;

        public ElectricityService(ILogger logger)
        {
            this.logger = logger;
        }

        public void Use()
        {
            this.logger.LogInformation("Using electricty from the main lines");
        }
    }
}
