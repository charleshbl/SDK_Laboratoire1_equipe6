using LibrairieConversionNote;



ConversionAlphabetiqueToNote conversionAlphabetiqueToNote=new ConversionAlphabetiqueToNote();

do
{
    Console.WriteLine("Bonjours Quelle conversion voulez-vous faire:");
   public string choix = Console.ReadLine() ;
} while (key.Key != ConsoleKey.Enter);

while (true)
{
    
    Console.WriteLine($@"Entrer une lettre entre A et G 
 {conversionAlphabetiqueToNote.Transformer(Console.ReadKey(intercept:true).KeyChar.ToString().ToUpper())}");

}
