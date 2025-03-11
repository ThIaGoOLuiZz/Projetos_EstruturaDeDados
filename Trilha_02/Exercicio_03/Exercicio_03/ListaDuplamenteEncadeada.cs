namespace Exercicio_03
{
    internal class ListaDuplamenteEncadeada
    {
        Node head;

        public void Insertfirst(Object data)
        {
            if(head == null)
            {
                Node newNode = new Node();
                
                newNode.Data = data;
                newNode.Next = null;
                newNode.Prev = null;

                head = newNode;
                return;
            }

            Node current = head;

            Node newHead = new Node();
            newHead.Data = data;
            newHead.Next = current;
            newHead.Prev = null;

            head.Prev = newHead;

            head = newHead;
        }

        public void RemoveLast()
        {
            if( head == null)
            {
                throw new IndexOutOfRangeException("Empty list!");
            }

            if(head.Next == null)
            {
                head = null;
                return;
            }

            Node current = head;

            while(current.Next != null )
            {
                current = current.Next;
            }

            current.Prev.Next = null;
            return;
        }

        public void PrintNextOrder()
        {
            Node current = head;

            if( current == null )
            {
                throw new IndexOutOfRangeException("Empty list!");
            }
            Console.Write($"Valores com Next: ({current.Data}");
            while(current.Next != null)
            {
                Console.Write(",");
                Console.Write(current.Next.Data);

                current = current.Next;
            }
            Console.WriteLine(")");
        }

        public void PrintPrevOrder()
        {
            Node current = head;

            while(current.Next != null)
            {
                current = current.Next;
            }

            Console.Write($"Valores com Prev: ({current.Data}");
            while (current.Prev != null)
            {
                Console.Write(",");
                Console.Write(current.Prev.Data);

                current = current.Prev;
            }
            Console.WriteLine(")");
        }


    }
}
