
using calculadora;

string? entrada;
int operacao = -1;
int valor1 = 0;
int valor2 = 0;
Calculadora calculadora = new Calculadora();
do {

    Console.WriteLine(".:CALCULADORA:.");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Historico");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("Informe uma opção: ");
    entrada = Console.ReadLine();
    if(!int.TryParse(entrada, out operacao)) {
        operacao = -1;
        Console.WriteLine("Entrada inválida!");
    }

    // fecha a calculadora imediatamente
    if(operacao == 0) {
        break;
    }

    // lê valores para as operações de calculo
    if(operacao >= 1 && operacao < 5) {
        Console.WriteLine("Valor 1: ");
        entrada = Console.ReadLine();
        if(!int.TryParse(entrada, out valor1)) {
            Console.WriteLine("Entrada inválida!");
            continue;
        }

        Console.WriteLine("Valor 2: ");
        entrada = Console.ReadLine();
        if(!int.TryParse(entrada, out valor2)) {
            Console.WriteLine("Entrada inválida!");
            continue;
        }
    }
    

    if(operacao == 1) {
        int resultado = calculadora.somar(valor1, valor2);
        Console.WriteLine(String.Format("Resultado: {0}", resultado));
    } else if (operacao == 2) {
        int resultado = calculadora.subtrair(valor1, valor2);
        Console.WriteLine(String.Format("Resultado: {0}", resultado));
    } else if (operacao == 3) {
        int resultado = calculadora.multiplicar(valor1, valor2);
        Console.WriteLine(String.Format("Resultado: {0}", resultado));
    } else if (operacao == 4) {
        if(valor2 == 0) {
            Console.WriteLine("Não é possivel realizar divisão por zero!");
            continue;
        }
        int resultado = calculadora.dividir(valor1, valor2);
        Console.WriteLine(String.Format("Resultado: {0}", resultado));
    } else if (operacao == 5) {
        var resultado = calculadora.historico();
        Console.WriteLine(".:Historico das operações:.");
        foreach (string item in resultado)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("---------------------------");
    } else {
        Console.WriteLine("Não existe operação para o valor fornecido!");
    }

    Console.WriteLine("\n\n");

}while(operacao != 0);

Console.WriteLine("Calculadora Encerrada!");