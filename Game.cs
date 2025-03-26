using System;

public class Game
{
    // private Felter/fields
    private string gameName;
    private int ageLimit;
    private int gameVersion;




    // Public properties
    public string GameName
    {
        get { return gameName; }
        set
        {
            gameName = value;
        }
    }


    // Metode til at sætte aldergrænsen

    public int AgeLimit
    {
        get { return ageLimit; }

        set

        {
            if (value < 0)
                Console.WriteLine("Forkert input, aldersgrænse kan ikke være negativ");
            else

                ageLimit = value;
        }
    }

    public int GameVersion
    {
        get { return gameVersion; } //get method
        set
        {
            gameVersion = value;  //Set method

        }
    }


    // metode med spillets detaljer
    public void ShowDetails()
    {
        Console.WriteLine($"Game: {GameName}, Age Limit: {AgeLimit} Game Version: {GameVersion}");
    }
}
