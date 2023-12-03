using System;
using System.Collections.Generic;


public class Program
{
    public static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Video 1", "Author 1",30, 120);
        video1.AddComment(new Comments("UserA", "Nice video!"));
        video1.AddComment(new Comments("UserB", "Great content!"));
        videos.Add(video1);

        Video video2 = new Video("Video 2", "Author 2",60, 180);
        video2.AddComment(new Comments("UserC", "Interesting topic."));
        video2.AddComment(new Comments("UserD", "I learned a lot!"));
        video2.AddComment(new Comments("UserE", "Could use more examples."));
        videos.Add(video2);

        Video video3 = new Video("Video 3", "Author 3",90, 150);
        video3.AddComment(new Comments("UserF", "Helpful information."));
        video3.AddComment(new Comments("UserG", "Looking forward to more!"));
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}

    
