using choreManagement.Models;

namespace choreManagement.Services;

public class ChoresService
{
    private readonly ChoresRepository _repo;

    public ChoresService(ChoresRepository repo)
    {
        _repo = repo;
    }

    internal List<Chore> GetChores()
    {
        List<Chore> chores = _repo.GetAllChores();
        return chores;
    }

    internal Chore GetOneChoreById(int choreId)
    {
        Chore chore = _repo.GetOneChoreById(choreId);
        if (chore == null) throw new Exception($"No chore with the id {choreId}");
        return chore;
    }

    internal Chore CreateChore(Chore choreData)
    {
        Chore chore = _repo.CreateChore(choreData);
        return chore;
    }

    internal string RemoveChore(int choreId)
    {
        Chore chore = this.GetOneChoreById(choreId);
        _repo.RemoveChore(choreId);
        return $"{chore.Title} has been completed";
    }
}