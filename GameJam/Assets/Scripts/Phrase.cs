using UnityEngine;
using System.Collections;
using System;
using System.IO;
using UnityEngine.UI;
using UnityEngine;
public class Phrase : MonoBehaviour
{
    public Text phrase;

    public void Start()
    {
        System.Random a = new System.Random();
        string fileName = "Assets/Scripts/file.txt";
        string[] lines = File.ReadAllLines(fileName);
        phrase.text = lines[a.Next(6)];
    }
}