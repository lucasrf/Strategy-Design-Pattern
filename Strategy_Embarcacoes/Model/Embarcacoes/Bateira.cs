using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Embarcacoes.Model
{
    class Bateira : Embarcacao
    {
        public Bateira()
        {
            propulsao = new Motor(89);
        }
    }
}
