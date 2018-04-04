<%@ Application Language="C#"  %>
<%@ Import Namespace="WebMatrix.Data" %>
<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        // Code that runs on application startup

    }

    void Application_End(object sender, EventArgs e)
    {
        //  Code that runs on application shutdown

    }

    void Application_Error(object sender, EventArgs e)
    {
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e)
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e)
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.
        if (Session["Vlist"] != null)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HarryPotter.mdf;Integrated Security=True";
            string provider = "System.Data.SqlClient";
            Database db = Database.OpenConnectionString(connectionString, provider);

            string Vliststring = "";
            foreach (int item in (List<int>)Session["Vlist"]) {
                Vliststring += "+" + Convert.ToString(item);
            }
            Vliststring = Vliststring.Remove(0, 1);
            int id = Convert.ToInt32(Session["id"]);
            int h = Convert.ToInt32(Session["Hufflepuff"]);
            int r = Convert.ToInt32(Session["Ravenclaw"]);
            int s = Convert.ToInt32(Session["Slytherin"]);
            int g = Convert.ToInt32(Session["Gryffindor"]);
            string sortingProgress = "INSERT INTO [sorting] (Id, Vlist, Hufflepuff, Ravenclaw, Slytherin, Gryffindor) VALUES (@0, @1, @2, @3, @4, @5)";
            db.Execute(sortingProgress, id, Vliststring, h, r, s, g);
        }
    }

</script>
