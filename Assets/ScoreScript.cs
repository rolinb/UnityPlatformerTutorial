using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{

    public static int score = 0;
    public TextMeshPro score_text;
    // Start is called before the first frame update
    void Start()
    {
        score_text.text = "Score: ";
    }

    // Update is called once per frame
    void Update()
    {
        score_text.text = "Score: " + score;

    }
}
