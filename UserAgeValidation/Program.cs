//Rakendus palub kasutajal sisestada tema vanuse
//Kui kasutaja on noorem kui 13 aastane, siis konsoolis kuvatakse:
//"You are too young to use Instagram."
//Muul juhul konsoolis kuvatakse:
//"Welcome to Instagram!"
Console.WriteLine("Enter your age:");
int userAge = Int32.Parse(Console.ReadLine()); //"13" - heap, 13 - stack
if (userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else //if (userAge < 13)
{
    Console.WriteLine("You are too young to use Instagram.");
}