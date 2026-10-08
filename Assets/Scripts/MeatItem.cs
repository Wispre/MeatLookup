public class MeatItem
{
    public string MeatName;
    public string MeatID;

    public MeatItem(string name, string id)
    {
        this.MeatName = name.ToLower();
        this.MeatID = id;
    }
}
