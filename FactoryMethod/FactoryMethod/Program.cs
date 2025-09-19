using FactoryMethod;

CreatorDocument creator;
IDocument document;
string? response;

// Options to choose
OptionsMessage();


// Logic application
do
{
    response = Console.ReadLine();

    if (string.IsNullOrEmpty(response) || !Int32.TryParse(response, out _))
    {
        response = null;
        OptionsMessage();
    }
} while (response == null);

switch (Convert.ToInt32(response))
{
    case 1:
        creator = new CreatorWord();
        document = creator.CreateDocument();
        document.Save();
        break;
    case 2:
        creator = new CreatorExcel();
        document = creator.CreateDocument();
        document.Save();
        break;
    case 3:
        creator = new CreatorPdf();
        document = creator.CreateDocument();
        document.Save();
        break;
    default:
        Console.WriteLine("The option has not been found.");
        break;
}

void OptionsMessage()
{
    Console.WriteLine("Select one of the following options:");
    Console.WriteLine("1 - Save Word");
    Console.WriteLine("2 - Save Excel");
    Console.WriteLine("3 - Save PDF");
    Console.WriteLine();
}