using QueueForm;
using System.Collections;
using System.Collections.Generic;

namespace QueueForm
{
    public partial class Form1 : Form
    {
        private Queue<string> queuequeue = new Queue<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {

            string item = Input.Text.Trim();
            if (!string.IsNullOrEmpty(item)) {
                queuequeue.Enqueue(item);
                Input.Clear();
                Displayqueue();


            }

            private void remove_Click(object sender, EventArgs e)
            {
                if (queuequeue.Count > 0)
                {
                    queuequeue.Dequeue(); 
                    Displayqueue();
                }

                public void Displayqueue()
                {
                    listofthings.Items.Clear();
                    foreach (string getList in queuequeue)
                    {
                        listofthings.Items.Add(getList);

                    }

                }
            }
        }
    }
}

//Queue<string> queuequeue;  // Queue to store string items

// public Form1()
//{
   // InitializeComponent();
  //  queuequeue = new Queue<string>();  
//}

//private void Input_TextChanged(object sender, EventArgs e)
//{
    //queuequeue.Enqueue(Input.Text);  
   // Displayqueue(queuequeue);  
//}


//private void remove_Click(object sender, EventArgs e)
//{
 //   if (queuequeue.Count > 0) 
  //  {
  //      queuequeue.Dequeue();  
  //  }
   // Displayqueue(queuequeue); 
// }


//public void Displayqueue(IEnumerable<string> listofthings)
//{
  //  IvFruit.Items.Clear();  // Assuming IvFruit is a ListBox, clear the current items

//    foreach (string item in listofthings)
  //  {
   //     IvFruit.Items.Add(item);  // Add each item from the queue to the ListBox
   // }


