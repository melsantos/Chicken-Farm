using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleport : MonoBehaviour {

    public GameObject teleportTo;
    // float teleportHeight;

	// Use this for initialization
	void Start () {
        // teleportHeight = teleportTo.GetComponent<MeshCollider>().bounds.size.y / 2;
    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter(Collider other)
    {
        other.transform.position = teleportTo.transform.position;
        // other.transform.position += new Vector3(0, teleportHeight, 0);
        // Debug.Log(teleportHeight);
    }
}
