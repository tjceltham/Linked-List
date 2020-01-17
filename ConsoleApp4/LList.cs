using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class LList
    {
        private Node head;

        public LList()
        {
            head = null;

        }

        public void addList(string name)
        {
            Node s;
            s = new Node();

            s.name = name;
            s.next = null;
            Node temp;
            temp = head;
            if (temp == null)
            {
                head = s;
            }
            else
            {

                while (temp.next != null)
                {
                    temp = temp.next;


                }
                temp.next = s;


            }



        }

    }
}
