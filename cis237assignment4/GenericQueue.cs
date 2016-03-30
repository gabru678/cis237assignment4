using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericQueue<K>
    {
        public GenericNode<K> Head
        {
            get;
            set;
        }
        public GenericNode<K> Tail
        {
            get;
            set;
        }

        public GenericNode<K> Current
        {
            // But are we even going to use this?
            // if all we need to make methods for are
            // adding and dropping from the Queue?
            get;
            set;
        }

        // gonna make an Int variable just in case
        protected int count = 0;


        // Again a regular public constructor
        public GenericQueue()
        {
            Head = null;
            Tail = null;
            Current = null;
        }

        // Public method to add ( or enqueue ) to the queue
        public void Enqueue(K stuff)
        {
            GenericNode<K> node = new GenericNode<K>();
            node.Data = stuff;

            if (Head == null)
            {
                Head = node;
                // are these really necessary?
                Tail = node;
                Tail.Next = null;
            }

            else
            {
                Tail.Next = node;
                Tail = node;
                Tail.Next = null;
            }
            count++;
        }

        // Now a method to dequeue or (pop) off the quesue
        public K DeQueue()
        {
            GenericNode<K> returnNode = Head;

            Head = Head.Next;

            if ( Head == null)
            {
                Console.WriteLine("Sorry nothing was in the Queue, and this opperation could not be performed.");
                Tail = null;
            }

            count--;

            return returnNode.Data;
        }
    }
}
