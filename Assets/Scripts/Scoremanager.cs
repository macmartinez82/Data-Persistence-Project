using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Scoremanager : MonoBehaviour
{
    public static Scoremanager instance;
    public String PlyrName;
    public InputField inputField;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);

        PlyrName = "NameTEst";
        inputField.onValueChanged.AddListener(UpdatePlayerName);
    }

    public void UpdatePlayerName(string input)
    {
        PlyrName = input;
        Debug.Log("Player Name Updated: " + PlyrName);
    }

}
    

