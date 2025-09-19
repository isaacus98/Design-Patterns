namespace FactoryMethod;

public class Word: IDocument
{
    public void Save()
    {
        Console.WriteLine("Save Word");
    }
}