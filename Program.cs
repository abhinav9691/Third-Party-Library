namespace TPLProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("# Read data from CSV & Write data in CSV");
            //csvHandler.ImplementCSVDataHandling();
            //Console.WriteLine();

            Console.WriteLine("# Read data from CSV & Write data in JSON");
            ReadCSV_And_WriteJSON.ImplementCSVToJSON();
        }
    }
}