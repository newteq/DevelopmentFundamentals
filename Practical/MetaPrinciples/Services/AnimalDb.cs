﻿using MetaPrinciples.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaPrinciples.Services
{
    public class AnimalDb
    {
        public bool IsConnected { get; private set; }

        private List<Animal> animals;

        public AnimalDb()
        {

        }

        public IList<Animal> Animals()
        {
            // load default animals
            return Database.Data.Animals;
        }

        // principle of least astonishment
        public IEnumerable<Animal> ReportOfDogs()
        {
            if (!IsConnected)
            {
                IsConnected = true; // simulate opening database connection
            }

            if (animals == null)
            {
                animals = Animals().ToList();
            }

            return animals.Where(x => x.Type == AnimalType.Dog);
        }

        public IEnumerable<Animal> ReportOfCats()
        {
            if (!IsConnected)
            {
                throw new InvalidOperationException("Connection to the database is not opened yet");
            }

            return animals.Where(x => x.Type == AnimalType.Cat);
        }
    }
}
