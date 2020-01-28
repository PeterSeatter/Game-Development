using UnityEngine;
using UnityEngine.UI;

public class UpdateUi : Singleton<UpdateUi>
{

    public Text ScoreText;
    public static int ScoreDisplay = 0;
    public Text LevelText;
    public static int LevelDisplay = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SetScore(0);
        SetLevel(0);
    }

    public void SetScore(int prScoreToAdd)
    {
        try
        {
            ScoreDisplay = Player.Instance.Score;
            ScoreDisplay = Player.Instance.Score;
            string DisplayScore = ("Score: " + ScoreDisplay);
            ScoreText.GetComponent<Text>().text = DisplayScore;
            ScoreText.text = Player.Instance.Score.ToString();
        }
        catch (System.Exception e)
        {
            Debug.Log(e.Message + "This New Score isn't working");
        }
    }

    public void SetLevel(int prLevelToAdd)
    {
        try
        {
            LevelDisplay = Player.Instance.Level;
            string Displaylevel = ("Score: " + LevelDisplay);
            LevelText.GetComponent<Text>().text = Displaylevel;
            LevelText.text = Player.Instance.Level.ToString();
        }
        catch (System.Exception e)
        {
            Debug.Log(e.Message + "This New Level isn't working");
        }

    }
}
