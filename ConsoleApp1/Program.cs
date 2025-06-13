using System;

Random rnd = new Random();

int level = 0;

// Choose your level
Console.Write("Enter the level you want: \'1\' (1-10) or \'2\' (1-50) or \'3\' (1-100): ");
// read the level
String choise = Console.ReadLine();

// update the level variable to the correct amount
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

// initalizng the answer according to the level
int answer = rnd.Next(1, level);

// starting the game loop
while (true)
{
    // asking for what number
    Console.Write("Enter a randon number between 1-" + (level - 1) + ": ");
    // using the try keyword to catch if the user putted something that is not a number
    try
    {
        // reading the guess
        String give = Console.ReadLine();
        int final = int.Parse(give);

        // check the guess
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
    }// catch if there is a format exception
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

// variable to convert string to int
static int StringtoInt(string value)
{
    return int.Parse(value);
}