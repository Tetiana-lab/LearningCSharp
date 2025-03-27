// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");

int [] numbers = new int[5] {1,2,3,4,5};
Console.WriteLine(numbers[4]);
numbers[4]=44;
Console.WriteLine(numbers[4]);

//List
List<string> days =  new List<string>() {"Sunday", "Monday"};
Console.WriteLine(days[1]);
days[1]= "TheMonday";
Console.WriteLine(days[1]);
days.Add("Tuesday");
string[] toadd = new string[] {"Wednesday", "Thursday"};
days.AddRange(toadd);
var ishere = days.Contains("Friday");
days.Add("Friday");
ishere = days.Contains("Friday");
days.Remove("Friday");
ishere = days.Contains("Friday");
var howmahydays = days.Count;
days.Clear();

//Dictionary
Dictionary<int, string> numberNames = new Dictionary<int, string>();
numberNames.Add(1,"One");
numberNames.Add(2,"Two");
numberNames.Add(4,"One");
numberNames.Add(3,"Three");
var twoordef = numberNames.GetValueOrDefault(2);
var fiveordef = numberNames.GetValueOrDefault(5);
if(fiveordef != null)
{
    System.Console.WriteLine(fiveordef);
}

var isSuccess = numberNames.TryGetValue(2, out string two);
var isSuccess2 = numberNames.TryGetValue(5, out string five);
if(isSuccess2)
{
    System.Console.WriteLine(five);
}
var one = numberNames[1];
numberNames[1] = "six";
numberNames.Remove(3);
var s = numberNames.Count;

foreach(var keyvalue in numberNames)
{
    System.Console.WriteLine(keyvalue.Key);
    System.Console.WriteLine(keyvalue.Value);
}

Dictionary<string, int> namesNumbers = new Dictionary<string, int>();
namesNumbers.Add("One",1);
namesNumbers.Add("Two",2);
var onen = namesNumbers["One"];

//Hashset
var names = new HashSet<string>() {"Andriy", "Petro"};
names.Add("Maksym");
names.Remove("Andriy");
var ispetroHere = names.Contains("Petro");

//Queue and Stack
//1 2 3  ->> 1 2 3
//1 2 3  ->> 3 2 1
Queue<int> values = new Queue<int>();
values.Enqueue(1); 
values.Enqueue(2); 
values.Enqueue(3); 
values.Enqueue(3); 
while(values.TryDequeue(out int val))
{
    System.Console.WriteLine(val);
}
values.Enqueue(4);
var res = values.Dequeue();

Stack<int> sValues = new Stack<int>();
sValues.Push(1);
sValues.Push(2);
sValues.Push(3);
sValues.Push(4);

System.Console.WriteLine(sValues.Peek() ); //get 'top' value
System.Console.WriteLine(sValues.Peek() ); //get 'top' value

System.Console.WriteLine(sValues.Pop() ); //get and remove from stack
System.Console.WriteLine(sValues.Pop() ); //get and remove from stack

while(sValues.TryPop(out int val))
{
    System.Console.WriteLine(val);
}

var sw = new Stopwatch();
var largeArray = new string[10000000] ;
var largeList = new List<string>();
var largeHash = new HashSet<string>();
for(int i = 0; i < 10000000; i++)
{
    var value = $"string{i}";
    largeArray[i] = value;
    largeList.Add(value);
    largeHash.Add(value);
}

sw.Start();
var hashval = largeHash.Contains("string800000");
sw.Stop();
System.Console.WriteLine("Hash: " + sw.Elapsed);
sw.Reset();
sw.Start();
var listval = largeList.Contains("string800000");
sw.Stop();
System.Console.WriteLine("List: " + sw.Elapsed);
sw.Reset();
sw.Start();
var arrval = largeArray.Contains("string800000");
sw.Stop();
System.Console.WriteLine("List: " + sw.Elapsed);


//Linq

largeList.Where(x => x.Contains("800"));
largeList.First(x => x.Contains("800"));
largeList.First();
largeList.Last(x => x.Contains("800"));
largeList.Last();
largeList.Select(x => new {Name= x, Age = "hellp"});

//swapi get all people endpoint, use select for transfering from response model to your Result model
//swapi 'search' endpoint. Get all people, filter by Name using Where (or first)