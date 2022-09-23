string dataPath = "../../../data";

bool dataExists = Directory.Exists(dataPath);
string[] dataFiles;
List<People> peopleList = new List<People>();

if(dataExists)
{
    dataFiles = Directory.GetFiles(dataPath);
    
    foreach(string file in dataFiles)
    {
        StreamReader sr = new StreamReader(file);

        sr.ReadLine();

        while(!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            string[] fetchedData = line.Split(',');
            if(fetchedData.Count() == 6)
            {
                try
                {
                    People newPerson = new People(fetchedData[0], fetchedData[1], fetchedData[2], fetchedData[3], fetchedData[4], Convert.ToInt32(fetchedData[5]));
                    peopleList.Add(newPerson);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Errore in: " + line + ": "+ e.Message);
                }
            } else
            {
                Console.WriteLine("Errore in: " + line + ": Elenco dati non idoneo");
            }
        }

        sr.Close();

    }
}