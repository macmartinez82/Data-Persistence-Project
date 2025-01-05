using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{

    public void StartGame(int Scene)
    {
        SceneManager.LoadScene(Scene);
    }

    public void ExitGame()
    {
        EditorApplication.ExitPlaymode();
    }
}
