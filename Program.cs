// printer navnet ditt eller det du har skrevet under inputtem
Console.WriteLine("Skriv navnet ditt:");
string navn = Console.ReadLine();
Console.Clear();
Console.WriteLine("Hei " + navn);
Console.WriteLine("[1] for quiz");
Console.WriteLine("[2] Quit");
string Svar = Console.ReadLine();


if (Svar=="1"){
    Quiz();
};

if (Svar=="2"){
    System.Environment.Exit(1);
}

static void Quiz(){

    Console.Clear();

    int score = 0;
    Console.WriteLine("Nå skal vi ha en liten quiz.");


    // spørsmål 1
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

    Thread.Sleep(2000);
    Console.Clear();

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

    Thread.Sleep(2000);
    Console.Clear();   


    // spørsmål 3
    Console.WriteLine("Spørsmål 3: hvor fort er lydens hastighet?");

    // svar alternativ
    Console.WriteLine ("1. 1236 km/t");
    Console.WriteLine ("2. 1238 km/t");
    Console.WriteLine ("3. 1234 km/t");
    Console.WriteLine ("4. 1239 km/t");

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

    Thread.Sleep(2000);
    Console.Clear();


    // spørsmål 3
    Console.WriteLine("Spørsmål 4: hvert år går månen litt lenger vekk fra jorden, hvor langt vekk går den i året?");

    // svar alternativ
    Console.WriteLine ("1. 1 km");
    Console.WriteLine ("2. 300 m");
    Console.WriteLine ("3. 4 cm");
    Console.WriteLine ("4. 1 dm");

    // du svarer med å skrive tall
    string svar4 = Console.ReadLine();
    int svar4int = int.Parse(svar4);

    Console.Clear();

    switch (svar4int)
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

 

    Console.WriteLine("Quizen er ferdig du fikk: " + score + " av 4 poeng.");

    Thread.Sleep(5000);
    Console.Clear();
}





