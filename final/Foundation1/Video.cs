using System.Runtime.CompilerServices;

public class Video
{
    // attributes for video title, author, length, and comments
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    
    // constructor
    public Video(string title, string author, int length, List<Comment> comments)
    {
        // initialize attributes
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>(comments);
    }
    
    // methods
    private int NumberOfComments() {
        return _comments.Count;                         // count number of comments
    }
    public void DisplayDetails() {
        Console.WriteLine($"Title: {_title}, Author: {_author}, Length: {_length}, Number of Comments: {NumberOfComments()}");
    }
    public void DisplayComments() {                     // display all comments
        foreach(Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        
    }
}