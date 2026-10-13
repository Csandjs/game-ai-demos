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
class Program
{
    static ListNode MergeTwoLists(ListNode a, ListNode b)
    {
        ListNode dummy = new ListNode();
        ListNode current = dummy;
        while(a != null && b != null)
        {
            if (a.val <= b.val)
            {
                current.next = a;
                a = a.next;
            }
            else
            {
                current.next = b;
                b = b.next;
            }
            current = current.next;
        }
        current.next = a ?? b;
        return dummy.next;
    }
    static void Main(string[] args)
    {
        ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        ListNode result = MergeTwoLists(list1, list2);
        while(result != null)
        {
            Console.Write(" " + result.val);
            result = result.next;
        }
    }
}