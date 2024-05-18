using task1;

public static class Program
{
    public static void Main()
    {
        InputVarDesc: Console.WriteLine("variable daxil edin");
        string var = Convert.ToString(Console.ReadLine());
        if (var is not "basic" && var is not "pro" && var is not "expert")
        {
            goto InputVarDesc;
        }
        else
        {
            if (var == "basic")
            {
                DocumentProgram documentProgram = new DocumentProgram();
                documentProgram.OpenDocument();
                documentProgram.EditDocument();
                documentProgram.SaveDocument();
            }
            else if (var == "pro")
            {
                ProDocumentProgram proDocumentProgram = new ProDocumentProgram();
                proDocumentProgram.OpenDocument();
                proDocumentProgram.EditDocument();
                proDocumentProgram.SaveDocument();
            }
            else
            {
                ExpertDocumentProgram expertDocumentProgram = new ExpertDocumentProgram();
                expertDocumentProgram.OpenDocument();
                expertDocumentProgram.EditDocument();
                expertDocumentProgram.SaveDocument();
            }
        }
    }
}