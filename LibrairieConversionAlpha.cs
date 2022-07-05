namespace LibrairieConversionAlpha

{
    public class ConversionNoteToAlpha
    {

        public string NoteToAlpha(string str)
        {

            string strReturnValue = string.Empty;

            switch (str.ToUpperInvariant())
            {
                case "LA":
                    strReturnValue = "A";
                    break;
                case "SI":
                    strReturnValue = "B";
                    break;
                case "DO":
                    strReturnValue = "C";
                    break;
                case "RE":
                    strReturnValue = "D";
                    break;
                case "MI":
                    strReturnValue = "E";
                    break;
                case "FA":
                    strReturnValue = "F";
                    break;
                case "SOL":
                    strReturnValue = "G";
                    break;
                default:
                    strReturnValue = "La lettre n'existe pas";
                    break;
            }

            return strReturnValue;
        }
    }
}