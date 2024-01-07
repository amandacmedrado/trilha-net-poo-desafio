using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            // Teste com a classe Nokia
            Nokia meuNokia = new Nokia("123456", "Nokia", "ModeloNokia", 5.0);
            meuNokia.Ligar();
            meuNokia.ReceberLigacao();
            meuNokia.InstalarAplicativo("WhatsApp");

            // Teste com a classe Iphone
            Iphone meuIphone = new Iphone("789012", "Apple", "ModeloiPhone", 6.0);
            meuIphone.Ligar();
            meuIphone.ReceberLigacao();
            meuIphone.InstalarAplicativo("Instagram");

            // Aguarde a entrada do usuário antes de fechar a aplicação
            Console.ReadLine();
        }
    }
}
