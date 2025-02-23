Console.WriteLine("\n### Operador Ternario ###");

Console.Write("Informe a temperatura: ");
double temperatura = Convert.ToDouble(Console.ReadLine());

string resultado = temperatura > 27 ? "Quente" : "Frio";
Console.WriteLine($"o tempo esta: {resultado}");