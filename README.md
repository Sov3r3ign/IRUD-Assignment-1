# IRUD-Assignment-1

<h2>SECTION 1:</h2>
 
<h3> 1.1 SCENARIO OVERVIEW 🧙‍♂️⚔️🗡️🌍</h3>

In a fantasy role-playing game (RPG), players take part in an evolving environment by taking on roles labelled ‘Travellers’, namely warriors, wizards, and assassins, each with special ways of moving. This scenario shows real-world gaming design principles, with programmers using object-oriented methods to enhance flexibility and maintenance.🔄
The focal point of this is on the creation and movement of a character. Making different types of travellers is referred to as ‘Character Creation’. Walking, riding, or flying is the movement that covers how the travellers navigate. Each traveller’s behaviour can evolve and adapt throughout gameplay, which is crucial for real-time strategy or RPG.
Understanding the processes of ‘Character Creation’ and how they move is important to successfully handle questions about character generation and interactions with the environment.

<h3> 1.2.1 FACTORY PATTERN 🏭👤 </h3>
The factory method pattern is a design pattern that allows for the creation of objects without specifying the type of object that is to be created in code. It rationalizes the creation of different types of travellers. Factory classes <b>(KnightFactory, MageFactory, and RogueFactory)</b> take care of creating traveller subclasses instead of creating them directly in the main application. This makes it easier to add newer types and makes the code look clean.
The factory method simplifies traveller creation by concealing construction details. It allows easy growth with little changes to the main code. It also aids polymorphism, as the factories produce objects of a common superclass (Traveler), making interchange simple.

<h3> 1.2.2 STRATEGY PATTERN 🧠📜🐎 </h3>
The strategy pattern is a design pattern that allows a set of similar algorithms to be defined and encapsulated in their own classes. It is in charge of how each traveller moves by using distinct movement strategies (like walking, flying, and riding a horse) that follow the Travel abstract class.
This approach allows travellers to change their movement style whenever they want (for example, a warrior can choose to ride a horse or walk). The separation of ways to travel from travel attributes keeps the code clean. The same movement strategy can be easily shared by different travellers.

<h3> 1.3 CLASS DIAGRAM 📊📐🧾 </h3>




 ![Image](https://github.com/user-attachments/assets/154ade8c-629d-40a8-898c-81fc7ed79772)




SECTION 2
2.1 TRAVELER

class Traveler
{

    public Travel travelling;
    private string Name;
    public Traveler(string name)
    {
        this.Name = name;
    }
    public Traveler(Travel travelling)
    {
        this.travelling = travelling;
    }
    public void ChangeRoute(Travel strategy)
    {
        travelling = strategy;
    }
    public void Journeying()
    {
        Console.WriteLine(travelling.Move(Name));
    }
    
}
2.2 

TRAVELERFACTORY

abstract class TravelerFactory
{

    public abstract Traveler makingTraveler(string name);
    
}
2.3
TRAVEL
abstract class Travel
{

    public abstract string Move(string name);
    
}
2.4
WIZARD

class Wizard : Traveler
{

   public Wizard(string name) : base(name)
   {
   
       travelling = new Fly();
       
   }
   
}

2.5
WARRIOR

class Warrior : Traveler
{

    public Warrior(string name) : base(name)
    {
        travelling = new Horse();
    }
    
}
2.6 
ASSASSIN
class Assassin : Traveler
{

    public Assassin(string name) : base(name)
    {
        travelling = new Walk();
    }
    
}
2.7 
MAGEFACTORY
class MageFactory : TravelerFactory
{

    public override Traveler makingTraveler(string name)
    {
        return new Wizard(name);
    }
    
}
2.8 
KNIGHTFACTORY
class KnightFactory : TravelerFactory
{

    public override Traveler makingTraveler(string name)
    {
        return new Warrior(name);
    }
    
}
2.9
ROGUEFACTORY
class RogueFactory : TravelerFactory
{

    public override Traveler makingTraveler(string name)
    {
        return new Assassin(name);
    }
    
}
2.10 
FLY
class Fly : Travel
{

    public override string Move(string name)
    {
        return $"{name} is soaring through the skies";
    }
    
}
2.11
HORSE
class Horse : Travel
{

    public override string Move(string name)
    {
        return $"{name} is galloping on a horse through the forest.";
    }
    
}
2.12
WALK
class Walk : Travel
{

    public override string Move(string name)
    {
        return $"{name} is manuevering through the forest.";
    }
    
}


SECTION 3

2.13 PROGRAM

class Program
{

    static void Main(string[] args)
    {
        TravelerFactory wizarding = new MageFactory();
        Traveler merlin = wizarding.makingTraveler("Merlin");
        merlin.Journeying();
        Console.WriteLine();
        TravelerFactory warrior = new KnightFactory();
        Traveler sove = warrior.makingTraveler("Sovereign");
        sove.Journeying();
        Console.WriteLine();
        TravelerFactory assassin = new RogueFactory();
        Traveler robin = assassin.makingTraveler("Robin");
        robin.Journeying();

        Console.WriteLine();
        merlin.ChangeRoute(new Walk());
        merlin.Journeying();
        Console.ReadLine();
    }
    
}

<h3> CONCLUSION </h3>
This scenario shows the use factory pattern and the strategy pattern in game development. A flexible method of creating characters is offered by the factory pattern, whereas the strategy pattern focuses on the characters’ behaviour in its environment. By diving the creation of a character from its behaviour, this approach enhances testing and maintenance, reflecting important qualities for advanced software design in gaming.



 

