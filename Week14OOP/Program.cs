using System.Data.Common;

Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName);
Dog neighboursDog = new Dog("Good girl");


Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}.");

myDog.Rename("Bad Boy");

while (myDog.LevelOfHapiness != 5)
{
    myDog.Bark();
}

myDog.WagTail();
class Dog
{
    private string _name;
    private int _levelOfHapiness;

    //contructor
    public Dog(string name)
    {
       _name= name;
       _levelOfHapiness = 0;
    }
    public string Name
    {
        get { return _name; }
    }
    public int LevelOfHapiness
    {
        get { return _levelOfHapiness;}
    }
    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog been renamed to {newName}.");
    }
    public void Bark() 
    {
        Console.WriteLine("Woof-woof!");
        _levelOfHapiness++;
    }
    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }
}