// ListInterface.cs contains code from the Java textbook by Carrano.
// Translated to C# by Garth Sorenson
// 15 Sep 2021

using System;


namespace ProjCh7
{
    public class ListIndexOutOfBoundsException : System.Exception
    {
        public ListIndexOutOfBoundsException(String s) : base(s)
        {
        }  // end constructor
    }  // end ListIndexOutOfBoundsException

    interface ListInterface
    {
        public bool isEmpty();
        public int size();
        public void add(int index, City item);
        public Object get(int index);
        public void remove(int index);
        public void removeAll();

    }
}