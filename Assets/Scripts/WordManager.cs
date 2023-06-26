using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class WordManager : MonoBehaviour
{
    [SerializeField] string correctWord;
    [SerializeField] List<Transform> wordBoxes = new List<Transform>();

    int currentWordBox;

    List<string> dictionary = new List<string>();
    List<string> words = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        AddWords("Assets/Resources/dictionary.txt", dictionary);
        
        AddWords("Assets/Resources/Wordlist.txt", words);

        correctWord = RandomWord();
    }

    void AddWords(string pathOfFile, List<string>listOfWords)
    {
        StreamReader streamReader = new StreamReader(pathOfFile);
        string text = streamReader.ReadToEnd();

        string[] singleWord = text.Split(new char[] { ',' });

        foreach(string word in singleWord)
        {
            listOfWords.Add(word);
        }

        streamReader.Close();
    }

    string RandomWord()
    {
        string randomWord = words[Random.Range(0, words.Count)];
        Debug.Log(randomWord);
        return randomWord;
    }

    public void LetterInBox(string letter)
    {
        wordBoxes[currentWordBox].GetChild(0).GetComponent<TMP_Text>().text = letter;
        currentWordBox++;
    }
}
