using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    //Class Droid Collection implements the IDroidCollection interface.
    //All methods declared in the Interface must be implemented in this class 
    class DroidCollection : IDroidCollection
    {
        //Private variable to hold the collection of droids
        // changed to a IComparable
        private IComparable[] droidCollection;
        //Private variable to hold the length of the Collection
        private int lengthOfCollection;

        // also create an instance of the Merge Sort class to be used
        //MergeSort sortArray = new MergeSort();
        // welp NVM, gave build errors

        //Constructor that takes in the size of the collection.
        //It sets the size of the internal array that will be used.
        //It also sets the length of the collection to zero since nothing is added yet.
        public DroidCollection(int sizeOfCollection)
        {
            // This would be where to create a manual array of Droid
            // for testing

            //Make new array for the collection
            droidCollection = new IDroid[sizeOfCollection];
            //set length of collection to 0
            lengthOfCollection = 0;
        }

        //The Add method for a Protocol Droid. The parameters passed in match those needed for a protocol droid
        public bool Add(string Material, string Model, string Color, int NumberOfLanguages)
        {
            //If there is room to add the new droid
            if (lengthOfCollection < (droidCollection.Length - 1))
            {
                //Add the new droid. Note that the droidCollection is of type IDroid, but the droid being stored is
                //of type Protocol Droid. This is okay because of Polymorphism.
                droidCollection[lengthOfCollection] = new ProtocolDroid(Material, Model, Color, NumberOfLanguages);
                //Increase the length of the collection
                lengthOfCollection++;
                //return that it was successful
                return true;
            }
            //Else, there is no room for the droid
            else
            {
                //Return false
                return false;
            }

            // Remember to also add this droid to the LinkedList!
            // wait, to double check ask teacher, because
            // if done where I am doing it, it would just be done regardless?
            // only the completion of the Droid collection would seem to matter?
            // As that is our prevailing IF statement?
        }

        //The Add method for a Utility droid. Code is the same as the above method except for the type of droid being created.
        //The method can be redeclared as Add since it takes different parameters. This is called method overloading.
        public bool Add(string Material, string Model, string Color, bool HasToolBox, bool HasComputerConnection, bool HasArm)
        {
            if (lengthOfCollection < (droidCollection.Length - 1))
            {
                droidCollection[lengthOfCollection] = new UtilityDroid(Material, Model, Color, HasToolBox, HasComputerConnection, HasArm);
                lengthOfCollection++;
                return true;
            }
            else
            {
                return false;
            }

            // Remember to add this droid to the LinkedList!
            // wait, to double check ask teacher, because
            // if done where I am doing it, it would just be done regardless?
            // only the completion of the Droid collection would seem to matter?
            // As that is our prevailing IF statement?
        }

        //The Add method for a Janitor droid. Code is the same as the above method except for the type of droid being created.
        public bool Add(string Material, string Model, string Color, bool HasToolBox, bool HasComputerConnection, bool HasArm, bool HasTrashCompactor, bool HasVaccum)
        {
            if (lengthOfCollection < (droidCollection.Length - 1))
            {
                droidCollection[lengthOfCollection] = new JanitorDroid(Material, Model, Color, HasToolBox, HasComputerConnection, HasArm, HasTrashCompactor, HasVaccum);
                lengthOfCollection++;
                return true;
            }
            else
            {
                return false;
            }

            // Remember to add this droid to the LinkedList!
            // wait, to double check ask teacher, because
            // if done where I am doing it, it would just be done regardless?
            // only the completion of the Droid collection would seem to matter?
            // As that is our prevailing IF statement?
        }

        //The Add method for a Astromech droid. Code is the same as the above method except for the type of droid being created.
        public bool Add(string Material, string Model, string Color, bool HasToolBox, bool HasComputerConnection, bool HasArm, bool HasFireExtinguisher, int NumberOfShips)
        {
            if (lengthOfCollection < (droidCollection.Length - 1))
            {
                droidCollection[lengthOfCollection] = new AstromechDroid(Material, Model, Color, HasToolBox, HasComputerConnection, HasArm, HasFireExtinguisher, NumberOfShips);
                lengthOfCollection++;
                return true;
            }
            else
            {
                return false;
            }

            // Remember to add this droid to the LinkedList!
            // wait, to double check ask teacher, because
            // if done where I am doing it, it would just be done regardless?
            // only the completion of the Droid collection would seem to matter?
            // As that is our prevailing IF statement?
        }

        //The last method that must be implemented due to implementing the interface.
        //This method iterates through the list of droids and creates a printable string that could
        //be either printed to the screen, or sent to a file.
        public string GetPrintString()
        {
            //Declare the return string
            string returnString = "";

            // Temp IDroid here?  to hold the pulling from the list?

            // as in Idroid temp; ?

            //For each droid in the droidCollection

            // And the Linked List!  Add those things in here!


            foreach (IDroid droid in droidCollection)
            {
                //If the droid is not null (It might be since the array may not be full)
                if (droid != null)
                {
                    //Calculate the total cost of the droid. Since we are using inheritance and Polymorphism
                    //the program will automatically know which version of CalculateTotalCost it needs to call based
                    //on which particular type it is looking at during the foreach loop.
                    droid.CalculateTotalCost();
                    //Create the string now that the total cost has been calculated
                    returnString += "******************************" + Environment.NewLine;
                    returnString += droid.ToString() + Environment.NewLine + Environment.NewLine;
                    returnString += "Total Cost: " + droid.TotalCost.ToString("C") + Environment.NewLine;
                    returnString += "******************************" + Environment.NewLine;
                    returnString += Environment.NewLine;
                }

                // add the total cost methods for the LinkedList too!
                // and then print those out as a returnString
                // Use that previous temp for the DroidList.Retrieve(i); part
                // then call that temps calcucate total cost method
                // Then apply it to the above returnString output to the console!
            }

            //return the completed string
            //Keeping this!
            return returnString;
        }

        // This would be the method that sorts it?
        // like if its in a array already?
        // if so shouldnt this be in the interface already?
        // Will this require for a method to be overridden?
        public void BucketSortByModel()
        {
            // Add the code to sort the DroidCollection
            //But first create and use the Stacks and Queue's!

            GenericStack<ProtocolDroid> protocolStack = new GenericStack<ProtocolDroid>();
            GenericStack<UtilityDroid> utilityStack = new GenericStack<UtilityDroid>();
            GenericStack<JanitorDroid> JanitorStack = new GenericStack<JanitorDroid>();
            GenericStack<AstromechDroid> AstroStack = new GenericStack<AstromechDroid>();

            GenericQueue<IDroid> droidQueue = new GenericQueue<IDroid>();
            
            // then go through and sort them
            foreach (IDroid droid in droidCollection)
            {
                if ( droid != null)
                {
                    if ( droid is AstromechDroid)
                    {
                        droidQueue.Enqueue((AstromechDroid)droid);
                    }

                    else if ( droid is JanitorDroid)
                    {
                        droidQueue.Enqueue((JanitorDroid)droid);
                    }

                    else if ( droid is UtilityDroid)
                    {
                        droidQueue.Enqueue((UtilityDroid)droid);
                    }
                    
                    else if ( droid is ProtocolDroid)
                    {
                        droidQueue.Enqueue((ProtocolDroid)droid);
                    }
                }
                else
                {
                    break;
                }
            }


        }

        public void MergeSortByTotalCost()
        {
            // use an array that will be passed in
            // and create a IDroid droid that will be used
            // and will call the methods from ( Inheritance!)
   
            foreach(IDroid droid in droidCollection)
            {
                if ( droid != null)
                {
                    droid.CalculateTotalCost();
                }

                else
                {
                    break;
                }
            }

            MergeSort sortarray = new MergeSort(droidCollection);
        }


    }
}
