using System.Collections;

namespace LibrairieConversionNote;

public class ConversionAlphabetiqueToNote
{
    readonly Dictionary<string, string> alphabeticalToNote = new() {
        { "A", "DO" },
        { "B", "RE" }, 
        { "C", "MI" },
        { "D", "FA" }, 
        { "E", "SOL" }, 
        { "F", "LA" },
        { "G", "SI" } 
    };
    public string AlphabeticalToNote(string KEY)
    {
        return alphabeticalToNote[KEY];
    }
    //private const string _DO = "Do";
    //private const string _RE = "RÉ";
    //private const string _MI = "MI";
    //private const string _FA = "FA";
    //private const string _SOL = "SOL";
    //private const string _LA = "LA";
    //private const string _SI = "SI";


    //public string Transformer(string Lettre)
    //{
    //    alphabeticalToNote.Clear();
    //    alphabeticalToNote.Add("DO", "A");
    //    alphabeticalToNote.Add("RÉ", "B");
    //    alphabeticalToNote.Add("MI", "C");
    //    alphabeticalToNote.Add("FA", "D");

        //switch ((Lettre)) 
        //{
        //    case "A": return _LA;
        //    case "B": return _SI;
        //    case "C": return _DO;
        //    case "D": return _RE;
        //    case "E": return _MI;
        //    case "F": return _FA;
        //    case "G": return _SOL;

        //    default:
        //        return "La note n'existe pas";

        //}

    
}