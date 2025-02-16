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
        Reference mosiahReference = new Reference("Mosiah", 18, 27, 29);
        string mosiahText = "And they did come down into the waters of Mormon, and there were they baptized...\n" +
                            "And they were called the people of God.";  
        verses.Add(new Scripture(mosiahReference, mosiahText));
        
        Reference almaReference = new Reference("Alma", 5, 29, 33);
        string almaText = "For behold, I will show you that this is a perfect plan of happiness...\n" +
                           "And now, my beloved brethren, I desire that ye should be even as I am.";  
        verses.Add(new Scripture(almaReference, almaText));
        
        Reference moroniReference = new Reference("Moroni", 8, 21, 23);
        string moroniText = "And now, behold, I speak unto you concerning baptism...\n" +
                            "For behold, the Father, and the Son, and the Holy Ghost are one, and they are one God.";  
        verses.Add(new Scripture(moroniReference, moroniText));
        
        Reference nephiReference = new Reference("2 Nephi", 2, 25, 26);
        string nephiText = "Adam fell that men might be; and men are, that they might have joy.\n" +
                           "And the Messiah cometh in the fullness of time, that He may redeem the children of men.";  
        verses.Add(new Scripture(nephiReference, nephiText));
        
        Reference jacobReference = new Reference("Jacob", 2, 18, 19);
        string jacobText = "But before ye seek for riches, seek ye for the kingdom of God.\n" +
                           "And after ye have obtained a hope in Christ, ye shall obtain riches if ye seek them.";  
        verses.Add(new Scripture(jacobReference, jacobText));

        return verses;  
    }

    public static Scripture GetMultipleVerses()           // Get random multiple verses
    {
        int index = _random.Next(_multipleVerses.Count);  // Get random index
        Scripture verse = _multipleVerses[index];         // Select verse
        return verse;                                     // Return verse
    }
}
