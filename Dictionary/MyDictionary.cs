using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TKey,TValue>
    {
        TKey[] keyType;
        TKey[] tempKey;
        TValue[] valueType;
        TValue[] tempValue;
        public MyDictionary()
        {
            keyType = new TKey[0];
            valueType = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            tempKey = keyType;
            keyType = new TKey[keyType.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keyType[i] = tempKey[i];
            }
            keyType[keyType.Length - 1] = key;

            tempValue = valueType;
            valueType = new TValue[valueType.Length + 1];
            for (int i = 0; i < tempValue.Length; i++)
            {
                valueType[i] = tempValue[i];
            }
            valueType[valueType.Length - 1] = value;
        }
        public int Count
        {
            get { return keyType.Length; }
        }
        public TKey[] Keys
        {
            get { return keyType; }
        }
        public TValue[] Values
        {
            get { return valueType; }
        }

    }
}
