﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Atheletes.Atheletes
{
    public class Swimmer : Athelete
    {
        public override void HighJump()
        {
            throw new NotImplementedException();
        }

        public override void LongJump()
        {
            throw new NotImplementedException();
        }

        public override void RunHurdles()
        {
            throw new NotImplementedException();
        }

        public override void RunRelay()
        {
            throw new NotImplementedException();
        }

        public override void RunSprints(SprintDistance distance)
        {
            throw new NotImplementedException();
        }

        public override void Swim(SwimDistance distance)
        {
            Console.WriteLine($"{AtheleteInformation} - swimming as fast as I can for {(int) distance}");
        }

        public override void ThrowJavelin()
        {
            throw new NotImplementedException();
        }

        public override void ThrowShotput()
        {
            throw new NotImplementedException();
        }

        public override void TripleJump()
        {
            throw new NotImplementedException();
        }
    }
}