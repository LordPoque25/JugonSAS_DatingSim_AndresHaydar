using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSlider : MonoBehaviour
{
    [SerializeField] Player player;
    private Objective date;
    [SerializeField] protected GameManager gameManager;
    Slider Slider; 

    void Start()
    {
        Slider = GetComponent<Slider>();
        date = gameManager.Date;
        Slider.maxValue = date.Expectation;
    }


    void Update()
    {
        Slider.value = player.Score;        
    }
    
}
