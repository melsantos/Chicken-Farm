using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomCluck : MonoBehaviour {

    AudioSource audioData;
    float timer = 0.0f;
    float cluckTime = 1.0f;

	// Use this for initialization
	void Start () {
        audioData = GetComponent<AudioSource>();
        cluckTime = Random.Range(3.0f, 5.0f);
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > cluckTime)
        {
            cluckTime = Random.Range(3.0f, 5.0f);
            timer = timer - cluckTime;
            audioData.Play();
        }
	}
}
