using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldManager : MonoBehaviour
{
    public InputField inputField;
    void Start()
    {
        inputField.text = Scoremanager.instance.PlyrName;
        inputField.onEndEdit.AddListener(UpdateName);
    }

    private void UpdateName(string value)
    {
        Scoremanager.instance.PlyrName = value;
    }
}
