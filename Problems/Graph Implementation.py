# You Have a Graph of People in Your Netweork You Need to Find the Person Who Sell Mango.
# You Can Use Any Way You Want to Check if the Person Sell Mango or Not (if His Name end With "m" He Sell Mango).
# Make Sure to Check Every Person Only Once.
# return True Id Thier any Person Who Sell Mange if not Retrun False.

from collections import deque

def Is_Seller_Person(Name):
    return Name[-1] == 'm';

def SearchGraph(name):

    Search_Queue = deque();
    Search_Queue += Graph[name];

    SearchedPeople = set();

    while Search_Queue:

        Person = Search_Queue.popleft();
            
        if not Person in SearchedPeople:       
            if Is_Seller_Person(Person):
                print(Person + " is a Mango Seller!")
                return True;
            else:
                Search_Queue += Graph[Person]   
                SearchedPeople.add(Person)   
        
    return False;

Graph = {}
Graph["Me"] = ["Mome", "Momo", "Nono"]
Graph["Nono"] = ["None", "Non", "Ne", "Me"]
Graph["Mome"] = ["Mum", "Me"]
Graph["Momo"] = []
Graph["None"] = []
Graph["Non"] = []
Graph["Ne"] = []

SearchGraph("Me")
