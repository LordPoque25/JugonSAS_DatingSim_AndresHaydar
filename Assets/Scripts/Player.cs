using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    [SerializeField] float score;
    [SerializeField] Text scoreText;

    public float Score { get => score; set
    {
        if (score < 0)
            {
            score = 0;
            }
        else
            {
                score = value;
            }
        }
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        scoreText.text = score.ToString();        
    }
}
