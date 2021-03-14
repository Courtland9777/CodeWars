using System;

public partial class Node
{
  public int Data;
  public Node Next;
  
  public Node(int data)
  {
    this.Data = data;
    this.Next = null;
  }
  
  public static int Length(Node head)
  {
    Node temp = head; 
        int count = 0; 
        while (temp != null) 
        { 
            count++; 
            temp = temp.Next; 
        } 
        return count; 
  }
  
  public static int Count(Node head, Predicate<int> func)
  {
    Node temp = head;
    int count = 0;
    while (temp != null)
    {
        if (func(temp.Data))
        {
            count++;
        }
        temp = temp.Next;
    }
    return count;
  }
}