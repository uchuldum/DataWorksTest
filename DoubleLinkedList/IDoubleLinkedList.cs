using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedList
{
    public interface IDoubleLinkedList<T>
    {
        IDoubleLinkedListNode<T> First { get; set; }
        IDoubleLinkedListNode<T> Last { get; set; }
        void Reverse();
        void AddFirst(T item);
        void AddLast(T item);
    }
}
