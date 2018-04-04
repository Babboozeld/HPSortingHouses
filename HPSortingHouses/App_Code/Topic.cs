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
    public string cat ;
    public string sub;
    public DateTime date;
    public int by;

    public Topic(string topic_title, string topic_cat, string topic_sub, DateTime topic_date, int topic_by)
    {
        this.title = topic_title;
        this.cat = topic_cat;
        this.sub = topic_sub;
        this.date = topic_date;
        this.by = topic_by;
    }
}