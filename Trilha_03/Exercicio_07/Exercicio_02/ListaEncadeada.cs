using System.Collections;

namespace Exercicio_02
{
    internal class ListaEncadeada : IEnumerable
    {
        public Node head;

        public IEnumerator GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public void InsertAtBeginning(Object data)
        {
            Node newNode = new Node();

            newNode.Data = data;
            newNode.Next = head;

            head = newNode;
        }

        public void InsertAtEnd(Object data)
        {
            if(head == null)
            {
                head = new Node();

                head.Data = data;
                head.Next = null;
            }
            else
            {
                Node newNode = new Node();
                newNode.Data= data;

                Node current = head;
                while(current.Next != null )
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }

        public void Remove(Object value)
        {
            if (head == null)
            {
                throw new IndexOutOfRangeException("Empty list!");
            }

            if(head.Data == value)
            {
               head = head.Next;
                return;
            }

            Node current = head;

            while (current.Next != null )
            {
                if(current.Next.Data == value)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }

        public int ContaNodes(Node node)
        {
            if (node == null)
                return 0;
            return 1 + ContaNodes(node.Next);
        }
    }
}
