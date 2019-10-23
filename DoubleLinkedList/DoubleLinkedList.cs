using System;

namespace DoubleLinkedList
{
    public class DoubleLinkedList<T> : IDoubleLinkedList<T>
    {
        public IDoubleLinkedListNode<T> First { get; set; }
        public IDoubleLinkedListNode<T> Last { get; set; }
        public void AddFirst(T item)
        {
            if (item != null)
            {
                var tmp = new DoubleLinkedListNode<T>();
                tmp.Value = item;
                if (First == null && Last == null)
                {
                    tmp.Next = Last;
                    tmp.Prev = First;
                    First = Last = tmp;
                }
                else
                {
                    tmp.Next = First;
                    First = tmp;
                }
            }
        }

        public void AddLast(T item)
        {
            if(item != null)
            {
                var tmp = new DoubleLinkedListNode<T>();
                tmp.Value = item;

                if (First == null && Last == null)
                {
                    tmp.Next = Last;
                    tmp.Prev = First;
                    First = Last = tmp;
                }
                else
                {
                    tmp.Prev = Last;
                    Last = tmp;
                }
            }
        }
        public override string ToString()
        {
            string values = "";
            var tmp = First;
            while (tmp != null)
            {
                values += tmp.Value.ToString();
                tmp = tmp.Next;
            }
            return values;
        }
        public void Reverse()
        {
            IDoubleLinkedListNode<T> prev = null, current = First, next = null;
            while (current.Next != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            current.Next = prev;
            First = current;
        }
    }
}
