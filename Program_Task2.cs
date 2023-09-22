Console.Write("Enter the first number: ");
string number_1 = Console.ReadLine();
Console.Write("Enter the second number: ");
string number_2 = Console.ReadLine();
int number1 = Int32.Parse(number_1);
int number2 = Int32.Parse(number_2);

if(number1>number2)
{
    Console.Write("Bigger number: ");
    Console.WriteLine(number1);
}
else
{
    Console.Write("Bigger number: ");
    Console.WriteLine(number2);
}