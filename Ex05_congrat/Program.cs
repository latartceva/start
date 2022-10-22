Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "ирина")
{
    Console.WriteLine("Привет Ирусик!!!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}