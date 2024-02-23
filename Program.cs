namespace AnimalInheritance;

// base Class 
class Animal
{
    private string name; // only accessible within this class
    protected string type; //accessible from derived classes
    public string color;  // accessible from any class

    public void setName(string name)
    {
        this.name = name;
    }
    public virtual string getName()
    {
        return this.name;
    }
    public void setType(string type)
    {
        this.type = type;
    }
    public virtual string getType()
    {
        return this.type;
    }
}

class Rabbit : Animal
{
    private int numberOfEars;
    public bool isFluffy;
    protected string favoriteFood;

    // Constructor for Rabbit class
    public Rabbit(string name, string type, string color, int numberOfEars, bool isFluffy, string favoriteFood)
    {
        setName(name);
        setType(type);
        this.color = color;
        this.numberOfEars = numberOfEars;
        this.isFluffy = isFluffy;
        this.favoriteFood = favoriteFood;
    }

    // Method to get the number of ears
    public int getNumberOfEars()
    {
        return numberOfEars;
    }

    // Method to set the number of ears
    public void setNumberOfEars(int ears)
    {
        numberOfEars = ears;
    }

    // Method to get the favorite food
    public string getFavoriteFood()
    {
        return favoriteFood;
    }

    // Method to set the favorite food
    public void setFavoriteFood(string food)
    {
        favoriteFood = food;
    }

    // Override the base class method for getting the name
    public override string getName()
    {
        return "Rabbit Name: " + base.getName();
    }

    // Override the base class method for getting the type
    public override string getType()
    {
        return "Rabbit Type: " + base.getType();
    }
}

class Program
{
    static void Main()
    {
        // Creating an object from the base class (Animal)
        Animal animalObj = new Animal();
        animalObj.setName("Generic Animal");
        animalObj.setType("Generic Type");
        animalObj.color = "Brown";

        // Displaying data from the base class object
        Console.WriteLine("Base Class Data:");
        Console.WriteLine("Name: " + animalObj.getName());
        Console.WriteLine("Type: " + animalObj.getType());
        Console.WriteLine("Color: " + animalObj.color);
        Console.WriteLine();

        // Creating an object from the derived class (Rabbit)
        Rabbit rabbitObj = new Rabbit("Bugs", "Domestic", "White", 2, true, "Carrots");

        // Displaying data from the derived class object
        Console.WriteLine("Derived Class Data:");
        Console.WriteLine(rabbitObj.getName());
        Console.WriteLine(rabbitObj.getType());
        Console.WriteLine("Color: " + rabbitObj.color);
        Console.WriteLine("Number of Ears: " + rabbitObj.getNumberOfEars());
        Console.WriteLine("Is Fluffy: " + rabbitObj.isFluffy);
        Console.WriteLine("Favorite Food: " + rabbitObj.getFavoriteFood());
    }
}