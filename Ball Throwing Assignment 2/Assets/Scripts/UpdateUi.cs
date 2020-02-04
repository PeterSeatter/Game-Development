using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateUi : Singleton<UpdateUi>
{
    public Text ScoreText;
    public static int ScoreDisplay;
    public Text LevelText;
    public static int LevelDisplay;
    public Text TimeText;
    public static float TimeDisplay1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SetScore(0);    
        SetLevel(0);
        TimeDisplay();
    }

    /// This sets the sore and it will records it from the player and then display for the player to see.
    public void SetScore(int prSetScore)
    {
        try
        {
            ScoreDisplay = Player.Instance.Score;
            string DisplayScore = ("Score: " + ScoreDisplay);
            ScoreText.GetComponent<Text>().text = DisplayScore;
            ScoreText.text = "Score: " + Player.Instance.Score.ToString();
        }
        catch (System.Exception e)
        {
            Debug.Log(e.Message + "This New Score isn't working");
        }
    }

    /// This is a method which will allow for the Level to be set and shown to the player
    public void SetLevel(int prLevelToAdd)
    {
        try
        {
            LevelDisplay = Player.Instance.Level;
            string Displaylevel = ("Level: " + LevelDisplay);
            LevelText.GetComponent<Text>().text = Displaylevel;
            LevelText.text = "Level: " + Player.Instance.Level.ToString();

            try
            {
                // It looks at the ScoreDisplay and then uses modulus at every 1000points and it equals zero and the ScoreDisplay isn't equal to zero it will increase the level
                if ((ScoreDisplay % 1000) == 0 && ScoreDisplay != 0)
                {
                    Player.Instance.IncreaseLevel();
                }
            }
            catch (System.Exception d)
            {

                Debug.Log(d.Message + " This Level count isn't working");
            }
 
        }
        catch (System.Exception e)
        {
            Debug.Log(e.Message + " This New Level isn't working");
        }
    }

    public void TimeDisplay()
    {
        try
        {
            TimeDisplay1 = GameManager.Instance.TimePassed;
            string DisplayTime = ("Time: " + LevelDisplay);
            TimeText.GetComponent<Text>().text = DisplayTime;
            TimeText.text = "Time: " + GameManager.Instance.TimePassed.ToString("F0");

        }
        catch (System.Exception t)
        {

            Debug.Log(t.Message + " Time isn't correctly counting");
        }

    }
}