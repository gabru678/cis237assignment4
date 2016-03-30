using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class GenericStack<K>
    {
        // Assign the variables that we will be using in the Linked List

        protected GenericNode<K> Head
        {
            get;
            set;
        }
        protected GenericNode<K> Tail
        {
            get;
            set;
        }
        protected GenericNode<K> Current
        {
            get;
            set;
        }

        // Dont forget the counter!
        protected int counter = 0;

        // Then assign them with a public constructor
        public GenericStack()
        {
            Head = null;
            Tail = null;
            Current = null;
        }

        public void Push(K contents)
        {
            GenericNode<K> oldfirst = Head;

            Head = new GenericNode<K>();

            Head.Data = contents;

            Head.Next = oldfirst;

            counter++;
        }

        public K Pop()
        {
            GenericNode<K> returnNode = Head;

            Head = Head.Next;

            if (Head == null)
            {
                Tail = null;
            }

            counter--;

            return returnNode.Data;
        }

    }
}
