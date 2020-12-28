using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Embarcacoes.Model
{
    class Motor : IPropulsaoBehavior
    {
        int potencia;

        public Motor(int _potencia)
        {
            potencia = _potencia;
        }

        public double GetVelocidadeMedia() => 30;
        public string GetDescricao() => "Motor";
    }
}
