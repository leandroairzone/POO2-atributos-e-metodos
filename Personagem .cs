using System;

namespace Aula_2
{
    public class Personagem 
    {
        public string nome  ;

        public int idade = 40;
        public string armadura;

        public string Atacar(){

              return "Ataque de fogo!";
        }

        internal object Defender()
        {
            throw new NotImplementedException();
        }

        internal object Pulo()
        {
            throw new NotImplementedException();
        }
    }
}