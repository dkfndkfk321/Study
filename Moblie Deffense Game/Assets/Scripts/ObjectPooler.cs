using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{

    
    public GameObject pooledObject;

    private List<GameObject> pooledObjects;
    public int poolCount = 28;
    public bool more;
  

    // Start is called before the first frame update
    void Start()
    {
        pooledObjects = new List<GameObject>();
        while(poolCount > 0)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject);
            obj.SetActive(false);
            pooledObjects.Add(obj);
            poolCount--;
            GameManager.instance.bulletAddCount++;

        }
    }

    public GameObject getObject()
    {
        foreach(GameObject obj in pooledObjects)
        {
            if (!obj.activeInHierarchy)
            {
                return obj;
            }
            
        }
        if (more)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject);
            pooledObjects.Add(obj);
            GameManager.instance.bulletAddCount++;
            return obj;
        }
        return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
