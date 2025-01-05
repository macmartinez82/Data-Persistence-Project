using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlyrName : MonoBehaviour
{
    public Text Plyr;
    void Start()
    {
        Scoremanager PlyrTyp = FindObjectOfType<Scoremanager>();
        Plyr.text = PlyrTyp.PlyrName;
    }
}
