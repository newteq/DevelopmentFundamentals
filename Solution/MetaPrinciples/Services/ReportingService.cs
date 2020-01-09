﻿using MetaPrinciples.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaPrinciples.Services
{
    public class ReportingService : IReportingService
    {
        private Dictionary<AnimalType, IList<Animal>> animals;

        public ReportingService()
        {

        }

        public string AnimalCount(AnimalType animalType)
        {
            if (animals == null)
            {
                // connect to db and fetch the records
                animals = Database.Data.AnimalDictionary();
            }

            return $"There are a total of: {animals[animalType].Count()} {animalType.ToString()}";
        }
    }
}
