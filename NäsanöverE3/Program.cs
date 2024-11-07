string Val1;
string Val2;
string Val3;


int guess3 = getChoice("Hugo", "Maxi", "Sam");



static int getChoice(string Val1, string val2, string val3)
{
    int guess = 0;
    string guess2;
    bool lyckat2 = false;
    Console.WriteLine(Val1);
    Console.WriteLine(val2);
    Console.WriteLine(val3);

    while (lyckat2 == false)
    {
        Console.WriteLine("Välj en alternativ genom att skriva 1,2,3");
        guess2 = Console.ReadLine();
        bool lyckat = int.TryParse(guess2, out guess);
        if (lyckat == true && guess == 1 || guess == 2 || guess == 3)
        {
            lyckat2 = true;
        }
        else
        {
            Console.WriteLine("Fel svar");
        }
        
    }
    return guess;
}
guess3.ToString();
Console.WriteLine("Du valde: " + guess3);
Console.ReadLine();