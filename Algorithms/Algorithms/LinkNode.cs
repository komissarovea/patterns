namespace Algorithms
{
    // Definition for singly-linked list.
    public class LinkNode
    {
        public int val;
        public LinkNode next;

        public LinkNode(int val = 0, LinkNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public int GetLength()
        {
            int length = 1;
            var current = this;
            while (current.next != null)
            {
                length++;
                current = current.next;
            }
            return length;
        }

        public void Print()
        {
            var current = this;
            while (current != null)
            {
                Console.Write(current.val);
                current = current.next;
                if (current != null)
                    Console.Write("->");
            }
            Console.WriteLine();
        }

        public LinkNode Reverse()
        {
            LinkNode head = this;
            // 1) 1->2->3->4
            // 2) 2->1->3->4
            // 3) 3->2->1->4
            // 4) 4->3->2->1
            while (this.next != null)
            {
                LinkNode current = this.next;
                this.next = current.next;

                current.next = head;
                head = current;
            }

            return head;
        }

        public override string ToString()
        {
            return val.ToString();
        }
    }

}
