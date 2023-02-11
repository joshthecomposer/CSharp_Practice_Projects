//Arr practice

int[] intArr = new int[10];

for (int i = 0; i < intArr.Length; i++)
{
    intArr[i] = i;
}

string[] strArr = {"Time", "Martin", "Nikki", "Sara"};

bool[] boolArr = new bool[10];

for (int i = 0; i < boolArr.Length; i++)
{
    if (i % 2 == 0) 
    {
        boolArr[i] = true;
    }
    else
    {
        boolArr[i] = false;
    }
}

//List Practice

List<string> flavors = new List<string>();
flavors.Add("Chocolate");
flavors.Add("Vanilla");
flavors.Add("Strawberry");
flavors.Add("Neapolitan");
flavors.Add("Chocolate Chip");

Console.WriteLine(flavors.Count);
Console.WriteLine(flavors[2]);
// flavors.Remove(flavors[2]);

foreach(string flavor in flavors)
{
    Console.WriteLine(flavor);
}

Console.WriteLine(flavors.Count);

// Create a dictionary that will store string keys and string values.
// Add key/value pairs to the dictionary where:
// Each key is a name from your names array (this can be done by hand or using logic)
// Each value is a randomly selected flavor from your flavors List (remember Random from earlier?)
// Loop through the dictionary and print out each user's name and their associated ice cream flavor.

Dictionary<string, string> favoriteFlavors = new Dictionary<string, string>();
Random rd = new Random();

foreach(string name in strArr) 
{
    int n = rd.Next(0, flavors.Count);
    favoriteFlavors.Add(name, flavors[n]);
}

foreach(string key in favoriteFlavors.Keys)
{
    Console.WriteLine(key + " : " + favoriteFlavors[key]);
}
