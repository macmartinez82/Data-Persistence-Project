using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{

    public MainManager MainScore;
    public PlyrName PlyrNameBS;
    public Text BestScoreText;
    void Start()
    {

    }

    void Update()
    {
        BestScoreUpdated(1);
    }

    void BestScoreUpdated(int score)
    {
        BestScoreText.text = $"Best Score: {PlyrNameBS.PlyName} : {MainScore.m_Points}";
    }

}
/*
    public MainManager MainScore;
    public PlyrName PlyrNameBS;
    public Text BestScoreText;
    void Start()
    {
        
    }

    void Update()
    {
        BestScoreUpdated(1);
    }

    void BestScoreUpdated(int score)
    {
        BestScoreText.text = $"Best Score: {PlyrNameBS.PlyName} : {MainScore.m_Points}";
    }*/