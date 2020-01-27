using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateUi : MonoBehaviour{

    public Text ScoreText;
    public static int ScoreDisplay = 0;
    private Player playerScript;

	// Use this for initialization
    void Start () 
    {
        SetScore(0);
	}

    void Awake()
    {
        playerScript = GetComponent<Player>();
    }
	
	// Update is called once per frame
	void Update () {

	}

    public void SetScore(int prScoreToAdd)
    {
        try
        {
            //Player NewScore = GetComponent<Player>();
            //ScoreDisplay = NewScore.Score;
            ScoreDisplay = playerScript.Score;
        }
        catch (System.Exception)
        {
            Debug.Log("This New Score isn't working");
        }
            string DisplayScore = ("Score: " + ScoreDisplay);
            ScoreText.GetComponent<Text>().text = DisplayScore;

    }
}
