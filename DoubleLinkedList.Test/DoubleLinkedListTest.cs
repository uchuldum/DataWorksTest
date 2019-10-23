using System;
using Xunit;
using DoubleLinkedList;

namespace DoubleLinkedList.Test
{
    public class DoubleLinkedListTest
    {
        [Fact]
        public void OneAddAddFirst()
        {
            //Arrange
            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
            //Act
            doubleLinkedList.AddFirst(1);
            //Assert
            Assert.Equal(doubleLinkedList.First.Value, 1);
            Assert.Equal(doubleLinkedList.Last.Value, 1);
        }
        [Fact]
        public void ManyAddAddFirst()
        {
            //Arrange
            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
            //Act
            doubleLinkedList.AddFirst(1);
            doubleLinkedList.AddFirst(2);
            //Assert
            Assert.Equal(doubleLinkedList.First.Value, 2);
            Assert.Equal(doubleLinkedList.First.Next.Value, 1);
        }
        

        [Fact]
        public void OneAddAddLast()
        {
            //Arrange
            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
            //Act
            doubleLinkedList.AddLast(1);
            //Assert
            Assert.Equal(doubleLinkedList.Last.Value, 1);
            Assert.Equal(doubleLinkedList.First.Value, 1);
        }
        [Fact]
        public void ManyAddAddLast()
        {
            //Arrange
            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
            //Act
            doubleLinkedList.AddLast(1);
            doubleLinkedList.AddLast(2);
            //Assert
            Assert.Equal(doubleLinkedList.Last.Value, 2);
            Assert.Equal(doubleLinkedList.Last.Prev.Value, 1);
        }

        [Fact]
        public void ValidToString()
        {
            //Arrange
            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
            //Act
            doubleLinkedList.AddFirst(1);
            doubleLinkedList.AddFirst(2);
            doubleLinkedList.AddFirst(3);
            //Assert
            Assert.Equal(doubleLinkedList.ToString(), "321");
        }

        [Fact]
        public void InValidToString()
        {
            //Arrange
            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
           

            //Act
            doubleLinkedList.AddFirst(1);
            doubleLinkedList.AddFirst(2);
            doubleLinkedList.AddFirst(3);
            //Assert
            Assert.NotEqual(doubleLinkedList.ToString(), "311");
        }

        [Fact]
        public void ValidReverse()
        {
            //Arrange
            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
            //Act
            doubleLinkedList.AddFirst(1);
            doubleLinkedList.AddFirst(2);
            doubleLinkedList.AddFirst(3);
            doubleLinkedList.Reverse();
            //Assert
            Assert.Equal(doubleLinkedList.ToString(), "123");
        }
        [Fact]
        public void InValidReverse()
        {
            //Arrange
            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
            //Act
            doubleLinkedList.AddFirst(1);
            doubleLinkedList.AddFirst(2);
            doubleLinkedList.AddFirst(3);
            doubleLinkedList.Reverse();
            //Assert
            Assert.NotEqual(doubleLinkedList.ToString(), "132");
        }
    }
}
