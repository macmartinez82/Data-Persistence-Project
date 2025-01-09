using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BSCoreMenu : MonoBehaviour
{
    public Text BScoreUpdated;

    void Start()
    {
        int BScoreMain = PlayerPrefs.GetInt("HGScore2", 0);
        string BSPlyrName = PlayerPrefs.GetString("PlayerUpdated2", "");

        BScoreUpdated.text = $"Best Score: {BSPlyrName}{BScoreMain}";


    }
}
