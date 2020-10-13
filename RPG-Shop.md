
| **Jeremy J. Flowers**|
| :---                     |
| s208044              |
| Intro To C# |
| RPG Shop Documentation |

## I. Requirements

 1. Description of the Problem

     - **Name**: IntroToC# Project

     - **Problem Statement**:
     Creation of an application in C# that demonstrates foundational data
structures and file handling.

     - **Problem Specifications**:
     An application or game that must demostrate components implemented in the C# programming language such as the use of variables, operators, expressions, 
     use of sequester, selection and iteration, functions, use of arrays to store primitive or custom data types, reading and writing to a text file, 
     two classes, multiple options for object construction, user-defined aggregation, use of polymorphism, and code documentation.


2. Input Information
- Key 1 - Enables the choice of option 1
- Key 2 - Enables the choice of option 2
- Key 3 - Enables the choice of option 3
- Key 4 - Enables the choice of option 4
- Key 5 - Enables the choice of option 5
- Key 6 - Enables the choice of option 6
- Key 7 - Enables the choice of option 7
- Key 8 - Enables the choice of option 8
- Key 9 - Enables the choice of option 9

3. Output Information
- The player selects an item from the shop based off the given input
- The player is asked where in their inventory do they want to store the recently purchased item
- The player is later asked if they want to continue buying items or save their game and leave

## Object Information

   **File** : Character.cs


 **Attributes**

         Name: name
             Description: Defines the name parameter of the character class
             Type:string

         Name: health
             Description: Defines the health parameter of the character class
             Type:float

         Name: baseDamage
             Description: Defines the damage parameter of the character class
             Type:int

         Name: level
             Description: Defines the level parameter of the charcater class
             Type:float

         Name: EXP
             Description: Defines the exp parameter of the character class
             Type:int

         Name: Character()
             Description: Defines the default comstruct of Character 
             Type:construct

         Name: Character(string nameVal, float healthVal, int damageVal; float levelVal)
             Description: Defines the overloaded construct of Character
             Type:construct

         Name: Attack(Character enemy)
             Description: Enables the attack for the Character class
             Type:virtual float

         Name: TakeDamage(int damageVal)
             Description: Enables the Character class to take damage from enemies
             Type:virtual float

         Name: LevelUp(float level, int EXP)
             Description: Allows the player to increase their levels
             Type:void

         Name: UpgradeStats(float health, int baseDamage)
             Description: Allows the player to increase their stats after they level up
             Type:void

         Name: GainEXP
             Description: Allows the player to gain EXP after every battle 
             Type:float

         Name: GetIsAlive()
             Description: Checks to see if the player's health is more than zero
             Type:bool

         Name: GetNmae()
             Description: Grabs the player's name when called
             Type:string

         Name: Save(StreamWriter writer)
             Description: Saves the player's current stats
             Type:virtual void

         Name: Load(StreamReader reader)
             Description: Loads the player's recently saved stats
             Type:virtual bool

   **File** : Game.cs


 **Attributes**

         Name: 
             Description: 
             Type:

         Name: Item
             Description: Defines the items
             Type:struct

         Name: name
             Description: The name of the items
             Type:string

         Name: statBoost
             Description: The damage multiplier of the item 
             Type:

         Name: cost
             Description: The price of the items
             Type:int

         Name: gameOver
             Description: Tells if the game has ended
             Type:bool

         Name: player1
             Description: Defines the player instance
             Type:Player.cs

         Name: enemy1
             Description: Defines the first enemy instance 
             Type:Character.cs

         Name: enemy2
             Description: Defines the second enemy instance 
             Type:Character.cs

         Name: enemy3
             Description: Defines the third enemy instance 
             Type:Character.cs

         Name: enemy4
             Description: Defines the fourth enemy instance
             Type:Character.cs

         Name: enemy5
             Description: Defines the fifth enemy instance
             Type:Character.cs

         Name: shop
             Description: Defines the shop instance
             Type:Shop.cs

         Name: battleShield
             Description: Defines the shield item using Item struct
             Type:GameObject

         Name: armour
             Description: Defines the armour item using Item struct
             Type:GameObject

         Name: babyDragon
             Description: Defines the babyDragon item using Item struct
             Type:GameObject

         Name: cursedSword
             Description: Defines the cursed sword item using Item struct
             Type:GameObject

         Name: woodenBow
             Description: Defines the bow and arrow item using Item struct
             Type:GameObject

         Name: broadSword
             Description: Defines the broad sword item using the Item struct 
             Type:GameObject

         Name: dagger
             Description: Defines the dagger item using the Item struct 
             Type:GameObject

         Name: demonicGauntlets
             Description: Defines the demonic gauntlets item using the Item struct
             Type:GameObject

         Name: dualBlades
             Description: Defines the twin blades item using the Item struct
             Type:GameObject

         Name: shopInventory
             Description: Defines the shop's inventory
             Type:Shop.cs

         Name: Run()
             Description: Runs the game
             Type:void

         Name: GetInput(out char input, string option1, string option2, string query)
             Description: Displays query with 2 options and grabs player's input
             Type:void

         Name: GetInput(out char input, string option1, string option2, string option3, string query)
             Description: Displays query with 3 options and grabs player's input
             Type:void

         Name: ClearScreen()
             Description: Clears the screen by giving the player a command prompt
             Type:void

         Name: ShowInventory(Item[] inventory)
             Description: Displays the inventory array of a given parameter
             Type:void

         Name: Save()
             Description: Enables the save function for player instance
             Type:void

         Name: Load()
             Description: Enables the load function for player instance
             Type:void

         Name: IntializeItems()
             Description: Intializes the items for the game
             Type:void

         Name: IntializeEnemies(Character enemy)
             Description: Enables the enemies of the game
             Type:void

         Name: CreateCharacter()
             Description: Enables the creation of the player's character
             Type:void

         Name: SwapEquipment(Player player)
             Description: Allows the player to swap equipment in the player's inventory
             Type:void

         Name: OpenMainMenu()
             Description: Displays the main menu of the game
             Type:void

         Name: Explore
             Description: Allows the player to choose what they want to do 
             Type:void

         Name: BattleStart(Player player, Character enemy)
             Description: Starts a battle between the player and the enemies
             Type:void

         Name: ShopMenu(Shop shop)
             Description: Displays the shop menu for the player
             Type:void

         Name: Start()
             Description: Performed once when the game begins
             Type:void

         Name: Update()
             Description: Repeated until the game ends
             Type:void

         Name: End()
             Description: Performed once when the game ends
             Type:void

