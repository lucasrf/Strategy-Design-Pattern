using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Embarcacoes.Model.Embarcacoes
{
    class BarcoVela : Embarcacao
    {
        public BarcoVela()
        {
            propulsao = new Vela();
        }
    }
}
