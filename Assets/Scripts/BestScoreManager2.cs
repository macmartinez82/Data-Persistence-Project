using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScoreManager2 : MonoBehaviour
{

    public Text BestScoreDisplay2;
    public Text MenuPlyr2;
    public MainManager IntScore2;

    private string PlyrBS2 = "";
    private int ScoreBS2 = 0;

    private void Start()
    {
        BestScoreDisplay2.text = $"Best Score: {PlyrBS2}{ScoreBS2}";

        PlyrBS2 = PlayerPrefs.GetString("PlayerUpdated2", "");
        ScoreBS2 = PlayerPrefs.GetInt("HGScore2", 0);

        BestScoreDisplay2.text = $"Best Score: {PlyrBS2}{ScoreBS2}";

    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            ResetScore();
        }

    }
    public void BestScoreUpdate()
    {
        if (IntScore2.m_Points > ScoreBS2)
        {
            ScoreBS2 = IntScore2.m_Points;
            PlyrBS2 = MenuPlyr2.text;

            BestScoreDisplay2.text = $"Best Score: {PlyrBS2}{ScoreBS2}";

            PlayerPrefs.SetString("PlayerUpdated2", PlyrBS2);
            PlayerPrefs.SetInt("HGScore2", ScoreBS2);
            PlayerPrefs.Save();
        }
    }

    void ResetScore()
    {
        PlayerPrefs.DeleteKey("PlayerUpdated2");
        PlayerPrefs.DeleteKey("HGScore2");
        PlayerPrefs.Save();

        PlyrBS2 = "";
        ScoreBS2 = 0;
        BestScoreDisplay2.text = $"Best Score: {PlyrBS2}{ScoreBS2}";
    }
}
