using System;
public class JosephusSurvivor 
{
  public class Node  
  {  
      public int data;  
      public Node next;  
      public Node( int data )  
      {  
          this.data = data;  
      }  
  }  
        
  public static int JosSurvivor(int m, int n)  
  {  
      if(n == 1) return m;
      Node head = new Node(1);  
      Node prev = head;  
      for(int i = 2; i <= m; i++)  
      {  
          prev.next = new Node(i);  
          prev = prev.next;  
      }  
         
      prev.next = head;  
        
      Node ptr1 = head, ptr2 = head;  
        
      while(ptr1.next != ptr1)  
      {  
          int count = 1;  
          while(count != n)  
          {  
              ptr2 = ptr1;  
              ptr1 = ptr1.next;  
              count++;  
          }  
            
          ptr2.next = ptr1.next;  
          ptr1 = ptr2.next;  
      }  
      return ptr1.data;
  }  
}