using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiddleOfLinkedList_WebApp
{
    public class LinkedList
    {
        public int data;
        public LinkedList nextPointer;
        public static LinkedList Head;

        public LinkedList() { }
        public LinkedList(int data, LinkedList pointer) {
            this.data = data;
            this.nextPointer = pointer;
        }

        public void appendToList(int[] elements) {
            for (int index = 0; index < elements.Length; index++) {
                appendToLinkedList(elements[index]);
            }

        }
        public void appendToLinkedList(int element) {
            if (Head == null)
            {
                Head = new LinkedList(element, null);
            }
            else {
                LinkedList current = Head;
                while (current.nextPointer != null) {
                    current = current.nextPointer;
                }
                current.nextPointer = new LinkedList(element, null);
            }
        }

        public String displayLinkedList() {
            String result = "";
            if (Head == null)
                return "";
            LinkedList current = Head;
            while (current != null) {
                result += current.data + ",";
                current = current.nextPointer;
            }
            return result;
        }

        public LinkedList getCurrentList() {
            return Head;
        }
        public int findMiddleOfLinkedList(LinkedList list) {
            int count = list.getNumberOfElements();
            int middle = count / 2;
            int index = 0;
            if (list == null)
                return -1;
            LinkedList current = list;
            while (index < middle && current != null) {
                current = current.nextPointer;
                index++;
            }
            return current.data;
        }

        private int getNumberOfElements() {
            int count = 0;
            if (Head == null) return count;
            LinkedList current = Head;
            while (current != null) {
                current = current.nextPointer;
                count++;
            }
            return count;
        }

    }
}