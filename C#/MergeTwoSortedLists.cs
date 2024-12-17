/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list2 == null) return list1;
        else if (list1 == null) return list2;

        // Head and Tail of the merged list
        ListNode head = null;
        ListNode tail = null;

        // Initialize the head and tail pointers
        if (list1.val <= list2.val) {
            head = tail = list1;
            list1 = list1.next;
        } else {
            head = tail = list2;
            list2 = list2.next;
        }

        // Merge the remaining nodes
        while (list1 != null && list2 != null) {
            if (list1.val <= list2.val) {
                tail.next = list1;
                tail = list1;
                list1 = list1.next;
            } else {
                tail.next = list2;
                tail = list2;
                list2 = list2.next;
            }
        }

        // Attach the remaining part of 
        // the list that is not yet exhausted
        tail.next = (list1 != null) ? list1 : list2;

        return head;
    }
}