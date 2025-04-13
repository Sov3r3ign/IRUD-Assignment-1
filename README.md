# IRUD-Assignment-1
 SECTION 1: 
1.1 SCENARIO OVERVIEW
In a fantasy role-playing game (RPG), players take part in an evolving environment by taking on roles labelled ‘Travellers’, namely warriors, wizards, and assassins, each with special ways of moving. This scenario shows real-world gaming design principles, with programmers using object-oriented methods to enhance flexibility and maintenance.
The focal point of this is on the creation and movement of a character. Making different types of travellers is referred to as ‘Character Creation’. Walking, riding, or flying is the movement that covers how the travellers navigate. Each traveller’s behaviour can evolve and adapt throughout gameplay, which is crucial for real-time strategy or RPG.
Understanding the processes of ‘Character Creation’ and how they move is important to successfully handle questions about character generation and interactions with the environment.

1.2.1 FACTORY PATTERN
The factory method pattern is a design pattern that allows for the creation of objects without specifying the type of object that is to be created in code. It rationalizes the creation of different types of travellers. Factory classes (KnightFactory, MageFactory, and RogueFactory) take care of creating traveller subclasses instead of creating them directly in the main application. This makes it easier to add newer types and makes the code look clean.
The factory method simplifies traveller creation by concealing construction details. It allows easy growth with little changes to the main code. It also aids polymorphism, as the factories produce objects of a common superclass (Traveler), making interchange simple.

1.2.2 STRATEGY PATTERN
The strategy pattern is a design pattern that allows a set of similar algorithms to be defined and encapsulated in their own classes. It is in charge of how each traveller moves by using distinct movement strategies (like walking, flying, and riding a horse) that follow the Travel abstract class.
This approach allows travellers to change their movement style whenever they want (for example, a warrior can choose to ride a horse or walk). The separation of ways to travel from travel attributes keeps the code clean. The same movement strategy can be easily shared by different travellers.


 

