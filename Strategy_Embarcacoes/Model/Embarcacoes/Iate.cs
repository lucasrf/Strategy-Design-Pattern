using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Embarcacoes.Model.Embarcacoes
{
    class Iate : Embarcacao
    {
        public Iate()
        {
            propulsao = new Motor(241);
        }
    }
}
