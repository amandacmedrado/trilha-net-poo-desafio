using System;

namespace DesafioPOO.Models
{
    // Herda da classe Smartphone
    public class Iphone : Smartphone
    {
        // TODO: Adicione quaisquer propriedades específicas do iPhone, se necessário

        // Construtor para a classe Iphone
        public Iphone(string numero, string marca, string modelo, double tamanhoTela)
            : base(numero, marca, modelo, tamanhoTela)
        {
            // TODO: Inicialize quaisquer propriedades específicas do iPhone, se necessário
        }

        // Sobrescreve o método InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na plataforma iOS.");
            // TODO: Adicione lógica específica para instalar um aplicativo em um iPhone
        }
    }
}
