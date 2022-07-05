
namespace LibrairieConversionNote
{

    public class ConversionAlphaToNote
    {

        public string AlphaToNote(string str)
        {

            string strReturnValue = string.Empty;

            switch (str.ToUpperInvariant())
            {
                case "A":
                    strReturnValue = "LA";
                    break;
                case "B":
                    strReturnValue = "SI";
                    break;
                case "C":
                    strReturnValue = "DO";
                    break;
                case "D":
                    strReturnValue = "RE";
                    break;
                case "E":
                    strReturnValue = "MI";
                    break;
                case "F":
                    strReturnValue = "FA";
                    break;
                case "G":
                    strReturnValue = "SOL";
                    break;
                default:
                    strReturnValue = "La note n'existe pas";
                    break;
            }

            return strReturnValue;
        }
    }


    
}

