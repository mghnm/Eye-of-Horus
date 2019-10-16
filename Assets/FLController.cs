using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FLController : MonoBehaviour
{
    
   
   
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Something has entered the finishline");

        if (other.tag == "Player")
        {

            Application.Quit();

        }

    }
}
