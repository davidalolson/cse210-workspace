using System;

class Program
{
    static void Main(string[] args)
    {
        // variables
        List<Comment> comments = new List<Comment>();
        List<Video> videos = new List<Video>();
        
        /*****************************************************
            [VIDEO]

            Tennis for Two - The Original Video Game
            0:59
            - The Dot Eaters

            
            [COMMENTS]

            @Ponynstuff320
            Even though this is a super old game, the movement
            of the graphics was really impressive. I actually
            want to play this...

            
            @vicviper9413
            That's a pretty smooth framerate for a 60 year old game.

            
            @spacewaffles3254
            can't wait for pong to come out so much hype

        ******************************************************/
        // generate comments
        Comment commentV0_0 = new Comment("Ponynstuff320", "Even though this is a super old game, the movement of the graphics was really impressive. I actually want to play this...");
        Comment commentV0_1 = new Comment("vicviper9413", "That's a pretty smooth framerate for a 60 year old game.");
        Comment commentV0_2 = new Comment("spacewaffles3254", "can't wait for pong to come out so much hype");

        // add comments to list
        comments.Add(commentV0_0);
        comments.Add(commentV0_1);
        comments.Add(commentV0_2);

        // generate video
        Video video0 = new Video("Tennis for Two - The Original Video Game", "The Dot Eaters", 59, comments);

        // add video to list
        videos.Add(video0);

        /*****************************************************
            [VIDEO]
            STRANDBEEST EVOLUTION 2021
            4:30
            - theo jansen
            
            [COMMENTS]
            @seb1520
            The way he runs after the strandbeest walking
            towards the ocean is honestly so endearing, like he’s chasing
            after his child who’s learning to walk and already
            wants to run before he’s ready

            @Kai-qe3bo
            Your Strandbeests give me a very special kind of inner
            peace. Watching them just has a very soothing nature to it.
            Thank you for sharing!


            @KITTENLIVE
            What a bright and cheery visual. Animated art is rare, but
            to this degree was unheard of until this man broke our
            contemporary notions of what is possible. Can't imagine
            the engineering and work that goes into imagining, drawing
            up, building, transporting, and then chasing down one of these
            mobile masterpieces. A deeply profound sense of appreciation
            for this man and his team.

            @louielouie
            I saw Theo’s strandbeest a couple of years ago. I can’t find
            words to describe how special they really are. The way they
            move, it’s truly amazing. What an artist.

            

        ******************************************************/
        // generate comments
        Comment commentV1_0 = new Comment("seb1520", "The way he runs after the strandbeest walking towards the ocean is honestly so endearing, like hes chasing after his child whos learning to walk and already wants to run before hes ready");
        Comment commentV1_1 = new Comment("Kai-qe3bo", "Your Strandbeests give me a very special kind of inner peace. Watching them just has a very soothing nature to it. Thank you for sharing!");
        Comment commentV1_2 = new Comment("KITTENLIVE", "What a bright and cheery visual. Animated art is rare, but to this degree was unheard of until this man broke our contemporary notions of what is possible. Cant imagine the engineering and work that goes into imagining, drawing up, building, transporting, and then chasing down one of these mobile masterpieces. A deeply profound sense of appreciation for this man and his team.");
        Comment commentV1_3 = new Comment("louielouie", "I saw Theos strandbeest a couple of years ago. I can’t find words to describe how special they really are. The way they move, it’s truly amazing. What an artist.");

        // add comments to list
        comments.Add(commentV1_0);
        comments.Add(commentV1_1);
        comments.Add(commentV1_2);

        // generate video
        Video video1 = new Video("STRANDBEEST EVOLUTION 2021", "The Dot Eaters", 270, comments);

        // add video to list
        videos.Add(video1);

        /*****************************************************
            [VIDEO]

            Outer Wilds - How to safely and easily board the Sun Station
            1:24
            - YuriPrime
            
            [COMMENTS]


            @Yuti640
            The classic "Smash your ship into the sun station and nearly die" technique, my favourite

            
            @pumpkin_pants3828
            this is like the interstellar docking scene except hes a TERRIBLE pilot with incredible luck
            
            @gsami1256
            Crashes: 1 Uncool Crashes: 0

        ******************************************************/
        // generate comments
        Comment commentV2_0 = new Comment("Yuti640", "The classic \"Smash your ship into the sun station and nearly die\" technique, my favourite");
        Comment commentV2_1 = new Comment("pumpkin_pants3828", "this is like the interstellar docking scene except hes a TERRIBLE pilot with incredible luck");
        Comment commentV2_2 = new Comment("gsami1256", "Crashes: 1 Uncool Crashes: 0");

        // add comments to list
        comments.Add(commentV2_0);
        comments.Add(commentV2_1);
        comments.Add(commentV2_2);

        // generate video
        Video video2 = new Video("Outer Wilds - How to safely and easily board the Sun Station", "YuriPrime", 84, comments);

        // add video to list
        videos.Add(video2);

        // display stored information
        foreach(Video video in videos)
        {
            Console.WriteLine();

            video.DisplayDetails();

            Console.WriteLine();

            video.DisplayComments();

            Console.WriteLine();
        }
    }
}