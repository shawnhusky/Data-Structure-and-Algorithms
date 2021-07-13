using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class Parcel
    {
        //b.	Create a Parcel class that contains three attributes and their properties: id(int), customerName(String) and weight(int). The Parcel class has a constructor that takes in all attributes. 

        private int id;
        private string customerName;
        private int weight;


        public Parcel(int id,string customerName,int weight)
        {
            this.id = id;
            this.customerName = customerName;
            this.weight = weight;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }

