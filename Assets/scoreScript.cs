using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class scoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static int scoreValue = 0;
    private TextMeshProUGUI score;
    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue.ToString();
    }
}
