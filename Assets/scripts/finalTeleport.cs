using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalTeleport : MonoBehaviour {

    public GameObject teleportTo;
    public string message;
    public AudioClip happyClucks;
    public AudioClip angryClucks;
    public TextMesh textMesh;

    // Use this for initialization
    void Start () {
        textMesh = GameObject.Find("FirstPersonCharacter").GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (collect.score >= 5)
        {
            other.transform.position = teleportTo.transform.position;
            textMesh.text = "Congratulations!";
            AudioSource.PlayClipAtPoint(happyClucks, other.transform.position);
            AudioSource.PlayClipAtPoint(angryClucks, other.transform.position);
        }
        else
        {
            textMesh.text = "You haven't gathered all the chickens!";
            Invoke("Score", 2f);
        }
        
    }

    void Score()
    {
        textMesh.text = "Score: " + collect.score;
    }
}
