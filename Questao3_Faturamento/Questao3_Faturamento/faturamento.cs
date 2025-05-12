using Questao3_Faturamento.Entidades;
using System.Text.Json;

try
{
    var json = File.ReadAllText("/Curso/DesafioCSharp/Questao3_Faturamento/Questao3_Faturamento/faturamento.json");
    var dados = JsonSerializer.Deserialize<List<DiaFaturamento>>(json);

    if (dados == null || !dados.Any())
    {
        Console.WriteLine("O arquivo JSON está vazio ou não pôde ser desserializado.");
        return;
    }

    var valoresValidos = dados.Where(d => d.Valor > 0).Select(d => d.Valor).ToList();

    if (valoresValidos.Any())
    {
        double menor = valoresValidos.Min();
        double maior = dados.Max(d => d.Valor); 
        double media = valoresValidos.Average();
        int diasAcimaDaMedia = dados.Count(d => d.Valor > media); 

        Console.WriteLine($"Menor valor: {menor:C2}");
        Console.WriteLine($"Maior valor: {maior:C2}");
        Console.WriteLine($"Média dos dias com faturamento: {media:C2}");
        Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
    else
    {
        Console.WriteLine("Não houve dias com faturamento maior que zero no período.");
    }
}
catch (FileNotFoundException)
{
    Console.WriteLine("Arquivo faturamento.json não encontrado.");
}
catch (JsonException ex)
{
    Console.WriteLine($"Erro ao desserializar o JSON: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
}