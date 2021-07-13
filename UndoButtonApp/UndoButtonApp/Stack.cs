class Stack
    {
        private int top;		//index
        private object[] items;	//use array to store data in stack
        private int count;
        public Stack(int s)
        {
            items = new object[s];  //create stack using fixed size array
            top = -1;
            count = 0;
        }


        public bool Push(object x)
        {
            // Is the stack full?
            if (count == items.Length)
            {
                return false;
            }
            else
            {
                top++;               //move pointer up by 1
                items[top] = x;      //store item into array location
                count++;
                return true;
            }
        }

        public object Pop()
        {
            object result = null;
            if (count == 0)              // If the stack is empty
            {
                return null;
            }
            else
            {

                result = items[top];  // remove the top element from the stack
                top--;                 //move pointer down by 1
                count--;
                return result;        //return value of the item popped
            }
        }

        public object Peek()
        {
            if (count == 0)             // If the stack is empty	
            {
                return null;
            }
            else
            {
                // only return a copy of the top item
                return items[top];
            }
        }

        public bool IsEmpty()
        {
            if (count == 0)         // If the stack is empty
            {
                return true;     //confirmed empty
            }
            else
            {
                return false;    //stack not empty
            }
        }
        public int Size()
        {
            return count;          //+1 because the first item is at top=0
        }

    }