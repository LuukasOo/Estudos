Console.WriteLine("\n### Nullable Types ###");

Nullable<int> inteiroAnulavel = null;
Nullable<bool> booleanAnulavel = null;
Nullable<double> doubleAnulavel = null;

//Simplificado
int? intAnulavelSimplificado = null;

Console.WriteLine(inteiroAnulavel);
Console.WriteLine(booleanAnulavel);
Console.WriteLine(booleanAnulavel);
Console.WriteLine(intAnulavelSimplificado);

int? a = null;
int b = a ?? 0; //se a for nula b receberá 0, senão receberá o valor preenchido em a

Console.WriteLine("\n### Propriedades somente leitura HasValue e Value ###");
int? x = null;
if (x.HasValue)
{
    Console.WriteLine($"o valor de x é: {x}");
}
else
{
    Console.WriteLine($"x não possui valor.");
}