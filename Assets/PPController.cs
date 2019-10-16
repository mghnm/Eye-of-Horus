using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPController : MonoBehaviour
{   public bool isTriggered = false;
    private AudioSource source;
    private SpriteRenderer spriterenderer;
    public Sprite pPTriggered;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        spriterenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other) {
        Debug.Log("Something has entered the trigger");

        if (other.tag == "Player" && !isTriggered && Input.GetButton("Fire1")) {
            isTriggered = true;
            spriterenderer.sprite = pPTriggered;
            source.Play();
            Destroy(GameObject.Find("Pillar"), source.clip.length);


        }

    }
}
