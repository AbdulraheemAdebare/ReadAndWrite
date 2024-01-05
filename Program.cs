// string readText = File.ReadAllText("data.txt");
// Console.WriteLine(readText);

// string writeText = "It's a new year!";
// File.WriteAllText("filename.txt", writeText);

// string writeAnotherText = "\nCompliments of the season.";
// File.AppendAllText("filename.txt", writeAnotherText);

// string reader = File.ReadAllText("filename.txt");
// Console.WriteLine(reader);

// using (StreamReader readFile = new("filename.txt"))
// {
//     string? read = readFile.ReadLine();
//     while(read is not null)
//     {
//         Console.WriteLine(read);
//         read = readFile.ReadLine();
//     }
// }

using System.Runtime.CompilerServices;

StreamReader readIt = new ("data.txt");
string? readAm = readIt.ReadLine();
while(readAm is not null)
{
    Console.WriteLine(readAm);
    readAm = readIt.ReadLine();
}
readIt.Close();

using (StreamWriter writeIt = new StreamWriter("Animal.txt"))
{
    string[] animals = {"Ram", "Camel", "Cow", "Goat", "Dog", "Cat"};
    foreach(var anim in animals)
    {
        writeIt.WriteLine(anim);
        
    } 
}

using(StreamReader readAnimal = new ("Animal.txt"))
{
    string? reader = readAnimal.ReadLine();
    while(reader is not null){
        Console.WriteLine(reader);
        reader = readAnimal.ReadLine();
    }
}