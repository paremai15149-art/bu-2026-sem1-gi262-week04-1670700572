using UnityEngine;
using System.Collections.Generic;

namespace Assignment
{
    public class Assignment : MonoBehaviour
    {
        public void Start()
        {
            //AS01_CountWords();
            // AS02_CountNumber();
            // AS03_CheckValidBrackets();
            // AS04_PrintReverseLinkedList();
            //AS05_FindMiddleElement();
            // AS06_MergeDictionaries();
            AS07_RemoveDuplicatesFromLinkedList();
            // AS08_TopFrequentNumber();
            // AS09_PlayerInventory();
            // AS10_GameEventQueue();
            // AS11_PlayerStatsTracker();
        }

        #region Assignment

        [Header("AS01 - Count Words")]
        [SerializeField] private string[] as01Words;

        public void AS01_CountWords()
        {
            string[] words = as01Words;
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount.Add(word, 1);
                }
            }

            foreach (KeyValuePair<string, int> item in wordCount)
            {
                Debug.Log("word: '" + item.Key + "' count: " + item.Value);
            }
        }

        [Header("AS02 - Count Number")]
        [SerializeField] private int[] as02Numbers;

        public void AS02_CountNumber()
        {
            int[] numbers = as02Numbers;
            Dictionary<int, int> numberCount = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];

                if (numberCount.ContainsKey(number))
                {
                    numberCount[number]++;
                }
                else
                {
                    numberCount.Add(number, 1);
                }
            }

            int[] keys = new int[numberCount.Keys.Count];
            int[] values = new int[numberCount.Values.Count];

            numberCount.Keys.CopyTo(keys, 0);
            numberCount.Values.CopyTo(values, 0);

            for (int i = 0; i < keys.Length; i++)
            {
                Debug.Log("number: " + keys[i] + " count: " + values[i]);
            }
        }

        [Header("AS03 - Check Valid Brackets")]
        [SerializeField] private string as03Input;

        public void AS03_CheckValidBrackets()
        {
            string input = as03Input;
            Dictionary<char, char> brackets = new Dictionary<char, char>()
    {
        { '(', ')' },
        { '[', ']' },
        { '{', '}' }
    };

            LinkedList<char> stack = new LinkedList<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];

                if (brackets.ContainsKey(current))
                {
                    stack.AddLast(current);
                }
                else if (brackets.ContainsValue(current))
                {
                    if (stack.Count == 0)
                    {
                        Debug.Log("Invalid");
                        return;
                    }

                    char openBracket = stack.Last.Value;

                    if (brackets[openBracket] != current)
                    {
                        Debug.Log("Invalid");
                        return;
                    }

                    stack.RemoveLast();
                }
            }

             if (stack.Count == 0)
            {
                Debug.Log("Valid");
            }
            else
            {
                Debug.Log("Invalid");
            }
        }

        [Header("AS04 - Print Reverse Linked List")]
        [SerializeField] private IntLinkedListInput as04List = new IntLinkedListInput();

        public void AS04_PrintReverseLinkedList()
        {
            LinkedList<int> list = as04List.GetLinkedList();
            if (list.Count == 0)
            {
                Debug.Log("List is empty");
                return;
            }
                       
            LinkedListNode<int> current = list.Last;
                      
            while (current != null)
            {
                Debug.Log(current.Value);

                current = current.Previous;
            }
        }

        [Header("AS05 - Find Middle Element")]
        [SerializeField] private StringLinkedListInput as05List = new StringLinkedListInput();

        public void AS05_FindMiddleElement()
        {
            LinkedList<string> list = as05List.GetLinkedList();
            if (list.Count == 0)
            {
                Debug.Log("List is empty");
                return;
            }
                      
            LinkedListNode<string> slow = list.First;
            LinkedListNode<string> fast = list.First;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }
                       
            Debug.Log(slow.Value);
        }

        [Header("AS06 - Merge Dictionaries")]
        [SerializeField] private StringIntDictionaryInput as06FirstDictionary = new StringIntDictionaryInput();
        [SerializeField] private StringIntDictionaryInput as06SecondDictionary = new StringIntDictionaryInput();

        public void AS06_MergeDictionaries()
        {
            Dictionary<string, int> dict1 = as06FirstDictionary.GetDictionary();
            Dictionary<string, int> dict2 = as06SecondDictionary.GetDictionary();
            Dictionary<string, int> mergedDictionary = new Dictionary<string, int>(dict1);

            foreach (KeyValuePair<string, int> pair in dict2)
            {
                string key = pair.Key;
                int value = pair.Value;

                if (mergedDictionary.ContainsKey(key))
                {
                    mergedDictionary[key] = mergedDictionary[key] + value;
                }
                else
                {
                    mergedDictionary.Add(key, value);
                }
            }

            foreach (KeyValuePair<string, int> pair in mergedDictionary)
            {
                Debug.Log("key: " + pair.Key + ", value: " + pair.Value);
            }
        }

        [Header("AS07 - Remove Duplicates From Linked List")]
        [SerializeField] private IntLinkedListInput as07List = new IntLinkedListInput();

        public void AS07_RemoveDuplicatesFromLinkedList()
        {
            LinkedList<int> list = as07List.GetLinkedList();
                        
            if (list.Count == 0)
            {
                Debug.Log("Input array is empty");
                return;
            }
            Dictionary<int, int> numberCount = new Dictionary<int, int>();
                        
            foreach (int value in list)
            {
                if (numberCount.ContainsKey(value))
                {
                    numberCount[value]++;
                }
                else
                {
                    numberCount.Add(value, 1);
                }
            }
                        
            int mostFrequentNumber = list.First.Value;
            int maxCount = numberCount[mostFrequentNumber];

            foreach (int value in list)
            {
                if (numberCount[value] > maxCount)
                {
                    mostFrequentNumber = value;
                    maxCount = numberCount[value];
                }
            }

            Debug.Log(mostFrequentNumber + " count: " + maxCount);
        }

        [Header("AS08 - Top Frequent Number")]
        [SerializeField] private int[] as08Numbers;

        public void AS08_TopFrequentNumber()
        {
            int[] numbers = as08Numbers;
            throw new System.NotImplementedException();
        }

        [Header("AS09 - Player Inventory")]
        [SerializeField] private StringIntDictionaryInput as09Inventory = new StringIntDictionaryInput();
        [SerializeField] private string as09ItemName;
        [SerializeField] private int as09Quantity;

        public void AS09_PlayerInventory()
        {
            Dictionary<string, int> inventory = as09Inventory.GetDictionary();
            string itemName = as09ItemName;
            int quantity = as09Quantity;
            throw new System.NotImplementedException();
        }

        [Header("AS10 - Game Event Queue")]
        [SerializeField] private GameEventLinkedListInput as10EventQueue = new GameEventLinkedListInput();

        public void AS10_GameEventQueue()
        {
            LinkedList<GameEvent> eventQueue = as10EventQueue.GetLinkedList();
            throw new System.NotImplementedException();
        }

        [Header("AS11 - Player Stats Tracker")]
        [SerializeField] private StringIntDictionaryInput as11PlayerStats = new StringIntDictionaryInput();
        [SerializeField] private string as11StatName;
        [SerializeField] private int as11Value;

        public void AS11_PlayerStatsTracker()
        {
            Dictionary<string, int> playerStats = as11PlayerStats.GetDictionary();
            string statName = as11StatName;
            int value = as11Value;
            throw new System.NotImplementedException();
        }

        #endregion
    }
}