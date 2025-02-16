using System;                      // Import System
using System.Collections.Generic;  // Import collections

public static class Library
{
    private static Random _random = new Random();                           // Random number generator
    private static List<Scripture> _singleVerses = LoadSingleVerses();      // Load single verses
    private static List<Scripture> _multipleVerses = LoadMultipleVerses();  // Load multiple verses

    private static List<Scripture> LoadSingleVerses()                       // Load list of verses
    {
        List<Scripture> verses = new List<Scripture>();                     // Initialize list
    
        // Add scriptures to list
        Reference nephiReference = new Reference("2 Nephi", 2, 25);
        string nephiText = "Adam fell that men might be; and men are, that they might have joy.";
        verses.Add(new Scripture(nephiReference, nephiText));
        
        Reference etherReference = new Reference("Ether", 12, 27);
        string etherText = "And if men come unto me I will show unto them their weakness.";
        verses.Add(new Scripture(etherReference, etherText));
        
        Reference almaReference = new Reference("Alma", 37, 6);
        string almaText = "By small and simple things are great things brought to pass.";
        verses.Add(new Scripture(almaReference, almaText));
        
        Reference mosiahReference = new Reference("Mosiah", 2, 17);
        string mosiahText = "When ye are in the service of your fellow beings ye are only in the service of your God.";
        verses.Add(new Scripture(mosiahReference, mosiahText));
        
        Reference moroniReference = new Reference("Moroni", 10, 4);
        string moroniText = "If ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.";
        verses.Add(new Scripture(moroniReference, moroniText));

        return verses;  // Return list
    }


    public static Scripture GetSingleVerse()            // Get random verse
    {
        int index = _random.Next(_singleVerses.Count);  // Get random index
        Scripture verse = _singleVerses[index];         // Select verse
        return verse;                                   // Return verse
    }

    private static List<Scripture> LoadMultipleVerses()  // Load list of multiple verses
    {
        List<Scripture> verses = new List<Scripture>();  // Initialize list

        // Add scriptures to list
        Reference matthewReference = new Reference("Matthew", 5, 3, 4);
        string matthewText = "Blessed are the poor in spirit: for theirs is the kingdom of heaven.\n" +
                             "Blessed are they that mourn: for they shall be comforted.";
        verses.Add(new Scripture(matthewReference, matthewText));
        
        Reference johnReference = new Reference("John", 3, 16, 17);
        string johnText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.\n" +
                          "For God sent not his Son into the world to condemn the world; but that the world through him might be saved.";
        verses.Add(new Scripture(johnReference, johnText));
        
        Reference romansReference = new Reference("Romans", 8, 28, 29);
        string romansText = "And we know that all things work together for good to them that love God, to them who are the called according to his purpose.\n" +
                            "For whom he did foreknow, he also did predestinate to be conformed to the image of his Son, that he might be the firstborn among many brethren.";
        verses.Add(new Scripture(romansReference, romansText));
        
        Reference psalmReference = new Reference("Psalm", 23, 1, 2);
        string psalmText = "The Lord is my shepherd; I shall not want. He maketh me to lie down in green pastures: he leadeth me beside the still waters.\n" +
                           "He restoreth my soul: he leadeth me in the paths of righteousness for his name's sake.";
        verses.Add(new Scripture(psalmReference, psalmText));
        
        Reference isaiahReference = new Reference("Isaiah", 40, 30, 31);
        string isaiahText = "Even the youths shall faint and be weary, and the young men shall utterly fall:\n" +
                            "But they that wait upon the Lord shall renew their strength; they shall mount up with wings as eagles; they shall run, and not be weary; and they shall walk, and not faint.";
        verses.Add(new Scripture(isaiahReference, isaiahText));


        return verses;  
    }

    public static Scripture GetMultipleVerses()           // Get random multiple verses
    {
        int index = _random.Next(_multipleVerses.Count);  // Get random index
        Scripture verse = _multipleVerses[index];         // Select verse
        return verse;                                     // Return verse
    }
}
