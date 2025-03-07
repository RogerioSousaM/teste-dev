using System;

class Program
{
    // Teste 1 
    static void Teste1()
    {
        int INDICE = 13;
        int SOMA = 0;
        int k = 0;

        while (k < INDICE)
        {
            k = k + 1;
            SOMA = SOMA + k;
        }

        Console.WriteLine("Teste 1 - Soma: " + SOMA);
    }

    // Teste 2 
    static void Teste2()
    {
        Console.WriteLine("Digite um número para verificar se está na sequência de Fibonacci:");
        string entrada = Console.ReadLine() ?? string.Empty;

        if (int.TryParse(entrada, out int numero))
        {
            int a = 0, b = 1, temp;

            while (a < numero)
            {
                temp = a + b;
                a = b;
                b = temp;
            }

            if (a == numero)
            {
                Console.WriteLine("O número está na sequência de Fibonacci!");
            }
            else
            {
                Console.WriteLine("O número NÃO está na sequência de Fibonacci.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida! Digite um número inteiro.");
        }
    }

    // Teste 3 
    static void Teste3()
    {
        
        double[] faturamento = { 67836.43, 36678.66, 29229.88, 27165.48, 19849.53 };

        double menorFaturamento = double.MaxValue;
        double maiorFaturamento = double.MinValue;
        double totalFaturamento = 0;
        int diasComFaturamento = 0;

        foreach (var valor in faturamento)
        {
            if (valor > 0)
            {
                totalFaturamento += valor;
                diasComFaturamento++;

                if (valor < menorFaturamento)
                    menorFaturamento = valor;

                if (valor > maiorFaturamento)
                    maiorFaturamento = valor;
            }
        }

        double mediaFaturamento = totalFaturamento / diasComFaturamento;

        int diasAcimaDaMedia = 0;
        foreach (var valor in faturamento)
        {
            if (valor > mediaFaturamento)
                diasAcimaDaMedia++;
        }

        Console.WriteLine("Teste 3 - Faturamento:");
        Console.WriteLine($"Menor Faturamento: {menorFaturamento:F2}");
        Console.WriteLine($"Maior Faturamento: {maiorFaturamento:F2}");
        Console.WriteLine($"Dias com Faturamento Acima da Média: {diasAcimaDaMedia}");
    }

    // Teste 4
    static void Teste4()
    {
        double sp = 67836.43;
        double rj = 36678.66;
        double mg = 29229.88;
        double es = 27165.48;
        double outros = 19849.53;

        double totalFaturamento = sp + rj + mg + es + outros;

        double percentualSP = (sp * 100) / totalFaturamento;
        double percentualRJ = (rj * 100) / totalFaturamento;
        double percentualMG = (mg * 100) / totalFaturamento;
        double percentualES = (es * 100) / totalFaturamento;
        double percentualOutros = (outros * 100) / totalFaturamento;

        Console.WriteLine("Teste 4 - Percentual de Faturamento:");
        Console.WriteLine("SP: " + percentualSP + "%");
        Console.WriteLine("RJ: " + percentualRJ + "%");
        Console.WriteLine("MG: " + percentualMG + "%");
        Console.WriteLine("ES: " + percentualES + "%");
        Console.WriteLine("Outros: " + percentualOutros + "%");
    }

    // Teste 5 
    static void Teste5()
    {
        Console.Write("Digite uma string: ");
        string input = Console.ReadLine();

        if (input == null)
        {
            input = "";
        }

        string invertida = "";

      
        for (int i = input.Length - 1; i >= 0; i--)
        {
            invertida += input[i];
        }

       
        Console.WriteLine("String invertida: " + invertida);
    }

    
    static void Main(string[] args)
    {
        Teste1();
        Teste2();
        Teste3();
        Teste4();
        Teste5();
    }
}