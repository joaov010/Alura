﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Cap_3
{
    class Frete : IServicoDeEntrega
    {
        public double Para(string cidade)
        {

            if ("SAO PAULO".Equals(cidade.ToUpper()))
            {
                return 15;
            }
            return 30;
        }
    }
}