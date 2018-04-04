using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;
/// <summary>
/// Summary description for Posts_handler
/// </summary>
public static class Posts_handler
{
    public static int PostTopic(Topic topic)
    {
        //open database
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HarryPotter.mdf;Integrated Security=True";
        string provider = "System.Data.SqlClient";
        Database db = Database.OpenConnectionString(connectionString, provider);  
        
        db.Execute("INSERT INTO [topics] (title, cat, content, by, date) VALUES (@0, @1, @2, @3, @4)", topic.title, topic.cat, topic.content, topic.by, DateTime.Now);
        return Convert.ToInt32(db.QueryValue("SELECT MAX(id) FROM [topics]"));
    }

    public static Topic GetTopic(int id)
    {
        //open datbase
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HarryPotter.mdf;Integrated Security=True";
        string provider = "System.Data.SqlClient";
        Database db = Database.OpenConnectionString(connectionString, provider);

        var topicdata = db.QuerySingle("SELECT * FROM [topics] WHERE id = @0", id);
        if (topicdata == null)
        {
            return null;
        } else
        {
            return new Topic(topicdata.title, topicdata.cat, topicdata.content, Convert.ToInt32(topicdata.by), topicdata.date);
        }
    }

    public static List<Post> GetPost(int id)
    {
        //open datbase
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HarryPotter.mdf;Integrated Security=True";
        string provider = "System.Data.SqlClient";
        Database db = Database.OpenConnectionString(connectionString, provider);

        List<Post> posts = null;
        var postsdata = db.Query("SELECT * FROM [posts] WHERE topic = @0", id);

        foreach (var item in postsdata)
        {
             posts.Add(new Post(Convert.ToInt32(item.topic), item.content, item.date, Convert.ToInt32(item.by)));
        }

        return posts;
    }

   
}