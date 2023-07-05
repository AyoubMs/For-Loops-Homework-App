
string namesText;

bool isInvalid = false;

Console.WriteLine("A,B".IndexOf(" "));

do
{
    Console.Write("Enter a comma-separated list of firstNames (or exit): ");

    namesText = Console.ReadLine();

    string[] namesArr = namesText.Split(',').ToArray();

    if (namesText.IndexOf(" ") != -1)
    {
        Console.WriteLine("Please remove whitespace to have a valid list");
    }

    for (int i = 0; i < namesArr.Length; i++)
    {
        if (int.TryParse(namesArr[i], out int dumb))
        {
            isInvalid = true;
            break;
        }
    }

    if (isInvalid)
    {
        Console.WriteLine("Please remove numbers from the list");
        isInvalid= false;
    }

    if (namesText != "exit" && namesText.IndexOf(" ") == -1)
    {
        for (int i = 0; i < namesArr.Length; i++)
        {
            Console.WriteLine(namesArr[i]);
        }
    }

} while (namesText != "exit");
