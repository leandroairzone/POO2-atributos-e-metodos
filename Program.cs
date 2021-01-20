using System;

namespace Aula_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem objetoPersonagem1 = new Personagem();

            objetoPersonagem1.nome = "Leandro";
            objetoPersonagem1.idade = 44;
            objetoPersonagem1.armadura = "Voadora";

            Personagem objetoPersonagem2 = new Personagem();

            objetoPersonagem2.nome = "joyce";
            objetoPersonagem2.idade = 18;
            objetoPersonagem2.armadura = "Flesh";





            Console.WriteLine($"Personagem 1  = {objetoPersonagem1.nome} - {objetoPersonagem1.Atacar()}");
            Console.WriteLine($"Personagem 2  = {objetoPersonagem2.nome} - {objetoPersonagem2.Defender(0)}");

       
   //Console.WriteLine($"Personagem 2  = {objetoPersonagem2.nome} - {objetoPersonagem2.Defender(0)}");
      // obs ..essa segunda linha esta com erro na palavra (DEENDER)..EU tinha dado contro ponto nela e deu pior
      

       


        


        

       
        }

    }
}
  