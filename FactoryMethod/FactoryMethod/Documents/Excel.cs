namespace FactoryMethod;

public class Excel: IDocument
{
    public void Save()
    {
        Console.WriteLine("Save Excel");
    }
}