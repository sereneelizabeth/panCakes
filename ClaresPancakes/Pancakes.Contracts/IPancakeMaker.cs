﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pancakes.Contracts
{
    public interface IPancakeMaker
    {
        List<Pancake> GiveMePancakes(int numPancakes);
    }
}