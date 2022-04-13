Console.Write("Введите имя: ");
string username = Console.ReadLine();
if(username.ToLower() == "Маша")
{
    Console.WriteLine("Ура маша!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}
