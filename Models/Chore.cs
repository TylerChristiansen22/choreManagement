using System.Drawing;

namespace choreManagement.Models;

public class Chore
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public bool Completed { get; set; }

    public Chore(int id, string title, string body, bool completed)
    {
        Id = id;
        Title = title;
        Body = body;
        Completed = completed;
    }

}