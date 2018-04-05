using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Subject
/// </summary>
public class Topic
{
    public string title;
    public string cat;
    public string content;
    public int by;
    public DateTime date;
    
    public Topic(string title, string cat, string content, DateTime date, int by)
    {
        this.title = title;
        this.cat = cat;
        this.content = content;
        this.date = date;
        this.by = by;
    }
}