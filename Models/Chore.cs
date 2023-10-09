using System.Drawing;

namespace choreManagement.Models;

public class Chore
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool Completed { get; set; }

    public Chore(int id, string title, bool completed)
    {
        Id = id;
        Title = title;
        Completed = completed;
    }

}