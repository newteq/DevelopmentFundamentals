﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Atheletes.Atheletes
{
    public class ShotputThrower : Athelete
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
            throw new NotImplementedException();
        }

        public override void ThrowJavelin()
        {
            throw new NotImplementedException();
        }

        public override void ThrowShotput()
        {
            Console.WriteLine($"{AtheleteInformation} - throwing the shotput (this thing is heavy!)");
        }

        public override void TripleJump()
        {
            throw new NotImplementedException();
        }
    }
}