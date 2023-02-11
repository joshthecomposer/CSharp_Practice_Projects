// Challenge 1
bool amProgrammer = true; // Was a string
int Age = 27; //was a float
List<string> Names = new List<string>();
Names.Add("Monica"); //Was just a string instead of an add
Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
MyDictionary.Add("Hi there", "0");
// This is a tricky one! Hint: look up what a char is in C#
string MyName = "myName";

// Challenge 2
List<int> Numbers = new List<int>() {2,3,6,7,1,5};
for(int i = Numbers.Count-1; i >= 0; i--) // needed to be count-1 or index was out of range
{
    Console.WriteLine(Numbers[i]);
}

// Challenge 3
List<int> MoreNumbers = new List<int>() {12,7,10,-3,9};
foreach(int i in MoreNumbers)
{
    Console.WriteLine(i); // was set to MoreNumbers at i which returned an index out of range
}

// Challenge 4
List<int> EvenMoreNumbers = new List<int> {3,6,9,12,14};
for(int i = 0; i < EvenMoreNumbers.Count; i++)
{
    if(EvenMoreNumbers[i] % 3 == 0)
    {
        EvenMoreNumbers[i] = 0;
    }
    Console.WriteLine(EvenMoreNumbers[i]);
}

// Challenge 5
// What can we learn from this error message?
string MyString = "superduberawesome";
MyString[7] = "p";  //read only, cannot reassign this value



// Challenge 6
// Hint: some bugs don't come with error messages
Random rand = new Random();
int randomNum = rand.Next(12); // this is non-inclusive, it will never be 12.
if(randomNum == 12)
{
    Console.WriteLine("Hello");
}


