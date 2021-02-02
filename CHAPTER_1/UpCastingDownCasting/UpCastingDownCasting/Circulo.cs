using System;

namespace UpCastingDownCasting
{
    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhar Circulo");
        }
        public void PintarCirculo()
        {
            Console.WriteLine("Pintando o Circulo");
        }
    }
}
