
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "жанна") // ToLower делает написание регистра беразличным. Приравнивает всё к нижнему регистру
{
    Console.WriteLine("Ура, это же ЖАННА");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}