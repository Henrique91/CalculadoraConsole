using System.Text.RegularExpressions;
using ProjetoCalculadora.Classes;



// Projeto calculadora
Console.Clear();
Console.WriteLine(@"Olá, seja bem vindo!");

Console.WriteLine($"");
Utils.BarraDeCarregamento($"Inicializando", 600, 6);
Console.WriteLine($"");
Console.WriteLine($"BORA CALCULAR!");

Console.WriteLine($"");


float valor1 = 0;
float valor2 = 0;
int opcao = 0;
float resultado = 0;

Console.WriteLine($"Qual operação deseja fazer?");
do
{
    Console.WriteLine(@$"
=========================================
|       Escolha uma das opções abaixo   |
|----------------------------------------
|   Digite 1 para : SOMAR               |
|   Digite 2 para : SUBTRAIR            |
|   Digite 3 para : MULTIPLICAR         |
|   Digite 4 para : DIVIDIR             |
|                                       | 
|   Digite 0 para : SAIR                |
=========================================

");

    opcao = int.Parse(Console.ReadLine()!);

    if (opcao >= 1 && opcao <= 4)
    {
        Console.WriteLine($"Digite um valor:");
        valor1 = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Digite o outro valor:");
        valor2 = int.Parse(Console.ReadLine()!);
    }
    else if (opcao >= 5)
    {
        Console.WriteLine($"Opção Inválida, digite um número de 1 à 4");
    }
    else
    {
        Console.WriteLine($"Sair");

    }



    if (opcao == 1)
    {
        resultado = valor1 + valor2;
        Console.WriteLine($"Resultado:{valor1} + {valor2} = {resultado}");

    }
    else if (opcao == 2)
    {
        resultado = valor1 - valor2;
        Console.WriteLine($"Resultado:{valor1} - {valor2} = {resultado}");
    }
    else if (opcao == 3)
    {
        resultado = valor1 * valor2;
        Console.WriteLine($"Resultado:{valor1} x {valor2} = {resultado}");
    }
    else if (opcao == 4)
    {
        resultado = valor1 / valor2;
        Console.WriteLine($"Resultado:{valor1} / {valor2} = {resultado}");
    }

} while (opcao != 0);

Console.Clear();
Utils.BarraDeCarregamento("Finalizando", 500, 6);
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine($"FINALIZADO");
Console.ResetColor();