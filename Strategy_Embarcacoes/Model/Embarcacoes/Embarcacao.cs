using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Embarcacoes.Model
{
    public abstract class Embarcacao
    {
        public IPropulsaoBehavior propulsao;

        public double GetVelocidadeMedia() => propulsao.GetVelocidadeMedia();
        public string GetDescricao() => propulsao.GetDescricao();
    }
}
