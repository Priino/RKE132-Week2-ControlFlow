// See https://aka.ms/new-console-template for more information

//rakendus palub kasutajal sisestada oma vanus
//kui kasutaja on noorem kui 13, siis kuvatakse konsoolis:
//"You are to young to use Instagramm"
//konsoolis kuvatakse "Welcometo Instagramm"

Console.WriteLine("Enter your age:");

int userAge = Int32.Parse(Console.ReadLine()); //"13" - heap, 13 - stack

if(userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram. :)");
}
else //if(userAge < 13)
{
    Console.WriteLine("You are too young to use Instagram. :(");
}