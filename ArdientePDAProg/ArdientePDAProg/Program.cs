// See https://aka.ms/new-console-template for more information
using ArdientePDAProg;


Console.WriteLine("Choose Language to Check: ");
Console.WriteLine("1) Palindrome");
Console.WriteLine("2) Bracket");
int input = Convert.ToInt32(Console.ReadLine());
ILanguage lang;
switch (input)
{
    case 1:
        Console.WriteLine("\t\t\tPalindrome Running..");
        lang = new Palindrome();
        break;
    case 2:
        Console.WriteLine("\t\t\tBracket Running..");
        lang = new Bracket();
        break;
    default:
        throw new ArgumentException();
}
string s;
Console.Write("Input a string: ");
s = Console.ReadLine()!;

if (lang.Run(s))
{
    Console.WriteLine("WOW! string is accepted!");
}
else
{
    Console.WriteLine("Sorry, string is not accepted");
}
