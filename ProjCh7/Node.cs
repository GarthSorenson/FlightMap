// Node.cs contains a Node class for referenced based implementations
// of List and Stack.
// Created by Garth Sorenson
// 12 Sep 2021
// Edited 11 Oct 2022

using System;

namespace ProjCh7
{
    class Node
    {
        private City item;
        private Node next;
        public City Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
            }
        }

        public Node Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }

        public Node(City newItem)
        {
            item = newItem;
            next = null;
        }

        public Node(City newItem, Node nextNode)
        {
            item = newItem;
            next = nextNode;
        }

    }
}
