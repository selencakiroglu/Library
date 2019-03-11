﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Services
{
    public class PropertyMappingValue
    {
        public IEnumerable<string> DestinationPropeties { get; private set; }
        public bool Revert { get; private set; }

        public PropertyMappingValue(IEnumerable<string> destinationProperties,
            bool revert = false)
        {
            DestinationPropeties = destinationProperties;
            Revert = revert;
        }
    }
}
