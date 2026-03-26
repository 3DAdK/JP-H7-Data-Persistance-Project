using TMPro;
using UnityEngine;

public class DisplayText : MonoBehaviour
{
    public TMP_Text textUI;

    void Start()
    {
        string storedText = PlayerPrefs.GetString("StoredText", "No text saved");
        textUI.text = storedText;
    }
}
