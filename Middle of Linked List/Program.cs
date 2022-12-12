using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_of_Linked_List
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
    public class Program
    {
        
            public static ListNode MiddleNode(ListNode head)
            {
                ListNode temp = head;
                ListNode trav = head;
                while(trav != null && trav.next != null)
                {
                    temp = temp.next;
                    trav = trav.next.next;
                }
                return temp;
            }
        

        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
           
            ListNode  node1 = new ListNode(2);  
            ListNode  node2 = new ListNode(3);  
            ListNode  node3 = new ListNode(4);  
            ListNode  node4 = new ListNode(5);  
            ListNode  node5 = new ListNode(6);  
            
            head.next = node1;
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5; 

            ListNode result = MiddleNode(head);
            Console.WriteLine(result.val);
            Console.ReadLine();

        }
    }
}
