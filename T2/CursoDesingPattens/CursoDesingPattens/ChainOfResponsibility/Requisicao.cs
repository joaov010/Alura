﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPattens.ChainOfResponsibility
{
    class Requisicao
    {
        public Formato Formato { get; private set; }
        public Requisicao(Formato formato)
        {
            this.Formato = Formato;
        }
    }
}
