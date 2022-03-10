/// <summary>
/// https://leetcode.com/problems/lru-cache/
/// </summary>
/*
Design a data structure that follows the constraints of a Least Recently Used (LRU) cache.

Implement the LRUCache class:

LRUCache(int capacity) Initialize the LRU cache with positive size capacity.
int get(int key) Return the value of the key if the key exists, otherwise return -1.
void put(int key, int value) Update the value of the key if the key exists. Otherwise, add the key-value pair to the cache. If the number of keys exceeds the capacity from this operation, evict the least recently used key.
The functions get and put must each run in O(1) average time complexity.


*/
public class LRUCache {
    private Dictionary<int, int> dic;
    private List<int> list;
    private int cp; 
    public LRUCache(int capacity) {
        dic = new Dictionary<int, int>(capacity);
        list = new List<int>(capacity);
        cp = capacity;
    }
    
    public int Get(int key) {
        if(!dic.ContainsKey(key)) return -1;
        list.Remove(key);
        list.Insert(0, key);
        return dic[key];
    }
    
    public void Put(int key, int value) {
        if(!dic.ContainsKey(key)){
            if(cp == list.Count){
                int last = list.Last();
                list.Remove(last);
                dic.Remove(last);
            }
            list.Insert(0, key);
            dic.Add(key, value);
        }else{
            dic[key] = value;
            list.Remove(key);
            list.Insert(0, key);
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */