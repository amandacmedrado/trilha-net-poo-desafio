using System;
using System.Diagnostics;

namespace DesafioPOO.Models
{
    // Herda da classe Smartphone
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class Nokia : Smartphone
    {
        // TODO: Adicione quaisquer propriedades específicas do Nokia, se necessário

        // Construtor para a classe Nokia
        public Nokia(string numero, string marca, string modelo, double tamanhoTela)
            : base(numero, marca, modelo, tamanhoTela)
        {
            // TODO: Inicialize quaisquer propriedades específicas do Nokia, se necessário
        }

        // Sobrescreve o método InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na plataforma Nokia.");
            // TODO: Adicione lógica específica para instalar um aplicativo em um Nokia
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
