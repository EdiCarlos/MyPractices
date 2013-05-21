#include <iostream>

using namespace std;
struct link
{
	int data;
	link* next;
};
class linklist
{
	public:
	linklist(){first = NULL;}
	void additem(int i);
	void display();
	private:
	link* first; 
};

void linklist::additem(int d)
{
	link* newlink = new link;
	newlink->data = d;
	newlink->next = first;
	first = newlink;
	
}
void linklist::display()
{
	link* current = first;
	while(current != NULL)
	{
		cout<<current->data<<endl;
		current = current->next;
	}
}

int main()
{
	linklist li;
	li.additem(25);
	li.additem(30);
	li.additem(49);
	li.additem(50);
	
	li.display();
}