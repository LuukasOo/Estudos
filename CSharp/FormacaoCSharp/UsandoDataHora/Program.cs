Console.WriteLine("\n### Trabalhando com data e hora - DATETIME ###");
//DATETIME é do tipo valor e tem um valor Padrão
//O Valor Padrão é 01/01/0001 00:00:00

DateTime dataHoraAtual = DateTime.Now;
DateTime dataEspecifica = new DateTime(2025, 02, 02, 12, 00, 59);
DateTime aniversario = new DateTime(1998, 01, 08);


Console.WriteLine($"Data atual: {dataHoraAtual}");
Console.WriteLine($"Data especifica: {dataEspecifica}");
Console.WriteLine($"O dia da Semana que eu nasci é uma: {aniversario.DayOfWeek}");

//Operações com Data e Hora
//Extrair informacoes Year, Month, Hour, Minute, Second, Milisecond
//Adicionar AddDays, AddHours, AddMonths, AddYears
//Obter datas DayOdWeek, DayOfYear
//Expressar data formato longo e abreviado ToLongDateString ToShortDateString
//Expressar hora formato longo e abreviado ToLongHourString ToShortHourString