Console.WriteLine("----------------------------- Tipos de Dados -----------------------------");

Console.WriteLine("\n### Declarando variaveis numericas ###");
byte valor1 = 255;
sbyte valor2 = -127;
int inteiro = 247483647;
uint valor3 = 247483647;
long valor4 = -2147486489;


Console.WriteLine("\n### Atribuindo valores a double, float e decimal ###");
double valor5 = 1.234;
float valor6 = 1.234f;
decimal valor7 = 1.234m;


Console.WriteLine("\n### Comparando valores entre double, float e decimal ###");
//O tipo decimal tem a maior precisão.
float resultFloat = 1f / 3f;
double resultDouble = 1d / 3d;
decimal resultDecimal = 1m / 3m;

Console.WriteLine(resultFloat);
Console.WriteLine(resultDouble);
Console.WriteLine(resultDecimal);


Console.WriteLine("\n### Tipos não numericos (BOOL & CHAR) ###");
bool usuarioAtivo = false;
char sexo = 'M';
char unicode = '\u004D';

Console.WriteLine(usuarioAtivo);
Console.WriteLine(sexo);
Console.WriteLine(unicode);



Console.WriteLine("\n### Tipos de referencia ###");
string nome = "João Lucas"; //As STRINGS são imutaveis
object nota = 10;
object valorObject = 10.55m;
object nomeObject = "João Lucas";
object verdadeiro = true;
object sexoObject = 'M';

dynamic notaDynamic = 10;
dynamic valorDynamic = 10.55d;
dynamic nomeDynamic = "João";
dynamic falso = true;