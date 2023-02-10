Dictionary<string, string> profile = new Dictionary<string, string>();


profile.Add("Name", "Daniel");
profile.Add("Email","d@gmail.com");
profile.Add("Location","NYC");


Console.WriteLine("Student profile:");

foreach(string key in profile.Keys)
{
    Console.WriteLine(key + ": " + profile[key]);
}

foreach(KeyValuePair<string, string> entry in profile)
{
    Console.WriteLine(entry.Key + ": " + entry.Value);
}

