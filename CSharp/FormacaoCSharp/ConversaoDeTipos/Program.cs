Console.WriteLine("\n### Conversao de Tipos ###");

//Conversão implicita, onde tipos de menor tamanho são aceitos em tipos de maior tamanho
int valorInt = 214578;
long valorLong = valorInt;
Console.WriteLine($"valorLong: {valorLong} convertido implicitamente.");

//Conversão Explicita
double valorDouble = 12.456;
//❌ int valorDoubleExplicita = valorDouble;
int valorIntExplicita = (int)valorDouble;
Console.WriteLine($"valor original: {valorDouble} <-----> valor convertido explicitamente: {valorIntExplicita}");



Console.WriteLine("\n###Usando ToString() ###");
double doubleString = 12.456;
int intString = 12;
float floatString = 12.456f;

string valor11 = doubleString.ToString();
string valor22 = intString.ToString();
string valor33 = floatString.ToString();

Console.WriteLine(valor11);
Console.WriteLine(valor22);
Console.WriteLine(valor33);

Console.WriteLine("\n###Usando a Classe Convert() ###");
int valorInt22 = 10;
bool valorBoolean22 = true;
bool valorBoolean33 = false;

Console.WriteLine(Convert.ToString(valorInt22));
Console.WriteLine(Convert.ToInt16(valorBoolean22));
Console.WriteLine(Convert.ToInt16(valorBoolean33));
