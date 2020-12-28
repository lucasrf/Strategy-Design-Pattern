
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Embarcacoes.Model
{
    class Vela : IPropulsaoBehavior
    {
        public double GetVelocidadeMedia() => 6;
        public string GetDescricao() => "Vela";
    }
}
