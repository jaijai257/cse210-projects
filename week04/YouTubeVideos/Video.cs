using System;
using System.Collections.Generic;

public class Video
{
    // Private fields
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    // Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    // Method to add a comment
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to get number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Method to display comments
    public void DisplayComments()
    {
        foreach (var comment in _comments)
        {
            Console.WriteLine(comment);
        }
    }

   
    public override string ToString()
    {
        return $"Title: {_title}, Author: {_author}, Length: {_length} seconds";
    }
}