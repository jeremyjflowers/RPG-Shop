
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

3. Output Information
- The player selects an item from the shop based off the given input
- The player is asked where in their inventory do they want to store the recently purchased item
- The player is later asked if they want to continue buying items or save their game and leave

## Object Information

   **File** : Game.cs


 **Attributes**

         Name: Item
             Description: Defines the items
             Type:struct

         Name: name
             Description: The name of the items
             Type:string

         Name: cost
             Description: The price of the items
             Type:int

         Name: gameOver
             Description: Tells if the game has ended
             Type:bool

         Name: player
             Description: Defines the player instance
             Type:Player.cs

         Name: shop
             Description: Defines the shop instance
             Type:Shop.cs

         Name: bowAndarrows
             Description: Defines the bow and arrows using Item struct
             Type:GameObject

         Name: specialGem
             Description: Defines the special gem item using Item struct
             Type:GameObject

         Name: shortSword
             Description: Defines the short sword item using Item struct
             Type:GameObject

         Name: greatSword
             Description: Defines the great sword item using Item struct
             Type:GameObject

         Name: bombs
             Description: Defines the bomb item using Item struct
             Type:GameObject

         Name: shopInventory
             Description: Defines the shop's inventory
             Type:Shop.cs

         Name: Run()
             Description: Runs the game
             Type:void

         Name: Save()
             Description: Enables the save function for player instance
             Type:void

         Name: Load()
             Description: Enables the load function for player instance
             Type:void

         Name: IntializeItems()
             Description: Intializes the items
             Type:void

         Name: GetInput()
             Description: Grabs the player's input
             Type:void

         Name: PrintInventory()
             Description: Displays the inventory of a given array
             Type:void

         Name: OpenShopMenu()
             Description: Displays the menu of the shop
             Type:void

         Name: OpenMainMenu()
             Description: Displays the main menu of the game
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

         Name: name
             Description: Defines the name for the player class
             Type:string

         Name: gold
             Description: Defines the amount of gold for the player class
             Type:int

         Name: inventory
             Description: Defines the inventory array for the player class 
             Type:array

         Name: Player()
             Description: Defines the default player parameters
             Type:construct

         Name: Player(string nameVal, int goldVal)
             Description: Defines the overloaded player parameters
             Type:consrtuct

         Name: Buy(Item item, int inventoryIndex)
             Description: Allows player to buy items from shop and add them to their inventory
             Type:bool

         Name: GetGold()
             Description: Return the amount of gold the player has
             Type:int

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

