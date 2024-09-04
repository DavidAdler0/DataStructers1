using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp2
{
    internal class Node
    {
        public int Value;
        public Node Next;
        public Node(int data)
        {
            Value = data;
            Next = null;
        }
        public int GetValue()
        {
            return Value;
        }
        public Node GetNext()
        {
            return Next;
        }

        public void SetValue(int value)
        {
            Value = value;
        }
        public void SetNext(Node node)
        {
            Next = node;
        }
    }
    internal class LinkedList
    {
        Node Head = null;
        public LinkedList() { }
        public LinkedList(int data)
        {
            Node node = new Node(data);
            Head = node;
        }
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Head != null)
            {
                Node pointer = Head;
                while (pointer.Next != null)
                {
                    pointer = pointer.Next;
                }
                pointer.Next = newNode;
                return;

            }
            Head = newNode;
        }
        public string Display()
        {

            if (Head != null)
            {
                string listToString = Head.Value.ToString();
                Node pointer = Head;

                while (pointer.Next != null)
                {
                    pointer = pointer.Next;
                    listToString += " -> " + pointer.Value.ToString();
                }
                return listToString;
            }
            throw new Exception("List is empty");
        }
        public int Length()
        {
            Node pointer = Head;
            int length = 0;
            while (pointer != null)
            {
                pointer = pointer.Next;
                length++;
            }
            return length;

        }
        public void RemoveValue(int data)
        {
            if (Head != null)
            {
                if (Head.Next == null && Head.Value == data)
                {
                    Head = null;
                    return;
                }
                Node pointer = Head;
                while (pointer.Next != null)
                {
                    if (pointer.Next.Value == data)
                    {
                        if(pointer.Next.Next != null)
                        {
                            pointer.Next = pointer.Next.Next;
                            return;
                        }
                        pointer.Next = null;
                        return ;
                    }
                    pointer = pointer.Next;
                }
            }
            throw new Exception("List is empty");


        }
        public void RemoveAllValues(int data)
        {

            while (Head != null && Head.Value == data)
            {
                Head = Head.Next;
            }

            Node current = Head;
            while (current != null && current.Next != null)
            {
                if (current.Next.Value == data)
                {
                    current.Next = current.Next.Next;
                }
                else
                {
                    current = current.Next;
                }
            }
        }
        public void RemoveIndex(int data)
        {
            //int index = 0;
            //Node pointer = Head;
            //while ( pointer.Next != null )
            //{
            //    index++;
            //    if (index == data)
            //    {
            //        pointer.Next = pointer.Next.Next;
            //        return;
            //    }


            //}
            if (Head != null)
            {
                if (data == 0)
                    Head = Head.Next;
                int index = 0;
                Node pointer = Head;
                while (pointer.Next != null)
                {
                    index++;
                    if (index == data)
                    {
                        pointer.Next = pointer.Next.Next;
                        return;
                    }
                    pointer = pointer.Next;
                }
                throw new Exception("no such givenIndex");

            }
            throw new Exception("List is empty");
        }
        // Method to find by value and return givenIndex
        public int Find(int data)
        {
            Node Pointer = Head;
            int index = -1;

            while (Pointer != null)
            {
                index++;
                if (Pointer.Value == data)
                {
                    return index;
                }
                Pointer = Pointer.Next;

            }
            throw new Exception("no such value");
        }

        // Method to get a value by  givenIndex and return the value
        public int Get(int givenIndex)
        {
            Node pointer = Head;
            int index = -1;
            while ( pointer != null )
            {
                index++;
                if (index == givenIndex)
                {
                    return pointer.Value;
                }
                pointer = pointer.Next;
            }
            throw new Exception($"no item at index {givenIndex}");
        }

    }
}
