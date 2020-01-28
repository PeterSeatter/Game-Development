using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager> 
{

    private float _timePassed;

    public float TimePassed
    {
        get { return _timePassed; }
        set { _timePassed = value; }
    }

    public float maxTimeSeconds = 5 * 60; // In seconds.


    void Start()
    {
        TimePassed = 0;
    }

    void Update()
    {
        TimePassed += Time.deltaTime;

        if (TimePassed >= maxTimeSeconds)
        {
            TimePassed = 0; // maxTimeSeconds;
            SceneManager.LoadScene(0);
        }
    }
}


