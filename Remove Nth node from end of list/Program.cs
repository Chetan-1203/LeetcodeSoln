using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Nth_node_from_end_of_list
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public  class Program
    {
        public class Solution
        {
            public static ListNode RemoveNthFromEnd(ListNode head, int n)
            {
                ListNode newNode = new ListNode(0);
                newNode.next = head;
                ListNode trav = newNode;
                ListNode temp = newNode;
                 
                while(n > 0)
                {
                    trav=trav.next;
                    n--;
                }

                while(trav.next != null)
                {
                    trav =trav.next;
                    temp=temp.next;
                }
                temp.next = temp.next.next;
                return newNode.next;
            }
            static void Main(string[] args)
            {
                ListNode head = new ListNode(1);

                ListNode node1 = new ListNode(2);
                ListNode node2 = new ListNode(3);
                ListNode node3 = new ListNode(4);
                ListNode node4 = new ListNode(5);


                head.next = node1;
                node1.next = node2;
                node2.next = node3;
                node3.next = node4;

                ListNode result = RemoveNthFromEnd(head,2);

                ListNode trav = result;
                while(trav!=null)
                {
                    Console.WriteLine(trav.val);
                    trav=trav.next;
                }


                Console.ReadLine(); 
            }
        }
       
    }
}
