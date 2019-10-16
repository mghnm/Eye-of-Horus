using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour {
    private AudioSource coinsrc;
    private Renderer rend;
	// Use this for initialization
	void Start () {
        coinsrc = GetComponent<AudioSource>();
        rend = GetComponent<Renderer>();
        rend.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") {
            coinsrc.Play();
            rend.enabled = false;
            scoreScript.scoreValue += 100;
            Destroy(gameObject, coinsrc.clip.length);
            
            


        }
    }
}
