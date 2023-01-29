//Rakendus palub kasutajal valida tema sugu (m/f)
//Rakendus palub kasutajal sisestada tema perekonnanime
//Lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr./Ms. [kasutaja perekonnanimi]!"
Console.WriteLine("Please, select your gender (m/f):");
char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis
Console.WriteLine("Please, enter your last name:");
string userLastName = Console.ReadLine();
if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr.{userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}