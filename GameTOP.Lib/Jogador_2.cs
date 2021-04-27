using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador_2 : IJogador
    {
        public string Chuta()
        {
            return "Maradona estas pateando";
        }

        public string Corre()
        {
            return "Maradona estas coriendo";
        }

        public string Passe()
        {
            return "Maradona estas pasando";
        }
    }
}