using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour {

    static public int score;
    public TextMesh textMesh;
    public AudioClip caughtCluck;

	// Use this for initialization
	void Start () {
        score = 0;
        // textMesh = GameObject.Find("FirstPersonCharacter").GetComponent<TextMesh>(); // FPS Controller
        textMesh = GameObject.Find("CenterEyeAnchor").GetComponent<TextMesh>(); // OVR
    }

    // Update is called once per frame
    void Update () {

	}

    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.SetActive(false);
        score++;
        textMesh.text = "Score: " + score;
        AudioSource.PlayClipAtPoint(caughtCluck, other.transform.position);
        //Debug.Log("Score: " + score);
    }
}
