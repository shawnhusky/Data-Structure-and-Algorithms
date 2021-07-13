using System; //added this so the console.write can use

    class Queue
    {
        //implementation of Queue using an Array
		private int count;
        private int front = 0;	// refer to the front item in the queue

        public int Front
        {
            get { return front; }
            set { front = value; }
        }
        private int rear = 0;	// refer to the last item in the queue

        public int Rear
        {
            get { return rear; }
            set { rear = value; }
        }
		private object [] items; // refer to an array of any objects
		private int maxSize;
			
		public Queue(int maxSize)
		{
			count = 0;
			front = -1;
			rear = -1;
			items = new object [maxSize];
			this.maxSize = maxSize;
		}
		public int Count {
			get { return count; }
			set { count = value; }
		}

        public void Enqueue (object x) 
        {
	        if (count == maxSize) {
		        Console.WriteLine ("Queue is full");
	        }
	        else if (count == 0) // first item to be enqueued
	        {
                if (rear == maxSize - 1)
                {
                    rear = 0;
                    front = 0;
                }
                else
                {
                    rear++;
                    front++;
                }
		        
		        items[rear] = x;
		        count++;
	        }
	        else 
	        { 	// queue is NOT full
		        if (rear == maxSize - 1) // check position of rear
			        rear = 0;	 // reset “rear” to 0
		        else
			        rear++;		// increase “rear” by 1
		        items [rear] = x;	// add x at “rear” of queue
		        count++;
	        }
        }
        public object Dequeue() 
        {
	        if (IsEmpty()) {
		        Console.WriteLine ("Queue empty!");
		        return null;
	        }
	        else 
	        { 	// queue is NOT empty
		        object temp = items [front];  // remove item at “front” of queue
		        count--;
		        if (front == maxSize - 1)        // check position of “front”
			        front = 0;	          // reset “front” to 0
		        else
			        front++;	         // increase “front” by 1
                if (count == 0)
                {
                    front = -1;
                    rear = -1;
                }			

		        return temp;		
	        }
        }
        public bool IsEmpty()
        {
	        if (count == 0)
		        return true;
	        else
		        return false;
        }
        public object Peek(int i)
        {
            return items[i];

        }
    
    }

