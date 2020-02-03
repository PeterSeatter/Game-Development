using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Singleton<Player>
{
    public GameObject BallPrefab;
    public Vector3 BallOffset = new Vector3(0.5f, 0.5f, 0.5f); // offset from camera to create balls when throwing
    public int Score { get { return score; } }
    public int Level { get { return level; } }

    private int score;
    private int level;
    private int levelIncreaseNum = 1000;

    // Use this for initialization
    void Start()
    {
        score = 0;
        level = 0;
    }

    void FixedUpdate()
    {
        if (Time.frameCount % 2 == 0) // throw a ball every 2nd update
            ThrowBall();
    }

    private void ThrowBall()
    {
        // throw ball
        GameObject newBall = (GameObject)GameObject.Instantiate(BallPrefab, this.transform.position + BallOffset, this.transform.rotation);
        // add some randomness to throw vector
        Vector3 randVec = Random.insideUnitSphere;
        randVec.y *= 0.1f;
        // combine basic throw vector with randomness
        Vector3 throwVector = (new Vector3(-2f, 0.2f, 0f) + randVec) * 1400f;
        newBall.GetComponent<Rigidbody>().AddForce(throwVector);
    }

    public void IncreaseScore(int scoreChange)
    {
        score += scoreChange;
    }

    public void IncreaseLevel()
    {
        if (score % levelIncreaseNum == 0)
        {
            level++;
        }
    }
}