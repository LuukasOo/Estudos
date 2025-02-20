Console.WriteLine("\n###Usando PlaceHolders ###");
string nomeHolder = "João";
int idadeHolder = 27;
Console.WriteLine("{0} tem {1} anos", nomeHolder, idadeHolder);


Console.WriteLine("\n###Inferencia de Tipos (var)###");

int idade = 25;
string nome = "João";
decimal salario = 100.00m;
Console.WriteLine($"\n{nome} tem {idade} e ganha {salario}R$ de salario");

var nomeVar = "João";
var idadeVar = 27;
var salarioVar = 2500.00m;
Console.WriteLine($"{nomeVar} tem {idadeVar} e ganha {salarioVar}R$ de salario");



Console.WriteLine("\n###Operadores de atribuição ###");

int x = 0;
x += 100;  // x = x + 100 = 100
x -= 30;  // x = x - 30 = 70
x *= 4;  // x = x * 4 
x /= 5;  //x = x / 5 = 56;
x %= 2; //x = x % 256 = 


//Usando com strings
string yx = "123";
string xy = "456";
yx += xy;
Console.WriteLine(yx);


Console.WriteLine("\n### Operadores de incremento e decremento ###");
int id = 1;

//X++ ---> pós incrmento
x++; //Incrementa 1

//++X pré incremento
x--; //Decrementa 1

 










Console.ReadLine();



