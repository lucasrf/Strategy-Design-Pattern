using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Embarcacoes.Model
{
    class Remo : IPropulsaoBehavior
    {
        public double GetVelocidadeMedia() => 2.4;
        public string GetDescricao() => "Remo";
    }
}
