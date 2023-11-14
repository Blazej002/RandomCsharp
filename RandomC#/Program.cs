// See https://aka.ms/new-console-template for more information

Random ran = new Random();
int zero = 0;
int one = 0;
int two = 0;
int three = 0;
int four = 0;

for (int i = 0; i < 20; i++)
{
    var randomNumber = ran.Next(0, 4);
    if (randomNumber == 0)
    {
        zero++;
    }

    if (randomNumber == 1)
    {
        one++;
    }

    if (randomNumber == 2)
    {
        two++;
    }

    if (randomNumber == 3)
    {
        three++;
    }

    if (randomNumber == 4)
    {
        four++;
    }
}

Console.WriteLine($"Zero = {zero}");
Console.WriteLine($"One = {one}");
Console.WriteLine($"Two = {two}");
Console.WriteLine($"Three = {three}");
Console.WriteLine($"Four = {four}");