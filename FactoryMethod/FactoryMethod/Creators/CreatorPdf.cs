namespace FactoryMethod;

public class CreatorPdf:CreatorDocument
{
    public override IDocument CreateDocument()
    {
        return new Pdf();
    }
}