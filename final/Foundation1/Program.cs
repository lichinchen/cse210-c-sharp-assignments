using System;                      // Import system namespace 
using System.Collections.Generic;  // for using List

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of VideoLibrary to manage videos
        VideoLibrary videoLibrary = new VideoLibrary();

        // Video 1
        Video video1 = new Video("C# Tutorial for Beginners", "Programming with Mosh", 3600);                                                         // Create a new Video object           

        Comment v1Comment1 = new Comment("@Todayashifufiwara", "One of the best tutorials I've ever watched in my life. Thanks Mosh!");               // Create a new Comment object
        video1.AddComment(v1Comment1);         

        Comment v1Comment2 = new Comment("@biraescudero", "Clear, direct and fast. I can start coding in C# now! Thank you!");               
        video1.AddComment(v1Comment2);     

        Comment v1Comment3 = new Comment("@godboy", "I got an internship and this is one of the languages I'll be using. Thank you!");               
        video1.AddComment(v1Comment3);

        Comment v1Comment4 = new Comment("@pecanthejelly", "I learned more from this tutorial than I did in 12 weeks of a programming college course.");               
        video1.AddComment(v1Comment4);

        Comment v1Comment5 = new Comment("@Soulfyres", "This is really the best programming tutorial I've ever seen.");               
        video1.AddComment(v1Comment5);

        videoLibrary.AddVideo(video1);                                                                                                               // Add video1 to the library

        // Video 2
        Video video2 = new Video("What is C#", "Scott Hanselman", 103);                                                                              // Create a new Video object

        Comment v2Comment1 = new Comment("@tezrotech","It is really nice to have the tutorials of C# from the makers of C# itself.");               // Create a new Comment object
        video2.AddComment(v2Comment1);

        Comment v2Comment2 = new Comment("@Michael", "Finally! I love the fact you speak clear, fluent, and the right speed.");              
        video2.AddComment(v2Comment2);

        Comment v2Comment3 = new Comment("@Mellissa", "Can you make a part 2?");  
        video2.AddComment(v2Comment3);

        Comment v2Comment4 = new Comment("@sumiradnayadura", "This video is very useful to me. Thank you.");               
        video2.AddComment(v2Comment4);

        videoLibrary.AddVideo(video2);                                                                                                              // Add video2 to the library

        // Video 3
        Video video3 = new Video("Programming vs coding", "Aaron Jack", 360);                                                                       // Create a new Video object

        Comment v3Comment1 = new Comment("@noppasakr", "Coding is just a part of programming.");                                                    // Create a new Comment object
        video3.AddComment(v3Comment1); 

        Comment v3Comment2 = new Comment("@anglesmico", "As a developer of 3+ years I still didn't fully understand the difference.");               
        video3.AddComment(v3Comment2);

        Comment v3Comment3 = new Comment("@techboineo", "I'm a programmer and coder, and it's really a good job. I'm definitely happy , with what I do!");               
        video3.AddComment(v3Comment3);

        videoLibrary.AddVideo(video3);                                                                                                             // Add video3 to the library

        videoLibrary.ShowAllVideos();                                                                                                              // Display all videos and their comments
    }
}
