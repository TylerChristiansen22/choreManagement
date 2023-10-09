namespace choreManagement.Repositories;

public class ChoresRepository
{
    private List<Chore> _FakeDb;

    public ChoresRepository()
    {
        _FakeDb = new List<Chore>();
        _FakeDb.Add(new Chore(1, "Clean Room", false));
        _FakeDb.Add(new Chore(2, "Clean Kitchen", false));
        _FakeDb.Add(new Chore(3, "Do Laundry", true));
    }

    internal Chore CreateChore(Chore choreData)
    {
        int choreId = _FakeDb[_FakeDb.Count - 1].Id;
        choreData.Id = choreId + 1;
        _FakeDb.Add(choreData);
        return choreData;
    }

    internal List<Chore> GetAllChores()
    {
        return _FakeDb;
    }

    internal Chore GetOneChoreById(int choreId)
    {
        Chore chore = _FakeDb.Find(c => c.Id == choreId);
        return chore;
    }

    internal void RemoveChore(int choreId)
    {
        Chore chore = _FakeDb.Find(c => c.Id == choreId);
        _FakeDb.Remove(chore);
    }
}