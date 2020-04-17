using System;
using System.Text;

namespace DotNetLearning.DataStructures
{
    class Node<T>
    {
        internal T Data;
        internal Node<T> Next;

        public Node(T value)
        {
            Data = value;
            Next = null;
        }
    }

    class SingleLinkedList<T>
    {
        internal Node<T> Head;
        internal Node<T> Tail;

        public SingleLinkedList()
        {
            Head = null;
            Tail = null;
        }

        public void Add(T newValue)
        {
            Node<T> elem = new Node<T>(newValue);
            if (Head == null)
            {
                Head = elem;
            }
            else
            {
                Tail.Next = elem;
            }
            Tail = elem;
        }

        // node - not null
        public void Remove(Node<T> node)
        {
            if (node == Head)
                Head = node.Next;
            if (node == Tail)
            {
                Node<T> temp = Head;
                while (temp.Next != node)
                {
                    temp = temp.Next;
                }
                Tail = temp;
            }
            if (node.Next != null)
            {
                Node<T> temp = Head;
                while (temp.Next != node)
                {
                    temp = temp.Next;
                }
                temp.Next = node.Next;
            }
        }

        public Node<T> Find(T value)
        {
            Node<T> iterator = Head;
            while (iterator != null)
            {
                if (iterator.Data.Equals(value))
                    return iterator;
                iterator = iterator.Next;
            }
            return null;
        }

    }
}
