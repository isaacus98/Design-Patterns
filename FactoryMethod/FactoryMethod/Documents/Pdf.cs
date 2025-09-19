namespace FactoryMethod;

public class Pdf: IDocument
{
    public void Save()
    {
        Console.WriteLine("Save Pdf");
    }
}