using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameSaver : MonoBehaviour
{
    public static string playerName;
    public TMP_InputField nameInput;

    public void UpdateName()
    {
        playerName = nameInput.text;
    }
    public void Save()
    {
        PlayerPrefs.SetString("Name", playerName);
    }
}
