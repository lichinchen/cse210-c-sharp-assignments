using System;                      // Import system namespace
using System.Collections.Generic;  // For using Lists

// VideoLibrary class is responsible for managing the list of videos
public class VideoLibrary
{
    private List<Video> _videos;   // List to store video objects

    // initialize the list of videos
    public VideoLibrary()
    {
        _videos = new List<Video>();
    }

    // Method to add a video to the list
    public void AddVideo(Video video)
    {
        _videos.Add(video);        // Add the given video object to the list
    }

    // Method to display all videos in the list
    public void ShowAllVideos()
    {
        int index = 1;                         // Counter to display video numbers
        foreach (Video video in _videos)       // Loop through all videos in the list
        {
            video.DisplayVideoInfo(index);     // Display information for each video
            index++;                           // Increment the index for the next video
            Console.WriteLine();               // Print a blank line
        }
    }
}
