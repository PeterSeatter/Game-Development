using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static bool m_ShuttingDown = false;
    private static object m_lock = new object();
    private static T m_Instance;

    public static T Instance
    {
        get
        {
            if (m_ShuttingDown)
            {
                Debug.LogWarning("[Singleton] Instance " + typeof(T) + " already destoryed. Returing null.");
                return null;
            }

            lock (m_lock)
            {
                if (m_Instance == null)
                {
                    m_Instance = (T)FindObjectOfType(typeof(T));
                    if (m_Instance == null)
                    {
                        var singletonObject = new GameObject();
                        m_Instance = singletonObject.AddComponent<T>();
                        singletonObject.name = typeof(T).ToString() + " (Singleton)";

                        DontDestroyOnLoad(singletonObject);
                    }
                }
                return m_Instance;
            }
        }
    }

    private void OnApplicationQuit()
    {
        m_ShuttingDown = true;
    }

    private void OnDestory()
    {
        m_ShuttingDown = true;
    }
}
//public class Singleton : MonoBehaviour
//{
//    private static Singleton _instance;

//    public static Singleton Instance {get { return _instance; } }

//    public int Score;

//    private void Awake()
//    {
//        if (_instance != null && _instance != this)
//        {
//            Destroy(this.gameObject);
//        } else
//        {
//            _instance = this;
//        }
//    }

//    // Start is called before the first frame update
//    //void Start()
//    //{
        
//    //}

//    //// Update is called once per frame
//    //void Update()
//    //{
        
//    //}
//}
