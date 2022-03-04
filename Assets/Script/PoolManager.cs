using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    [System.Serializable]
    public class ObjectPool
    {
        public string name;
        public GameObject prefab;
        public int amount;
        public Transform parent;
        public List<GameObject> pool;
    }
    
    public List<ObjectPool> listOfPool;

    public static PoolManager instance;

void Awake() 
{
    if (instance == null)
    {
        instance = this;
    }
    else
    {
        Destroy(this.gameObject);
    }
}

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < listOfPool.Count; i++)
        {
            GameObject obj;
            for(int a = 0; a < listOfPool[i].amount; a++)
            {
                obj = Instantiate(listOfPool[i].prefab);
                obj.SetActive(false);
                obj.transform.SetParent(listOfPool[i].parent);
                listOfPool[i].pool.Add(obj);
            }
        }
        
    }

    public GameObject GetPooledObject(int bulletType)
    {
        for(int i = 0; i < listOfPool[bulletType].amount; i++)
        {
            if(!listOfPool[bulletType].pool[i].activeInHierarchy)
            {
                return listOfPool[bulletType].pool[i];
            }
        }
        return null;
    }
}
