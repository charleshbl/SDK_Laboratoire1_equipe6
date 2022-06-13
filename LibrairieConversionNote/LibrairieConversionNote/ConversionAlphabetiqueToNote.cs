namespace LibrairieConversionNote;

public class ConversionAlphabetiqueToNote
{
    private const string _DO = "Do";
    private const string _RE = "RÉ";
    private const string _MI = "MI";
    private const string _FA = "FA";
    private const string _SOL = "SOL";
    private const string _LA = "LA";
    private const string _SI = "SI";
    
    
    public string Transformer(string Lettre)
    {
        switch ((Lettre)) //CEci est un comenataire 
        {
            case "A": return _LA;
            case "B": return _SI;
            case "C": return _DO;
            case "D": return _RE;
            case "E": return _MI;
            case "F": return _FA;
            case "G": return _SOL;

            default:
                return "La note n'existe pas";

        }

    }
}