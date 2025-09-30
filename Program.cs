using System;

class UrnaEletronica
{
    static void Main()
    {
        // Exibir data e hora atuais
        Console.WriteLine("Data e hora: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
        Console.WriteLine("Vote certo!");
        Console.WriteLine();

        // Variáveis de contagem de votos
        int votosMSDN = 0;
        int votosTechNet = 0;
        int votosTheSpoke = 0;
        int votosBranco = 0;
        int votosNulo = 0;
        int totalEleitores = 0;

        string continuar;

        do
        {
            // Menu de votação
            Console.WriteLine("Escolha seu voto digitando o número correspondente:");
            Console.WriteLine("1 - MSDN Brasil");
            Console.WriteLine("2 - TechNet Brasil");
            Console.WriteLine("3 - The Spoke .Net");
            Console.WriteLine("4 - Voto em branco");
            Console.WriteLine("5 - Voto nulo");
            Console.Write("Seu voto: ");

            string entrada = Console.ReadLine();
            int voto;

            // Tenta converter a entrada para número
            if (int.TryParse(entrada, out voto))
            {
                switch (voto)
                {
                    case 1:
                        votosMSDN++;
                        Console.WriteLine("Você votou: MSDN Brasil");
                        break;
                    case 2:
                        votosTechNet++;
                        Console.WriteLine("Você votou: TechNet Brasil");
                        break;
                    case 3:
                        votosTheSpoke++;
                        Console.WriteLine("Você votou: The Spoke .Net");
                        break;
                    case 4:
                        votosBranco++;
                        Console.WriteLine("Você votou em branco.");
                        break;
                    case 5:
                        votosNulo++;
                        Console.WriteLine("Você votou nulo.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Voto não contabilizado.");
                        break;
                }

                totalEleitores++;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número entre 1 e 5.");
            }

            // Pergunta se deseja continuar
            Console.Write("\nDeseja continuar votando? (sim/não): ");
            continuar = Console.ReadLine().Trim().ToLower();
            Console.WriteLine();

        } while (continuar == "sim" || continuar == "s");

        // Exibição dos resultados
        Console.WriteLine("\nRESULTADO FINAL DA VOTAÇÃO:");
        Console.WriteLine($"MSDN Brasil: {votosMSDN} votos");
        Console.WriteLine($"TechNet Brasil: {votosTechNet} votos");
        Console.WriteLine($"The Spoke .Net: {votosTheSpoke} votos");
        Console.WriteLine($"Votos em branco: {votosBranco}");
        Console.WriteLine($"Votos nulos: {votosNulo}");
        Console.WriteLine($"Total de eleitores: {totalEleitores}");
    }
}
