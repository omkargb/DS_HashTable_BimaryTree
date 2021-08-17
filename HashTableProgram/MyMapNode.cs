using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableProgram
{
    class MyMapNode<K, V>
    {
        public struct KeyValue<k, v>
        {
            public K Key { get; set; }
            public V Value { get; set; }
        }

         int listSize;
         LinkedList<KeyValue<K, V>>[] items;

        public MyMapNode(int listSize)
        {
            this.listSize = listSize;
            this.items = new LinkedList<KeyValue<K, V>>[listSize];
        }

        public int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % listSize;
            return Math.Abs(position);
        }

        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }

        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            linkedList.AddLast(item);
        }

        public LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }

        public int GetFrequencyOfWords(V value)
        {
            int count = 0;
            if (items == null)
            {
                Console.WriteLine(" Hash Table is Empty..");
                return 0;
            }
            for (int i = 0; i < items.Length; i++)
            {
                LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(i);
                foreach (KeyValue<K, V> item in linkedList)
                {
                    if (item.Value.Equals(value))
                        count++;
                }
            }
            return count;
        }
    }
}

