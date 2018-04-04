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

    public static void PostSubject(Topic topic)
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HarryPotter.mdf;Integrated Security=True";
        string provider = "System.Data.SqlClient";
        Database db = Database.OpenConnectionString(connectionString, provider);                            
        db.Execute("INSERT INTO [topics] (topic_sub, topic_date, topic_cat,topic_by, topic_title ) VALUES (@0, @1, @2, @3, @4)", topic.sub, DateTime.Now,topic.cat,topic.by,topic.title);
                           
    }

    public static Topic GetTopic(int id)
    {
        //open datbase
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HarryPotter.mdf;Integrated Security=True";
        string provider = "System.Data.SqlClient";
        Database db = Database.OpenConnectionString(connectionString, provider);

        var topicdata = db.QuerySingle("SELECT * FROM [topics] WHERE topic_id = @0", id);
        if (topicdata == null)
        {
            return null;
        } else
        {
            return new Topic(topicdata.topic_sub, topicdata.topic_cat, topicdata.topic_content, topicdata.topic_date, topicdata.topic_by);
        }
    }

    public static List<Post> GetPost(int id)
    {
        //open datbase
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HarryPotter.mdf;Integrated Security=True";
        string provider = "System.Data.SqlClient";
        Database db = Database.OpenConnectionString(connectionString, provider);

        List<Post> posts = null;
        var postsdata = db.Query("SELECT * FROM posts WHERE post_topic = @0", id);

        foreach (var item in postsdata)
        {
             posts.Add(new Post(item.post_content, item.post_date, Convert.ToInt32(item.post_by)));
        }

        return posts;
    }
}