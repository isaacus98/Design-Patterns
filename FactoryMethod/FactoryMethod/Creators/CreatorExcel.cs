namespace FactoryMethod;

public class CreatorExcel: CreatorDocument
{
    public override IDocument CreateDocument()
    {
        return new Excel();
    }
}