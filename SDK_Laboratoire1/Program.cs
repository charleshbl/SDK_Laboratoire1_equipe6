using LibrairieConversionNote;



ConversionAlphabetiqueToNote alphaToNote = new ConversionAlphabetiqueToNote();

var choix = "..";
do
{
    Console.WriteLine("Bonjour ! Quelle conversion voulez-vous faire ?  :");
    choix = Console.ReadLine();
} while (choix.ToUpper() != "NOTE");

while (true)
{

    Console.WriteLine("Entrez une lettre entre A et G : ");
    Console.WriteLine($"Note:{alphaToNote.AlphabeticalToNote(Console.ReadKey(intercept: true).KeyChar.ToString().ToUpper())}");

}
