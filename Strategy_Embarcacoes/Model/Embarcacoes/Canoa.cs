using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Embarcacoes.Model.Embarcacoes
{
    class Canoa : Embarcacao
    {
        public Canoa()
        {
            propulsao = new Remo();
        }
    }
}
