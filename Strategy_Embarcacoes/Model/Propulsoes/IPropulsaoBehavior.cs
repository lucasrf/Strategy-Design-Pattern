using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Embarcacoes.Model
{
    public interface IPropulsaoBehavior
    {
        /// <summary>
        /// Velocidade Média em nós
        /// </summary>
        /// <returns></returns>
        public double GetVelocidadeMedia();
        public string GetDescricao();
    }
}
