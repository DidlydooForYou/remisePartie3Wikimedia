using DAL;

public class LikesRepository : Repository<Like>
{
    public override int Add(Like item)
    {
        var id = base.Add(item);
        return id;
    }

    public override bool Delete(int id)
    {
        try
        {
            BeginTransaction();
            var result = base.Delete(id);
            EndTransaction();
            return result;
        }
        catch
        {
            EndTransaction();
            return false;
        }
    }


    public override bool Update(Like item)
    {
        var result = base.Update(item);
        return result;
    }
}
