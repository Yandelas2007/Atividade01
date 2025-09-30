
using System;

class UrnaEletronica
{
    static void Main()
    {
        // Exibe data e hora atual
        Console.WriteLine("Data e hora atual: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

        // Mensagem inicial
        Console.WriteLine("===================================");
        Console.WriteLine("         Vote certo!");
        Console.WriteLine("===================================");

        // Inicializa contadores de votos
        int candidato1 = 0;
        int candidato2 = 0;
        int candidato3 = 0;
        int nulo = 0;
        int branco = 0;

        bool continuar = true;

        while (continuar)
        {
            // Exibe menu
            Console.WriteLine("\nEscolha seu voto:");
            Console.WriteLine("1 - Candidato 1");
            Console.WriteLine("2 - Candidato 2");
            Console.WriteLine("3 - Candidato 3");
            Console.WriteLine("4 - Voto Nulo");
            Console.WriteLine("5 - Voto em Branco");
            Console.WriteLine("0 - Encerrar votação");

            Console.Write("Digite sua opção: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    candidato1++;
                    Console.WriteLine("Voto registrado para Candidato 1.");
                    break;
                case "2":
                    candidato2++;
                    Console.WriteLine("Voto registrado para Candidato 2.");
                    break;
                case "3":
                    candidato3++;
                    Console.WriteLine("Voto registrado para Candidato 3.");
                    break;
                case "4":
                    nulo++;
                    Console.WriteLine("Voto nulo registrado.");
                    break;
                case "5":
                    branco++;
                    Console.WriteLine("Voto em branco registrado.");
                    break;
                case "0":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }

        // Exibe resultados finais
        Console.WriteLine("\n===== Resultado da Votação =====");
        Console.WriteLine("Candidato 1: " + candidato1 + " voto(s)");
        Console.WriteLine("Candidato 2: " + candidato2 + " voto(s)");
        Console.WriteLine("Candidato 3: " + candidato3 + " voto(s)");
        Console.WriteLine("Votos Nulos: " + nulo);
        Console.WriteLine("Votos em Branco: " + branco);
        Console.WriteLine("=================================");
    }
}





