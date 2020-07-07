using System;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        private ListNode tail;
        private ListNode head;

        public int Count { get; set; }

        public int this[int index]
        {
            get
            {
                int[] arr = this.ToArray();

                if(index < 0 || index >= arr.Length)
                {
                    throw new ArgumentException("The index is out of the bonds of the list!");
                }

                return arr[index];
            }
        }

        public void AddFirst(int element)
        {
            if (this.Count == 0)
            {
                this.tail = this.head = new ListNode(element);
            }
            else
            {
                var newNode = new ListNode(element);
                newNode.NextNode = this.head;
                this.head.PreviousNode = newNode;
                this.head = newNode;
            }

            Count++;
        }

        public void AddLast(int element)
        {
            if (this.Count == 0)
            {
                this.tail = this.head = new ListNode(element);
            }
            else
            {
                var newNode = new ListNode(element);
                this.tail.NextNode = newNode;
                newNode.PreviousNode = this.tail;
                this.tail = newNode;
            }

            this.Count++;
        }

        public int RemoveFirst()
        {

            if (this.Count == 0)
            {
                throw new InvalidOperationException("The DoublyLinkedList is empty!");
            }

            int element = this.head.Value;

            if (this.Count == 1)
            {
                this.head = this.tail = null;
            }
            else if(this.Count > 1)
            {
                var nextNode = this.head.NextNode;
                nextNode.PreviousNode = null;
                this.head = nextNode;
            }

            this.Count--;
            return element;
        }

        public int RemoveLast()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("The DoublyLinkedList is empty!");
            }

            int element = this.tail.Value;

            if(this.Count == 1)
            {
                this.head = this.tail = null;
            }
            else if(this.Count > 1)
            {
                var newTail = this.tail.PreviousNode;
                newTail.NextNode = null;
                this.tail = newTail;
            }

            this.Count--;
            return element;
        }

        public void ForEach(Action<int> action)
        {
            var currentNode = this.head;

            while(currentNode != null)
            {
                int element = currentNode.Value;
                action(element);
                currentNode = currentNode.NextNode;
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[this.Count];
            int count = 0;

            var currentNode = this.head;

            while (currentNode != null)
            {
                int element = currentNode.Value;
                array[count] = element;
                currentNode = currentNode.NextNode;
                count++;
            }

            return array;
        }
    }
}
