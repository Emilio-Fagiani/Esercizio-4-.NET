Console.WriteLine("Please, insert text");
string text = Console.ReadLine();
char[] txet = text.ToCharArray();
for (int i = txet.Length-1;i >= 0; i--)
{
    Console.Write(txet[i]);
}
Console.WriteLine();    
