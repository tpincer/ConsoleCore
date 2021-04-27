using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly IJogador _jogador_A;
        private readonly IJogador _jogador_B;

        public JogoFODA(IJogador jogador_A, IJogador jogador_B)
        {
            _jogador_A = jogador_A;
            _jogador_B = jogador_B;
        }
public void IniciarJogo()
{
   System.Console.WriteLine(_jogador_A.Corre());
   System.Console.WriteLine(_jogador_A.Chuta());
   System.Console.WriteLine(_jogador_A.Passe());

System.Console.WriteLine("\n PRÓXIMO JOGADOR: \n");

   System.Console.WriteLine(_jogador_B.Corre());
   System.Console.WriteLine(_jogador_B.Chuta());
   System.Console.WriteLine(_jogador_B.Passe());
}
    }
}