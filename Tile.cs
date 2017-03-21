using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    public GameManager gameManager;
    public AudioClip beep;
    AudioSource source;

	void Start () {
        source = GetComponent<AudioSource>();
	}
	
	void Update () {
		
	}
    
    void OnTriggerEnter(Collider other)
    {
        gameManager.AddPoint();
        source.PlayOneShot(beep);
    }
}
