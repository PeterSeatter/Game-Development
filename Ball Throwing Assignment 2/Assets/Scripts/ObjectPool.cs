using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : Singleton<ObjectPool>
{
    public static ObjectPool current;
    public GameObject PooledObject;
    public int PooledAmount = 20;
    public bool WillGrow = true;

    public List<GameObject> PooledObjects;

    private void Awake()
    {
        current = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        PooledObjects = new List<GameObject>();
        for (int i = 0; i < PooledAmount; i++)
        {
            GameObject newBall = (GameObject)Instantiate(PooledObject);
            newBall.SetActive(false);
            PooledObjects.Add(newBall);

        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < PooledObjects.Count; i++)
        {
            if (!PooledObjects[i].activeInHierarchy)
            {
                return PooledObjects[i];
            }
        }
        if (WillGrow)
        {
            GameObject newBall = (GameObject)Instantiate(PooledObject);
            PooledObjects.Add(newBall);
            return newBall;
        }
        return null;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
