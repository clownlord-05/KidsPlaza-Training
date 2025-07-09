namespace asp
{
    public interface IRepository
    {
        string GetById(int id);
        string GetById(string v);
    }
}
