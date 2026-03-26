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
        // Save the text to use in another scene...
        PlayerPrefs.SetString("StoredText", value);
        PlayerPrefs.Save();
        
        Debug.Log("Stored text: " + value );
    }
}
