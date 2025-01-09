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
    public String PlyName;
    public InputField InputField;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);

        InputField.onEndEdit.AddListener(NewName);
    }

   public void NewName(string InputName)
    {
       PlyName = InputName;
    }

}