// IT Fdn Class Project Template.cs
// Write a program to keep track of some inventory items as shown below.
// Hint: when creating arrays, as you get or read items into
// your array, then initialize each array spot before its use
// and place a counter or use your own Mylength to keep track
// of your array length as it is used.

using System;
struct ItemData
{
    public int itemNo;
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

        // create an array of your ItemData struct
        ItemData[] itemdata = new ItemData[100];  //array of struct
        itemdata[0].itemNo = 1;
        itemdata[0].itemId = 234;
        itemdata[0].sDescription = "bananas";
        itemdata[0].dblPricePerItem = 0.99;
        itemdata[0].itemNo = 2;
        itemdata[0].itemId = 345;
        itemdata[1].sDescription = "oranges";
        itemdata[1].dblPricePerItem = 1.99;

        // use a never ending loop that shows the user what options they can select    
        while (true)
        {
            Console.WriteLine("\n\n1. Add an item");
            Console.WriteLine("2. Modify an item");
            Console.WriteLine("3. Delete an item");
            Console.WriteLine("4. List all items in the database (please give quantity)");
            Console.WriteLine("5. Quit \n");

            // as long as no one Quits, continue the inventory update - See Session 7 0:43:00


            // in that loop, show what user can select from the list

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
                        int rx1 = 0;
                        Console.Write("Please enter item ID:  ");
                        string r1 = Console.ReadLine();
                        //itemdata = int.Parse(r1);

                        int rx2 = 0;
                        Console.Write("Please enter item no:  ");
                        string r2 = Console.ReadLine();
                        rx2 = int.Parse(r2);

                        int rx3 = 0;
                        Console.Write("Please enter description:  ");
                        string r3 = Console.ReadLine();
                        rx3 = int.Parse(r3);

                        int rx4 = 0;
                        Console.Write("Please enter price:  ");
                        string r4 = Console.ReadLine();
                        rx4 = int.Parse(r4);

                        int rx5 = 0;
                        Console.Write("Please enter quantity:  ");
                        string r5 = Console.ReadLine();
                        rx5 = int.Parse(r5);

                        int rx6 = 0;
                        Console.Write("Please enter cost:  ");
                        string r6 = Console.ReadLine();
                        rx6 = int.Parse(r6);

                        int rx7 = 0;
                        Console.Write("Please enter cost:  ");
                        string r7 = Console.ReadLine();
                        rx7 = int.Parse(r6);

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

                        /*for (int x = 0; x < icount; x++)
                        {
                            if (itemprop[x].itemIDNo == chgid)
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
                        */
                        break;
                    }

                case 3: //delete items in the list if this option is selected
                        //Session 7 0:47:22 - find it (for loop), delete it, then resort the array
                        //when you take something out of the array, you need to make sure you resort the right way
                        //resort (shrinking) the array
                    {
                        Console.Write("Please enter an item ID No:");
                        string strnewid = Console.ReadLine();
                        int newid = int.Parse(strnewid);
                        bool fDeleted = false;

                        /*for (int x = 0; x < icount; x++)
                        {
                            if (itemprop[x].itemIDNo == newid)
                            {
                                fDeleted = true;
                                // delete the item if you found it
                                // reset the count to show a new count for your list 
                                //(Note: your list is now reduced by one item)								
                            }
                        }

                        if (fDeleted) // hint the user that you deleted the requested item
                        {
                            Console.WriteLine("Item deleted");
                        }
                        else // if did not find it, hint the user that you did not find it in your list
                        {
                            Console.WriteLine("Item {0} not found", newid);
                        }*/

                        break;
                    }

                case 4:  //list all items in current database if this option is selected
                    {
                        Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  Value");
                        Console.WriteLine("-----  ------  --------------------  -----  ---  ----  -----");


                        // code in this block. Use the above line format as a guide for printing or displaying the items in your list right under it

                        foreach (ItemData id in itemdata)
                        {
                            Console.WriteLine("{0}     {1}      {2}               {3}   {4}    {5}     {6}", id.itemNo, id.itemId, id.sDescription, id.dblPricePerItem, id.iQuantityOnHand, id.dblOurCostPerItem, id.dblValueOfItem);
                        }
                        break;
                    }


                case 5: //quit the program if this option is selected
                    {
                        Console.Write("Are you sure that you want to quit(y/n)?");
                        string strresp = Console.ReadLine();

                        /*if (// code )
                        {
                            optx = 0;	//as long as it is not 5, the process is not breaking	
                        }*/
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
