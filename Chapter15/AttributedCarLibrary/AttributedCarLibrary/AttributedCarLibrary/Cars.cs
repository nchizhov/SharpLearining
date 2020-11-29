﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: CLSCompliant(true)]

namespace AttributedCarLibrary
{
    [Serializable]
    [VehicleDescription(Description = "Me rocking Harley")]
    public class Motocycle
    {
    }

    [Serializable]
    [VehicleDescription("The old gray mare, she ain't what she used to be...")]
    public class HorseAndBuggy
    {
    }

    [VehicleDescription("A very long, slow, but feature-rich auto")]
    public class Winnebago
    {
        public void PlayMusic(bool On) { }
    }
}
