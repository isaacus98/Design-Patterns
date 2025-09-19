namespace FactoryMethod;

public class CreatorWord: CreatorDocument
{
    public override IDocument CreateDocument()
    {
        return new Word();
    }
}