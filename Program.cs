// See https://aka.ms/new-console-template for more information
//=====Three Basic Arrays========
int [] arr1 = {0,1,2,3,4,5,6,7,8,9};

string [] arr2 = {"Tim", "Martin", "Nikki", "Sara"};

bool [] arr3 = new bool[10];

for (int i = 0; i < arr3.Length; i++)
{
    if(i % 2 == 0)
    {
        arr3[i] = true;
    }
    else
    {
        arr3[i] = false;
    }
}

// foreach(var value in arr3){
//     Console.WriteLine(value);
// }

//=======List of Flavors======

List<string> list1 = new List<string>();
list1.Add("Cookie and Cream");
list1.Add("Strawberry");
list1.Add("Chocolate");
list1.Add("Vanilla");
list1.Add("Matcha");

// foreach(var value in list1){
//     Console.WriteLine(value);
// }

Console.WriteLine(list1.Count);
Console.WriteLine(list1[2]);
list1.Remove("Chocolate");
Console.WriteLine(list1.Count);

// ======User Dictionary=====
Dictionary<string, string> dict1 = new Dictionary<string, string>();

Random rand = new Random();

foreach(var name in arr2){
    dict1.Add(name, list1[rand.Next(0,4)]);
}

foreach(KeyValuePair<string,string> entry in dict1)
{
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}