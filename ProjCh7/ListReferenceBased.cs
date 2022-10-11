using System;
using System.Collections.Generic;
using System.Text;

namespace ProjCh7
{
    class ListReferenceBased : ListInterface
    {
        // reference to linked list of items
        private Node head;
        private int numItems; // number of items in list

        // definitions of constructors and methods

        public ListReferenceBased()
        {
            numItems = 0;
            head = null;
        }  // end default constructor

        public bool isEmpty()
        {
            return numItems == 0;
        }  // end isEmpty

        public int size()
        {
            return numItems;
        }  // end size

        private Node find(int index)
        {
            // --------------------------------------------------
            // Locates a specified node in a linked list.
            // Precondition: index is the number of the desired
            // node. Assumes that 1 <= index <= numItems+1
            // Postcondition: Returns a reference to the desired
            // node.
            // --------------------------------------------------
            Node curr = head;
            for (int skip = 0; skip < index; skip++)
            {
                curr = curr.Next;
            } // end for
            return curr;
        } // end find

        public City get(int index)
        {
            if (index >= 0 && index < numItems)
            {
                // get reference to node, then data in node
                Node curr = find(index);
                Object dataItem = curr.Item;
                return dataItem;
            }
            else
            {
                throw new ListIndexOutOfBoundsException(
                                       "List index out of bounds on get");
            } // end if
        } // end get

        public void add(int index, City item)
        {
            if (index >= 0 && index < numItems + 1)
            {
                if (index == 0)
                {
                    // insert the new node containing item at
                    // beginning of list
                    Node newNode = new Node(item, head);
                    head = newNode;
                }
                else
                {
                    Node prev = find(index - 1);

                    // insert the new node containing item after
                    // the node that prev references
                    Node newNode = new Node(item, prev.Next);
                    prev.Next = newNode;
                } // end if
                numItems++;
            }
            else
            {
                throw new ListIndexOutOfBoundsException(
                                       "List index out of bounds on add");
            } // end if
        }  // end add

        public void remove(int index)
        {
            if (index >= 0 && index < numItems)
            {
                if (index == 0)
                {
                    // delete the first node from the list
                    head = head.Next;
                }
                else
                {
                    Node prev = find(index - 1);
                    // delete the node after the node that prev
                    // references, save reference to node
                    Node curr = prev.Next;
                    prev.Next = curr.Next;
                } // end if
                numItems--;
            } // end if
            else
            {
                throw new ListIndexOutOfBoundsException(
                              "List index out of bounds on remove");
            } // end if
        }  // end remove

        public void removeAll()
        {
            // setting head to null causes list to be
            // unreachable and thus marked for garbage
            // collection
            head = null;
            numItems = 0;
        }
    }
}
