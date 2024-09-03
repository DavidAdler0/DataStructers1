using System;
using System.Collections.Generic;
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

            }
            Head = newNode;
        }
        public string Display()
        {

            if (Head != null)
            {
                string list = Head.Value.ToString();
                Node pointer = Head;

                while (pointer.Next != null)
                {
                    pointer = pointer.Next;
                    list += "->" + pointer.Value.ToString();
                }
                return list;
            }
            throw new Exception("List is empty");
        }
        public int Length()
        {
            if (Head != null)
            {
                int length = 1;
                Node pointer = Head;

                while (pointer.Next != null)
                {
                    pointer = pointer.Next;
                    length++;
                }
                return length;
            }
            return 0;
        }
        public void RemoveValue(int data)
        {
            if (Head != null)
            {
                if (Head.Next == null)
                {
                    Head = null;
                    return;
                }
                Node pointer = Head;
                if (pointer.Value == data)
                    Node temp = pointer.;
                while (pointer.Next != null)
                {
                    if (pointer.Value == data)
                    {

                    }
                    pointer = pointer.Next;
                }
                return length;
            }
            return 0;
        }

    }
}
