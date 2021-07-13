//using System;

    class LinkedList
    {
        private Node head; 	// first node in the linked list
        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public Node Head
        {
            get { return head; }
        }
        public LinkedList()
        {
            head = null; 	// creates an empty linked list
            count = 0;
        }

	public void AddFront(Parcel n)
	{
            Node newNode = new Node(n);
            newNode.Link = head;
            head = newNode;
            count++;

	}
    	public void DeleteFront()
    	{
            if (count > 0)
            {
                Node temp = head;
                head = temp.Link;
                temp = null;
                count--;
            }
        }

        //i.	AddParcelToFront(Parcel parcel) : This method will create a new Node with the parcel object as its data value and then add the newly created node to the front of the linked list.

        public void AddParcelToFront(Parcel parcel)
        {
            Node newNode = new Node(parcel);
            newNode.Link = head;
            head = newNode;
            count++;
        }

        //ii.	DisplayInventory():  This method will traverse the linked list from its first node to its last node and print the data value (i.e., the id, customerName and weight of the parcel object) of each note. 

        public void DisplayInventory()
        {
            int num = 1; //ask--------------------

            for (Node temp = head; temp != null; temp = temp.Link)
            {
                Parcel temp2 = (Parcel)temp.Data;
                Console.WriteLine(num + "." + temp2.Id + "\t\t" + temp2.CustomerName + "\t\t" + temp2.Weight);
                num++;
            }
        }

        //iii.	RemoveParcelAtPosition(int n): This method will remove the node at position n in the linked list. Assume that the first node of the linked list has a position number of 1 and the second node has a position number of 2 and so on and so forth.
        public void RemoveParcelAtPosition(int n)
        {
            Node temp1 = head;
            Node temp2 = head;
            Node temp3 = head;

            if (n == 1)
            {
                head = head.Link;
            }
            else
            {
                for (int i = 1; i < n - 1; i++)
                {
                    temp1 = temp1.Link;
                }
                for (int i = 1; i < n; i++)
                {
                    temp2 = temp2.Link;
                }
                for (int i = 1; i < n + 1; i++)
                {
                    temp3 = temp3.Link;
                }
                temp2.Link = null;
                temp1.Link = temp3;
            }


            count--;
        }

        //iv.	ParcelSwap(int n1, int n2):  This method will swap the node at position n1 with the node at position n2. 

        public void ParcelSwap(int n1,int n2)
        {

            Node temp1 = head;
            Node temp2 = head;

            for (int i = 0; i < Count; i++)
            {
                if (n1 - 1 == i) // node postion is the number -1
                {
                    break;
                }
                temp1 = temp1.Link;
            }

            for (int i = 0; i < Count; i++)
            {
                if (n2 - 1 == i)
                {
                    break;
                }
                temp2 = temp2.Link;
            }

            Parcel parcel1 = (Parcel)temp1.Data;
            Parcel parcel2 = (Parcel)temp2.Data;

            temp1.Data = parcel2;
            temp2.Data = parcel1;
        }

        // v.	SortByCustomerName():  This method will sort the linked list by the customer name in ascending order.

        public void SortByCustomerName()
        {
            Parcel p1;
            Parcel p2;
            for (Node temp1 = head; temp1 != null; temp1 = temp1.Link)
            {
                for (Node temp2 = head; temp2 != null; temp2 = temp2.Link)
                {
                    p1 = (Parcel)temp1.Data;  //Creating temp for swapping
                    p2 = (Parcel)temp2.Data;

                    if (string.Compare(p1.CustomerName, p2.CustomerName) == -1)//p1 is lesser than p2
                    {
                        temp1.Data = p2;
                        temp2.Data = p1;
                    }

                }
            }

        }

    }
