
    class Node
    {
        private object data;

        public object Data
        {
            get { return data; }
            set { data = value; }
        }
        private Node link;

        internal Node Link
        {
            get { return link; }
            set { link = value; }
        }

        public Node(Parcel d)
        {
            this.data = d;
        }
    }
