// IT Fdn Class Project Template.cs
// Write a program to keep track of some inventory items as shown below.
// Hint: when creating arrays, as you get or read items into
// your array, then initialize each array spot before its use
// and place a counter or use your own Mylength to keep track
// of your array length as it is used.

using System;
struct ItemData
{
    public int itemId;
    public string sDescription;
    public double dblPricePerItem;
    public int iQuantityOnHand;
    public double dblOurCostPerItem;
    public double dblValueOfItem;
}
class MyInventory
{
    public static void Main()
    {
        // use an integer to keep track of the count of items in your inventory	
        var numberofitems = 0;

        // create an array of your ItemData struct
        var itemdata = new ItemData[100];

        // use a never ending loop that shows the user what options they can select 
        // as long as no one Quits, continue the inventory update - See Session 7 0:43:00   
        while (true)
        {   // in that loop, show what user can select from the list         
            Console.WriteLine("\n\n1. Add an item");
            Console.WriteLine("2. Modify an item");
            Console.WriteLine("3. Delete an item");
            Console.WriteLine("4. List all items in the database (please give quantity)");
            Console.WriteLine("5. Quit \n");

            // read the user's input and then create what case it falls
            int optx = 4;
            Console.Write("Please enter a number:  ");
            string strx = Console.ReadLine();   // read user's input	
            optx = int.Parse(strx); // convert the given string to integer to match our case types shown below
            Console.WriteLine(); // provide an extra blank line on screen

            switch (optx)
            {
                case 1: // add an item to the list if this option is selected
                    {

                        Console.Write("Please enter item id :");
                        var itemid = Console.ReadLine();
                        var itemid2 = int.Parse(itemid);
                        Console.Write("Please enter description :");
                        var description = Console.ReadLine();
                        Console.Write("Please enter sell price/unit :");
                        var price = Console.ReadLine();
                        var price2 = double.Parse(price);
                        Console.Write("Please enter quantity :");
                        var quantity = Console.ReadLine();
                        var quantity2 = int.Parse(quantity);
                        Console.Write("Please enter cost/unit :");
                        var cost = Console.ReadLine();
                        var cost2 = double.Parse(cost);
                        // Always add the pet at the end of the array
                        itemdata[numberofitems].itemId = itemid2;
                        itemdata[numberofitems].sDescription = description;
                        itemdata[numberofitems].dblPricePerItem = price2;
                        itemdata[numberofitems].dblPricePerItem = quantity2;
                        itemdata[numberofitems].dblPricePerItem = cost2;
                        numberofitems++;
                        break;

                    }
                   
               case 2: //change items in the list if this option is selected  
                       //Session 7 0:46:00  need a forloop to find the item, when I find it need to change it
                       //
                   {
                       Console.Write("Please enter an item ID No:");
                       string strchgid = Console.ReadLine();
                       int chgid = int.Parse(strchgid);
                       bool fFound = false;

                       for (int x = 0; x < numberofitems; x++)
                       {
                           if (itemdata[x].itemId == chgid)
                           {
                               fFound = true;
                               // code to show what has to happen if the item in the list is found
                               // reset the count to show a new count for your list 
                               // (Note: your list is now increased by one item)
                           }
                       }

                       if (!fFound) // and if not found
                       {
                           Console.WriteLine("Item {0} not found", chgid);
                       }
                        break;
                   }
                   

                case 3: //delete items in the list if this option is selected
                        //Session 7 0:47:22 - find it (for loop), delete it, then resort the array
                        //when you take something out of the array, you need to make sure you resort the right way
                        //resort (shrinking) the array
                    {


                        if (numberofitems == 0)
                        {
                            Console.WriteLine("No items to delete");
                            break;
                        }
                        Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  Value");
                        Console.WriteLine("-----  ------  --------------------  -----  ---  ----  -----");


                        // code in this block. Use the above line format as a guide for printing or displaying the items in your list right under it
                        for (int index = 0; index < numberofitems; index++)
                        {
                            Console.WriteLine("{0}     {1}       {2}              {3}   {4}    {5}     {6}", index + 1, itemdata[index].itemId, itemdata[index].sDescription, itemdata[index].dblPricePerItem, itemdata[index].iQuantityOnHand, itemdata[index].dblOurCostPerItem, itemdata[index].dblValueOfItem);
                        }
                        Console.Write("\nPlease enter Item# to delete: )", numberofitems);
                        var itemNumberToDelete = Console.ReadLine();
                        var indexToDelete = int.Parse(itemNumberToDelete);
                        int newid = int.Parse(itemNumberToDelete);
                        bool fDeleted = false;
                        // Squish the array from index to the end
                        for (var index = indexToDelete - 1; index < numberofitems; index++)
                        {
                            // Just copy the item from the next index into the current index
                            itemdata[index] = itemdata[index + 1];
                        }
                        // We have one less item
                        numberofitems--;

                        {
                            Console.WriteLine("ITEM DELETED!");
                        }

                        break;

                    }
                
                case 4:  //list all items in current database if this option is selected
                    {
                        if (numberofitems == 0)
                        {
                            Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  Value");
                            Console.WriteLine("-----  ------  --------------------  -----  ---  ----  -----");

                            Console.WriteLine("\n    No items to delete");
                            break;
                        }
                        Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  Value");
                        Console.WriteLine("-----  ------  --------------------  -----  ---  ----  -----");


                        // code in this block. Use the above line format as a guide for printing or displaying the items in your list right under it
                        for (int index = 0; index < numberofitems; index++)
                        {
                            Console.WriteLine("{0}     {1}       {2}              {3}   {4}    {5}     {6}", index + 1, itemdata[index].itemId, itemdata[index].sDescription, itemdata[index].dblPricePerItem, itemdata[index].iQuantityOnHand, itemdata[index].dblOurCostPerItem, itemdata[index].dblValueOfItem);
                        }



                        break;
                    }


                case 5: //quit the program if this option is selected
                    {
                        Console.Write("Are you sure that you want to quit(y/n)?");
                        string strresp = Console.ReadLine();

                        if (strresp == "y")
                        {
                            Environment.Exit(0);
                            //optx = 0;	//as long as it is not 5, the process is not breaking	
                        }
                        break;
                    }

                default:
                    {
                        Console.Write("Invalid Option, try again");
                        break;
                    }
            }
        }
    }
}
