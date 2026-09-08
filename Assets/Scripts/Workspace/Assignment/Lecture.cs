using UnityEngine;
using System.Collections.Generic;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            // LCT01_SyntaxList();
             //LCT02_SyntaxLinkedList();
            // LCT03_SyntaxHashTable();
           //LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            List<string> lists = new List<string>();
        }

        public void LCT02_SyntaxLinkedList()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            //["Node 1"]
            linkedList.AddLast("Node 1");
            linkedList.AddLast("Node 2");
            linkedList.AddFirst("Node 0");
            PrintLinkList(linkedList);

            LinkedListNode<string> firstNode = linkedList.First;
            //string firstNode2 = Linkedlost.First; เก็บข้อมมูลเป็นโหนด
            Debug.log("first: " + firstNode.Value);
            linkedListNode<string> lastNode = linkedList.Last;
            Debug.Log("last: " + lastNode.Value);
            LinkesListNode<string> node1 = linkedList.Find("Node 1");
            Debug.Log("node: " + node1.Value);
            Debug.Log(node1.Previous.Value);
            Debug.Log(node1.Next.Value);
            //Debug.Log(node1.Next.Next.Next.Next.Next.);
            if (firstNode.Previous == null) { Debug.Log("firtsNode.Previous is null"); }
            if (lastNode.Next == null) { Debug.Log("lastNode.Next is null"); }


            linkedList.AddAfter(node1, "Node 1.5");
            linkedList.AddBefor(node1, "Node 0.5");
            PrintLiinkList(linkedList);

            linkedList.RemoveFirst();
            PrintLiinkList(linkedList);
            linkedList.Remove("Node 2");//ถ้ามี node2 มากกว่า 1 มันจะลบตัวแรกที่เจอ
            //linkedlist.Remove(node1); ลบด้วยโหนด หรือ ค่าของตัวแปร
            PrintLiinkList(linkedList);
            linkedList.clear();
            PrintLiinkList(linkedList);
           
           
        }

          void PrintLinkList(LinkedList<string> linkedList) 
        {
            Debug.Log("------linkedList------");
            foreach (string s in linkedlist) 
            {
                Debug.Log(s);   
            }
        }

        public void LCT03_SyntaxHashTable()
        {
            throw new System.NotImplementedException();
        }

        public void LCT04_SyntaxDictionary()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary2.Add(1, "Apple");
            dictionary2.Add(2, "Banana");
            dictionary[3] = "Cherry";//มีค่าเท่ากับ Add

            // Debug.Log(dictionary[4]);
            int keytocheck = 1;
            bool hasKey = dictionary.ContainsKey(keytocheck);
            Debug.Log($"has key {keytocheck}:{hasKey}");
            if (hasKey) 
            {
                Debug.Log(dictionary[keytocheck]);
            }
            foreach (int k in dictionary.Keys)
            {
                Debug.Log(k);
            }
            foreach (string s in dictionary.Values)
            {
                Debug.Log(s);
            }
            dictionary.Remove(1);
            foreach (string s in dictionary.Values)
            {
                Debug.Log(s);
            }
            dictionary.Clear();
            foreach (string s in dictionary.Values)
            {
                Debug.Log(s);
            }
        }

        #endregion
    }
}