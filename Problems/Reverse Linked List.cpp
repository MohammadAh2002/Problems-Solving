/*

	Reverse Linked List.

*/

#include <iostream>

using namespace std;

class Node {

public:

	short Value;
	Node* NextNode;

};

void InsertAtBeginning(Node*& NodeHead, int Val) {


	Node* TheNewNode = new Node();

	TheNewNode->Value = Val;
	TheNewNode->NextNode = NodeHead;

	NodeHead = TheNewNode;
}

void PrintList(Node* NodeHead) {

	while (NodeHead != NULL) {

		cout << NodeHead->Value << " -> ";
		NodeHead = NodeHead->NextNode;
	}
	cout << "NULL\n";
}

void ReversList(Node*& head) {


	if (head == NULL || head->NextNode == NULL)
		return;

	Node* prev = NULL, * Current = head->NextNode;
	head->NextNode = NULL;

	while (Current != NULL) {

		prev = head;
		head = Current;
		Current = Current->NextNode;
		head->NextNode = prev;
	}

}

int main()
{

	Node* NodeHead = NULL;

	InsertAtBeginning(NodeHead, 5);
	InsertAtBeginning(NodeHead, 4);
	InsertAtBeginning(NodeHead, 3);
	InsertAtBeginning(NodeHead, 2);
	InsertAtBeginning(NodeHead, 1);

	cout << "\nMain List elemnts:\n";
	PrintList(NodeHead);

	ReversList(NodeHead);

	cout << "\nList after revers:\n";
	PrintList(NodeHead);

	return 0;

}