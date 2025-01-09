using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlyrName : MonoBehaviour
{
    public Text NameMain;
    public MainManager Manager;
    public string PlyName;

    private void Start()
    {
        Scoremanager scoremanager = FindAnyObjectByType<Scoremanager>();
        PlyName = scoremanager.PlyName;
    }

    private void Update()
    {
        NameMain.text = $"{PlyName}";
    }

}