using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador_1 : IJogador
    {

        public readonly string _Nome;
        public Jogador_1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }

        public string Chuta()
        {
            return $"{_Nome} está chutando";
        }

        public string Corre()
        {
            return $"{_Nome} está correndo";
        }

        public string Passe()
        {
            return $"{_Nome} está passando";
        }
    }
}
