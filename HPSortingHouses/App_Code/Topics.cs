using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Subject
/// </summary>
public class Topics
{
    public int id;
    public string title;
    public string cat;
    public string content;
    public int by;
    public DateTime date;
    
    public Topics(int id, string title, string cat, string content, DateTime date, int by)
    {
        this.id = id;
        this.title = title;
        this.cat = cat;
        this.content = content;
        this.date = date;
        this.by = by;
    }
}