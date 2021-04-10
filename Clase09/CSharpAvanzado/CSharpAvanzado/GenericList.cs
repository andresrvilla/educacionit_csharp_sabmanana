using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAvanzado
{
    class GenericList<T>
    {
        private class Node
        {
            public Node(T dato)
            {
                Dato = dato;
                Next = null;
            }
            public T Dato { get; set; }
            public Node Next { get; set; }
        }
        private Node head;
        public GenericList()
        {
            head = null;
        }
        public void Add(T dato)
        {
            Node node = new Node(dato);
            node.Next = head;
            head = node;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node actual = head;
            while (actual != null)
            {
                yield return actual.Dato;
                actual = actual.Next;
            }
        }
    }
}
