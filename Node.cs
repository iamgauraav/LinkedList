using System;
using System.Collections.Generic;
namespace Linked_List
{
    public class Node<Gtype>
    {
        //element contains what? --> node ,node has two things value,address of next node
        public Gtype value;
        public Node<Gtype> next;
        // made new node constructor
        // new node has val which is data
        // and next is always null
        public Node(Gtype data)
        {
            this.value = data;
            this.next = null;
        }
           
    }
}
