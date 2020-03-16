using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterestSlider : MonoBehaviour
{
    private Objective date;
    [SerializeField] protected GameManager gameManager;
    Slider slider;
    private float interestSlider;
   
    void Start()
    {
        date = gameManager.Date;
        slider = GetComponent<Slider>();
        slider.maxValue = date.Interest;
        interestSlider = date.Interest;
    }

    
    void Update()
    {
        interestSlider = date.Interest;
        slider.value = date.Interest;
        date = gameManager.Date;
    }
   
}
