using System;

class Calculadora
{
    static void Main()
    {
        double numero1, numero2, resultado;
        string operacao;

        Console.WriteLine("==== Calculadora Simples ====");

        // Entrada do primeiro número
        Console.Write("Digite o primeiro número: ");
        numero1 = Convert.ToDouble(Console.ReadLine());

        // Entrada da operação
        Console.Write("Digite a operação (+, -, *, /): ");
        operacao = Console.ReadLine();

        // Entrada do segundo número
        Console.Write("Digite o segundo número: ");
        numero2 = Convert.ToDouble(Console.ReadLine());

        // Verifica qual operação foi digitada
        switch (operacao)
        {
            case "+":
                resultado = numero1 + numero2;
                Console.WriteLine("Resultado: " + resultado);
                break;

            case "-":
                resultado = numero1 - numero2;
                Console.WriteLine("Resultado: " + resultado);
                break;

            case "*":
                resultado = numero1 * numero2;
                Console.WriteLine("Resultado: " + resultado);
                break;

            case "/":
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                    Console.WriteLine("Resultado: " + resultado);
                }
                else
                {
                    Console.WriteLine("Erro: divisão por zero não é permitida.");
                }
                break;

            default:
                Console.WriteLine("Operação inválida.");
                break;
        }

        Console.WriteLine("=============================");
    }
}
