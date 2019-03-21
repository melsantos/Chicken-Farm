using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalTeleport : MonoBehaviour {

    public GameObject teleportTo;
    public string message;
    public AudioClip happyClucks;
    public AudioClip angryClucks;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (collect.score >= 5)
        {
            other.transform.position = teleportTo.transform.position;
            message = "Congratulation!";
            AudioSource.PlayClipAtPoint(happyClucks, other.transform.position);
            AudioSource.PlayClipAtPoint(angryClucks, other.transform.position);
        }
        else
        {
            message = "You haven't gathered all the chickens!";
        }
        
    }
}
