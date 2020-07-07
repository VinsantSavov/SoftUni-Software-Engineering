using System;

namespace P09.GenericLinkedList
{
    public class DoublyLinkedList<T>
    {
        private ListNode<T> head;
        private ListNode<T> tail;

        public int Count { get; set; }

        public void AddFirst(T element)
        {
            if(this.Count == 0)
            {
                var newNode = new ListNode<T>(element);
                this.head = this.tail = newNode;
            }
            else
            {
                var newNode = new ListNode<T>(element);
                newNode.NextNode = head;
                head.PreviousNode = newNode;
                head = newNode;
            }

            Count++;
        }

        public void AddLast(T element)
        {
            if(this.Count == 0)
            {
                var newNode = new ListNode<T>(element);
                this.head = this.tail = newNode;
            }
            else
            {
                var newNode = new ListNode<T>(element);
                tail.NextNode = newNode;
                newNode.PreviousNode = tail;
                tail = newNode;
            }

            Count++;
        }

        public T RemoveFirst()
        {

            if(this.Count == 0)
            {
                throw new System.Exception("The list is empty!");
            }

            T element = head.Value;

            if(this.Count == 1)
            {
                this.tail = this.head = null;
            }
            else
            {
                head.NextNode.PreviousNode = null;
                head = head.NextNode;
            }
            this.Count--;

            return element;
        }

        public T RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new System.Exception("The list is empty!");
            }

            T element = head.Value;

            if (this.Count == 1)
            {
                this.tail = this.head = null;
            }
            else
            {
                tail.PreviousNode.NextNode = null;
                tail = tail.PreviousNode;
            }
            this.Count--;

            return element;
        }

        public void ForEach(Action<T> action)
        {
            var currentNode = head;

            while(currentNode != null)
            {
                T element = currentNode.Value;
                action(element);
                currentNode = currentNode.NextNode;
            }
        }

        public T[] ToArray()
        {
            var currentNode = head;
            T[] arrayOfElements = new T[this.Count];
            int counter = 0;

            while (currentNode != null)
            {
                T element = currentNode.Value;
                arrayOfElements[counter] = element;
                currentNode = currentNode.NextNode;
                counter++;
            }

            return arrayOfElements;
        }
    }
}
