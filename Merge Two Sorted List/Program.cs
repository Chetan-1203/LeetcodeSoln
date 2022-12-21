using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Two_Sorted_List
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


        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode list = new ListNode();
            ListNode trav = list;
            while(list1 != null && list2 != null)
            {
                if(list1.val <= list2.val)
                {
                    trav.next=list1;
                    list1 = list1.next;

                }
                else
                {
                    trav.next=list2;
                    list2= list2.next;  
                }
                trav=trav.next;
            }

            if(list1==null) trav.next=list2;
            else trav.next=list1;

            return list.next;
            
        }
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(3);
            ListNode l3 = new ListNode(5);
            l1.next = l2;
            l2.next = l3;

            ListNode a1 = new ListNode(2);
            ListNode a2 = new ListNode(4);
            ListNode a3 = new ListNode(6);
            a1.next = a2;
            a2.next = a3;

            ListNode result = MergeTwoLists(l1, a1);
            ListNode trav = result;
           
            while(trav!= null)
            {
                Console.WriteLine(trav.val + " ->");

                trav = trav.next;
            }
            Console.ReadLine();
        }

    }
    }