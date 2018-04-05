using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Post
/// </summary>
public class Post
{
    public int topic;
    public string content;
    public int by;
    public DateTime date;

    public Post(int topic, string content, DateTime date, int by)
    {
        this.topic = topic;
        this.content = content;
        this.date = date;
        this.by = by;
    }
}