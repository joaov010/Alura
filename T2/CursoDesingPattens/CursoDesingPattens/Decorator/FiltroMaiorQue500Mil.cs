﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPattens.Decorator
{
    public class FiltroMaiorQue500Mil : Filtro
    {
        public FiltroMaiorQue500Mil(Filtro outroFiltro) : base(outroFiltro) { }
        public FiltroMaiorQue500Mil() : base() { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtrada = new List<Conta>();
            foreach (Conta c in contas)
            {
                if (c.Saldo > 500000) filtrada.Add(c);
            }
            foreach (Conta c in Proximo(contas))
            {
                filtrada.Add(c);
            }
            return filtrada;
        }
    }
}