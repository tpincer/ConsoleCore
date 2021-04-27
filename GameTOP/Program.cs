using System;
using GameTOP.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(
                new Jogador_1(),
                new Jogador_2());
            jogo.IniciarJogo();
        }
    }

  

}