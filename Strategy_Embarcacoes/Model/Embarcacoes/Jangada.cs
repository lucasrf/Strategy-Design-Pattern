using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Embarcacoes.Model.Embarcacoes
{
    class Jangada : Embarcacao
    {
        public Jangada()
        {
            propulsao = new Remo();
        }
    }
}
