using System;

public class Node
{
  public int Data;
  public Node Next;
  
  public Node(int data)
  {
    this.Data = data;
    this.Next = null;
  }
  
  public static Node Push(Node head, int data)
  {
    return new Node(data)
    {
        Next = head
    };
  }
  
  public static Node BuildOneTwoThree()
  {
    Node list = null;
    list = Push(list, 3);
    list = Push(list, 2);
    list = Push(list, 1);
    return list;
  }
}