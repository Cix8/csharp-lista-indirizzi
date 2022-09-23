public class MainProgram
{
    private static string dataPath = "../../../data";
    
    public static void Init()
    {
        List<People> peopleList = MainProgram.FetchData();
        MainProgram.PeoplePrettyPrinter(peopleList);
    }
    private static List<People> FetchData()
    {
        List<People> peopleList = new List<People>();
        bool dataExists = Directory.Exists(MainProgram.dataPath);
        string[] dataFiles;

        if (dataExists)
        {
            dataFiles = Directory.GetFiles(MainProgram.dataPath);

            foreach (string file in dataFiles)
            {
                StreamReader sr = new StreamReader(file);

                sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] fetchedData = line.Split(',');
                    if (fetchedData.Count() == 6)
                    {
                        try
                        {
                            People newPerson = new People(fetchedData[0], fetchedData[1], fetchedData[2], fetchedData[3], fetchedData[4], Convert.ToInt32(fetchedData[5]));
                            peopleList.Add(newPerson);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Errore in: " + line + ": " + e.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Errore in: " + line + ": Elenco dati non idoneo");
                    }
                }

                sr.Close();

            }
        }

        return peopleList;
    }

    private static void PeoplePrettyPrinter(List<People> peopleList)
    {
        Console.WriteLine();
        foreach (People people in peopleList)
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"--- Nome: {people.Name}");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"--- Cognome: {people.Surname}");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"--- Città: {people.City}");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"--- Provincia: {people.Province}");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"--- Via: {people.Street}");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"--- CAP: {people.ZIP}");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
        }
    }
}