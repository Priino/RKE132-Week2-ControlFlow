// See https://aka.ms/new-console-template for more information

//rakendus palub kasutajal valida tema sugu (m/n)
//rakendus palub kasutajal sisestada tema nime
//rakendus tervitab kasutajat
//"Welcome, Mr. [kasutaja perekonnanimi] / Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis

Console.WriteLine("Please, enter your last name:");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}