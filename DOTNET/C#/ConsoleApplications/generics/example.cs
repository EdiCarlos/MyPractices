using System;

class Employee
{
	private string name;
	private int Id;
	public Employee()
	{
		
	}
	public Employee(string name, int Id)
	{
		this.name = name;
		this.Id = Id;
	}
	public string Name
	{
		get{return name;}
		set{name = value;}
	}
	public int ID
	{
		get{return Id;}
		set{Id = value;}
	}
}

public class GenericList<T> where T : Employee
{
	private class Node()
	{
		private Node next;
		private T data;
		public Node(T t)
		{
			next = null;
			data = t;
		}
		public Node Next
		{
			get{return next;}
			set{next = value;
		}
		public T data
		{
			get{return data;}
			set{data = value;}
		}
	}
	
	private Node head;
	
	public GenericList()
	{
		head = null;
	}
	public void AddHead(T t)
	{
		Node n = new Node(t);
		n.Next = head;
		head = n;
	}
	public IEnumerator<T> GetEnumerator()
	{
		Node current = head;
		
		while(current != null)
		{
			yield return current.Next;
			current = current.Next;
		}
	}
			
}