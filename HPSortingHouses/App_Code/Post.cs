using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Post
/// </summary>
public class Post
{
    public string post_content;
    public string post_date;
    public int post_by;
    public Post(string post_content, string post_date, int post_by)
    {
        this.post_content = post_content;
        this.post_date = post_date;
        this.post_by = post_by;
    }
}