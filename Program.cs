using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


XDocument xml = XDocument.Load(@"C:\Users\doug\Documents\teste tecnico\dados.xml");


List<double> faturamentos = xml.Descendants("row")
    .Select(x => double.Parse(x.Element("valor")?.Value ?? "0"))
    .Where(v => v > 0)
    .ToList();

if (faturamentos.Count == 0)
{
    Console.WriteLine("Nenhum dia com faturamento registrado.");
    return;
}

// Calcula menor e maior faturamento
double menorFaturamento = faturamentos.Min();
double maiorFaturamento = faturamentos.Max();

// Calcula a média dos dias com faturamento
double media = faturamentos.Average();

// Conta quantos dias tiveram faturamento acima da média
int diasAcimaDaMedia = faturamentos.Count(v => v > media);

// Exibe os resultados
Console.WriteLine($"Menor faturamento: {menorFaturamento:F2}");
Console.WriteLine($"Maior faturamento: {maiorFaturamento:F2}");
Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");
