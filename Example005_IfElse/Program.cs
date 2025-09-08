Console.WriteLine("What's your name?");
string username = Console.ReadLine();

if (username.ToLower() == "bob")
{
    Console.WriteLine("Hello, sweetheart!");
}

else
{
    Console.Write(username);
    Console.Write(", what do you need?");
}