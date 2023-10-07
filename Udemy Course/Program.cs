string path = @"C:\\Users\\User\\Documents\\poc.txt";

try
{
    Console.WriteLine($"The path is: {path}");

    Dictionary<string, int> candidates = new();

    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] votingRecord = sr.ReadLine().Split(",");
            string candidate = votingRecord[0];
            int votes = int.Parse(votingRecord[1]);

            if (candidates.ContainsKey(candidate))
            {
                candidates[candidate] += votes;
            }
            else
            {
                candidates.Add(candidate, votes);
            }
        }
    }

    foreach (KeyValuePair<string,int> item in candidates)
    {
        Console.WriteLine($"{item.Key}: {item.Value}");
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}