using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class chickenWidsom : MonoBehaviour {

    public Text proverbText;
    float timer = 0.0f;
    float wait = 20.0f;

    public string path;
    StreamReader reader;
    string line;
    // Use this for initialization
    void Start () {
        path = "Assets/scripts/chicken_wisdom.dat";
        reader = new StreamReader(path);
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > wait)
        {
            timer = timer - wait;
            StartCoroutine(fadeOut());
        }
    }

    private string getWisdom()
    {
        line = reader.ReadLine();
        if (line == null)
        {
            reader.BaseStream.Position = 0;
            reader.DiscardBufferedData();
            line = reader.ReadLine();       
        }
        return line;
    }

    IEnumerator fadeOut()
    {
        Color textColor = proverbText.color;
        while(textColor.a > 0.0f) {
            textColor.a -= 0.05f;
            proverbText.color = textColor;
            yield return null;
        }
        proverbText.text = getWisdom();
        StartCoroutine(fadeIn());
    }

    IEnumerator fadeIn()
    {
        Color textColor = proverbText.color;
        while(textColor.a < 1.0f)
        {
            textColor.a += 0.05f;
            proverbText.color = textColor;
            yield return null;
        }
    }
}
