using LibrairieConversionNote;



ConversionAlphabetiqueToNote conversionAlphabetiqueToNote=new ConversionAlphabetiqueToNote();
var choix = "..";
do
{
    Console.WriteLine("Bonjours Quelle conversion voulez-vous faire:");
   choix = Console.ReadLine() ;
} while (choix.ToUpper() != "NOTE");

while (true) 
{
    
    Console.WriteLine($@"Entrer une lettre entre A et G 
 {conversionAlphabetiqueToNote.Transformer(Console.ReadKey(intercept:true).KeyChar.ToString().ToUpper())}");

}
