using System;

Random rnd = new Random();
int answer = rnd.Next(1, 11);

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