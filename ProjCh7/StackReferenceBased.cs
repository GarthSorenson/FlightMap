// StackReferencedBased.cs contains code from the Java textbook by Carrano.
// Translated to C# by Garth Sorenson
// 4 Oct 2021

using System;

namespace ProjCh7
{
    class StackReferenceBased : StackInterface
    {
        private Node top;

        public StackReferenceBased()
        {
            top = null;
        }  // end default constructor

        public bool isEmpty()
        {
            return top == null;
        }  // end isEmpty

        public void push(City newItem)
        {
            top = new Node(newItem, top);
        }  // end push

        public City pop()
        {
            if (!isEmpty()) {
                Node temp = top;
                top = top.Next;
                return temp.Item;
            }
            else {
                throw new StackException("StackException on " + "pop: stack empty");
            }  // end if
        }  // end pop

        public void popAll()
        {
            top = null;
        }  // end popAll

        public City peek()
        {
            if (!isEmpty()) {
                return top.Item;
            }
            else {
                throw new StackException("StackException on " +
                                 "peek: stack empty");
            }  // end if
        }  // end peek
    }
}
