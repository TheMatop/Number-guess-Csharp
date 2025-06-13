using System;

Random rnd = new Random();

int level = 0;

Console.Write("Enter the level you want: \'1\' (1-10) or \'2\' (1-50) or \'3\' (1-100): ");

String choise = Console.ReadLine();

if (StringtoInt(choise) == 1)
{
    level = 11;
}

if (StringtoInt(choise) == 2)
{
    level = 51;
}

if (StringtoInt(choise) == 3)
{
    level = 101;
}

int answer = rnd.Next(1, level);

while (true)
{
    Console.Write("Enter a randon number between 1-10: ");
    try
    {
        String give = Console.ReadLine();
        int final = int.Parse(give);

        if (final == answer)
        {
            Console.WriteLine("You are correct!");
            break;
        }
        else
        {
            if (final > answer)
            {
                Console.WriteLine("Smaller");
                continue;
            }
            else if (final < answer)
            {
                {
                    Console.WriteLine("Bigger");
                    continue;
                }
            }
        }
    }
    catch (System.FormatException ex)
    {
        Console.WriteLine("Put a number!");
        continue;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: " + ex);
        continue;
    }
}

static int StringtoInt(string value)
{
    return int.Parse(value);
}