using Strategy_Embarcacoes.Model;
using Strategy_Embarcacoes.Model.Embarcacoes;
using System;

namespace Strategy_Embarcacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Embarcacao e1 = new BarcoVela();
            Embarcacao e2 = new Bateira();
            Embarcacao e3 = new Canoa();
            Embarcacao e4 = new Iate();
            Embarcacao e5 = new Jangada();

            Console.WriteLine("Tabela de embarcações:\n");
            Console.WriteLine("Barco a Vela - Propulsão: " + e1.GetDescricao() + " / Vel.Média:" + e1.GetVelocidadeMedia());
            Console.WriteLine("Bateira - Propulsão: " + e2.GetDescricao() + " / Vel.Média:" + e2.GetVelocidadeMedia());
            Console.WriteLine("Canoa - Propulsão: " + e3.GetDescricao() + " / Vel.Média:" + e3.GetVelocidadeMedia());
            Console.WriteLine("Iate - Propulsão: " + e4.GetDescricao() + " / Vel.Média:" + e4.GetVelocidadeMedia());
            Console.WriteLine("Jangada - Propulsão: " + e5.GetDescricao() + " / Vel.Média:" + e5.GetVelocidadeMedia());

            Console.ReadKey();
        }
    }
}
