﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaCamp_HomeTask14.SerializationService
{
    internal class XMLSerializerCreator:SerializerCreator
    {
        public override CustomSerializer CreateSerializer(string FilePath)
        {
            return new CustomXMLSerializer(FilePath);
        }
    }
}
