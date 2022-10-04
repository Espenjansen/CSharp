// printer navnet ditt eller det du har skrevet under inputtem
Console.WriteLine("Skriv navnet ditt:");
string navn = Console.ReadLine();
Console.Clear();
Console.WriteLine("Hei " + navn);
int score = 0;
Console.WriteLine("Nå skal vi ha en liten quiz.");

// spørsmålet
Console.WriteLine("Spørsmål 1: Et hjerte har for første gang blitt transplantert fra et dyr til et menneske, fra hva slags dyr?");

// svar alternativ
Console.WriteLine ("1. en gris");
Console.WriteLine ("2. en ku");
Console.WriteLine ("3. en kylling");
Console.WriteLine ("4. en hest");

// du svarer med å skrive tall
string svar1 = Console.ReadLine();
int svar1int = int.Parse(svar1);

Console.Clear();

switch (svar1int)
{
    case 1:
        Console.WriteLine("Rett svar");
        score++;
        break;
    case 2:
        Console.WriteLine("feil svar");
        break;
    case 3:
        Console.WriteLine("feil svar");
        break;
    case 4:
        Console.WriteLine("feil svar");
        break;
}

Console.WriteLine("score: " + score);



// spørsmålet 2
Console.WriteLine("Spørsmål 2: hvor langt vekke er månen fra jorda?");

// svar alternativ
Console.WriteLine ("1. 364 000 km");
Console.WriteLine ("2. 300 000 km");
Console.WriteLine ("3. 384 400 km");
Console.WriteLine ("4. 3 000 000 km");

// du svarer med å skrive tall
string svar2 = Console.ReadLine();
int svar2int = int.Parse(svar2);

Console.Clear();

switch (svar2int)
{
    case 1:
        Console.WriteLine("feil svar");
        break;
    case 2:
        Console.WriteLine("feil svar");
        break;
    case 3:
        Console.WriteLine("Rett svar");
        score++;
        break;
    case 4:
        Console.WriteLine("feil svar");
        break;
}

Console.WriteLine("score: " + score);



Console.WriteLine("Spørsmål 3: ?");

// svar alternativ
Console.WriteLine ("1. ");
Console.WriteLine ("2. ");
Console.WriteLine ("3. ");
Console.WriteLine ("4. ");

// du svarer med å skrive tall
string svar3 = Console.ReadLine();
int svar3int = int.Parse(svar3);

Console.Clear();

switch (svar3int)
{
    case 1:
        Console.WriteLine("feil svar");
        break;
    case 2:
        Console.WriteLine("Rett svar");
        score++;
        break;
    case 3:
        Console.WriteLine("feil svar");
        
        break;
    case 4:
        Console.WriteLine("feil svar");
        break;
}

Console.WriteLine("score: " + score);