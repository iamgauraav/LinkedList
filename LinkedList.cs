using System;
using System.Collections.Generic;
namespace Linked_List
{
    internal class LinkedList<Gtype>
    {
        //first is the head 
        Node<Gtype> head = null;

        public void Add(Gtype data)
        {
            //variable
            //store the count in the temp_node 
            Node<Gtype> temp_node;

            //creating new node with data
            Node<Gtype> node = new Node<Gtype>(data);

            //there is no node 
            if (head == null)
            {
                //if there is no element so first one is head
                head = node;
                //close the executaion of the function
                return;
            }
            else
            {
                //count start from head
                temp_node = head;
                //checking for null
                while (temp_node.next != null)
                {
                    temp_node = temp_node.next;
                }
                //adding the node to next variable
                temp_node.next = node;
            }
        }

        public void Add(Gtype data, int pos)
        {
            //variable
            //created temp node
            Node<Gtype> temp_node = head;
            //calling size method
            int size = Size();
            // can not go maximum size(size + 1 ) or less than zero position
            if (pos > size + 1 || pos < 1)
            {
                Console.WriteLine("Invalid position");
                return;
            }
            //create node
            Node<Gtype> node = new Node<Gtype>(data);

            if (head == null)
            {
                Console.WriteLine("List is Empty");
                if (pos == 1)
                {
                    head = node;
                }
                else
                {
                    Console.WriteLine("Invalid position");
                }
            }
            else
            {

                //if you want to make the element at first only means head 
                if (pos == 1)
                {
                    //linking element
                    node.next = temp_node;
                    head = node;

                }
                else
                {
                    //count 2 because we have head position as 1 so count start from 2
                    int count = 2;
                    //go upto the position where we want to add
                    //if we want to other than head than
                    //so less than position
                    while (pos > count)
                    {
                        temp_node = temp_node.next;
                        count++;
                    }
                    //made a new temp node to store unlinked elemaent
                    Node<Gtype> temp_node2 = temp_node.next;
                    temp_node.next = node;
                    node.next = temp_node2;
                }
            }
        }

        public int Size()
        {
            //we have created this to call in add method
            if(head is null)
            {
                Console.WriteLine("List is empty..!!");
                return 0;
            }
            else
            {
                //we have head position so count start from 1
                int count = 1;
                //created temp variable and the node display start from head 
                Node<Gtype> temp_node = head;

                //display upto ---> node is not equal to null
                while (temp_node.next != null)
                {
                    count++;
                    Console.WriteLine(temp_node.next.value);
                    //go upto next element otherwise the loop will always take head
                    temp_node = temp_node.next;
                }
                return count;
            }
        }

        public void Display()
        {
            if (head is null)
            {
                Console.WriteLine("List is empty..!!");
                return;
            }
            else
            {
                //created temp variable and the node display start from head 
                Node<Gtype> temp_node = head;
                //displaying head as we had head value 
                Console.WriteLine(temp_node.value);
                //display upto ---> node is not equal to null
                while (temp_node.next != null)
                {
                    Console.WriteLine(temp_node.next.value);
                    //go upto next element otherwise the loop will always take head
                    temp_node = temp_node.next;
                }
            }
        }

        public void Remove(int pos)
        {
            //variable
            //created temp node
            Node<Gtype> temp_node = head;
            //calling size method
            int size = Size();
            // can not go maximum size(size + 1 ) or less than zero position
            if (pos > size + 1 || pos < 1)
            {
                Console.WriteLine("Invalid position");
                return;
            }
            
            //if you want ot make it head or add at first position
            if (pos == 1)
            {
                //if we want to change head than make next as head 
                head = temp_node.next;
            }
            else
            {
                //count 2 because we have head position as 1 so count start from 2
                int count = 2;
                //go upto the position where we want to add
                //if we want to other than head than 
                while (pos > count)
                {
                    temp_node = temp_node.next;
                    count++;
                }
                //made a new temp node to store unlinked elemaent
                //go to next next means ahead of removing  element
                Node<Gtype> temp_node2 = temp_node.next.next;
                temp_node.next = temp_node2;
            }   
        }
    }
}
