using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldManager : MonoBehaviour
{
    public InputField InpuText;

    private void Start()
    {
        InpuText.text = Scoremanager.instance.PlyName;
        InpuText.onEndEdit.AddListener(UpdateName);

    }
    void UpdateName(string value)
    {
        Scoremanager.instance.PlyName = value;
    }

}