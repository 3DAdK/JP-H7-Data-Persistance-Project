using TMPro;
using UnityEngine;

public class SavePlayerName : MonoBehaviour

{
    public TMP_InputField inputField;
    private string storedText;

    void Start()
    {
        // Add listener for when text changes
        inputField.onValueChanged.AddListener(OnTextChanged);
    }

    void OnTextChanged(string value)
    {
        storedText = value;
        Debug.Log("Stored text: " + storedText);
    }
}