**File** : Player.cs

**Attributes**

         Name: gold
             Description: Defines the amount of gold for the player class
             Type:int

         Name: inventory
             Description: Defines the inventory array for the player class 
             Type:array

         Name: Player()
             Description: Defines the default player parameters with inheirtance of the Character class
             Type:construct

         Name: Player(float goldVal)
             Description: Defines the overloaded player parameters with the inheirtance of the Character class
             Type:consrtuct

         Name: AddToInventory(Item item, playerIndex)
             Description: Adds items bought from the shop into the player's inventory
             Type:void

         Name: Contains(int playerIndex)
             Description: Checks to see if an item is within the player's inventory
             Type:void

         Name: EquipEquipment(int playerIndex)
             Description: Swaps the player's current equipped item out with a new item
             Type:void

         Name: Attack
             Description: Allows the player to attack with the damage multiplier of the items
             Type:override void

         Name: Buy(Item item, int inventoryIndex)
             Description: Allows player to buy items from shop and add them to their inventory
             Type:bool

         Name: GetGold()
             Description: Return the amount of gold the player has
             Type:float

         Name: gainedGold()
             Description: Gives the player a set amount of gold after finishing a battle
             Type:float

         Name: Save(StreamWriter writer)
             Description: Saves the player's name and gold
             Type:virtual void

         Name: Load(StreamReader reader)
             Description: Loads the player's recent data
             Type:virtual bool

**File** : Shop.cs

**Attributes**

         Name: gold
             Description: Defines the amount of gold for the shop class
             Type:int

         Name: inventory
             Description: Defines the inventory array for the shop class
             Type:array

         Name: Shop()
             Description: Defines the default parameters of a shop
             Type:construct

         Name: Shop (Item[] items)
             Description: Defines the overloaded parameters of a shop
             Type:construct

         Name: Sell(Player player, int itemIndex, int playerIndex)
             Description: Allows the shop to sell the selected item to the player
             Type:bool

