using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    //Interface that I added to declare what methods MUST be implemeted in any class that implements this interface.
    interface IDroidCollection
    {
        //Various overloaded Add methods to add a new droid to the collection
        bool Add(string Material, string Model, string Color, int NumberOfLanguages);
        bool Add(string Material, string Model, string Color, bool HasToolBox, bool HasComputerConnection, bool HasArm);
        bool Add(string Material, string Model, string Color, bool HasToolBox, bool HasComputerConnection, bool HasArm, bool HasTrashCompactor, bool HasVaccum);
        bool Add(string Material, string Model, string Color, bool HasToolBox, bool HasComputerConnection, bool HasArm, bool HasFireExtinguisher, int NumberOfShips);
        
        //Method to get the data for a droid into a nicely formated string that can be output.
        string GetPrintString();

        // The other collection will need to implement these too!
        // So if they are created here the Droid collection that interfaces this
        // Is going to need to define these methods
        // So do the code over there
        // because then we would be able to define the code if we were to
        // add another method or something in the future
        // but would we need to change the code in the interface first too?
        // otherwise it wouldnt be Abstract, and arent they by default sealed?S
        void BucketSortByModel();

        void MergeSortByTotalCost();
    }
}
