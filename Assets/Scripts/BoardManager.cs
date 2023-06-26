using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BoardManager : MonoBehaviour
{
    [SerializeField] List<Button> keyboardButtons = new List<Button>();

    string keyboardChararcter = "QWERTYUIOPASDFGHJKLZXCVBNM";
    // Start is called before the first frame update
    void Start()
    {
        KeyboardSetup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void KeyboardSetup()
    {
        for(int i = 0; i < keyboardButtons.Count; i++)
        {
            keyboardButtons[i].transform.GetChild(0).GetComponent<TMP_Text>().text = keyboardChararcter[i].ToString();
        }

        foreach(var keyboardButton in keyboardButtons)
        {
            string letter = keyboardButton.transform.GetChild(0).GetComponent<TMP_Text>().text;
            keyboardButton.GetComponent<Button>().onClick.AddListener(() => ClickButton(letter));
        }
    }

    void ClickButton(string letter)
    {
        Debug.Log(letter);
        
    }
}
