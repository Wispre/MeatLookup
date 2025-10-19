public class MeatItem
{
    public string MeatName;
    public int MeatCode;

    public MeatItem(string name, int code)
    {
        this.MeatName = name.ToLower();
        this.MeatCode = code;
    }
}
