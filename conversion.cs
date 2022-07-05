using System;
using LibrairieConversionNote;
using LibrairieConversionAlpha;

ConversionAlphaToNote conversionAN = new ConversionAlphaToNote();
ConversionNoteToAlpha conversionNA = new ConversionNoteToAlpha();


while (true)
{
    Console.Write("Type de conversion à faire : ");
    var input = Console.ReadLine();

    
    if (input?.ToUpperInvariant() == "NOTE")
    {
        
        while (true)
        {
            Console.Write("Conversion à faire : ");
            var note = Console.ReadLine();
            var noteRetour = conversionAN.AlphaToNote(note);
            Console.Write(noteRetour);
            Console.WriteLine();
        }
    }
    
    else if (input?.ToUpperInvariant() == "ALPHA")
    {
        while (true)
        {
            Console.Write("Conversion à faire : ");
            var alpha = Console.ReadLine();
            var alphaRetour = conversionNA.NoteToAlpha(alpha);
            Console.Write(alphaRetour);
            Console.WriteLine();
        }
    }
}
