// StackInterface.cs contains code from the Java textbook by Carrano.
// Translated to C# by Garth Sorenson
// 4 Oct 2021

using System;
using System.Collections.Generic;
using System.Text;

namespace ProjCh7
{
    public class StackException : System.Exception
    {
        public StackException(String s) : base(s)
        {
        }  // end constructor
    }  // end StackException


    interface StackInterface
    {
        public bool isEmpty();
        // Determines whether the stack is empty.
        // Precondition: None.
        // Postcondition: Returns true if the stack is empty;
        // otherwise returns false.

        public void popAll();
        // Removes all the items from the stack.
        // Precondition: None.
        // Postcondition: Stack is empty.

        public void push(City newItem);
        // Adds an item to the top of a stack.
        // Precondition: newItem is the item to be added.
        // Postcondition: If insertion is successful, newItem
        // is on the top of the stack.
        // Exception: Some implementations may throw
        // StackException when newItem cannot be placed on
        // the stack.

        public City pop();
        // Removes the top of a stack.
        // Precondition: None.
        // Postcondition: If the stack is not empty, the item
        // that was added most recently is removed from the
        // stack and returned.
        // Exception: Throws StackException if the stack is
        // empty.

        public City peek();
        // Retrieves the top of a stack.
        // Precondition: None.
        // Postcondition: If the stack is not empty, the item
        // that was added most recently is returned. The
        // stack is unchanged.
        // Exception: Throws StackException if the stack is
        // empty.
    }
}
