using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objective : MonoBehaviour
{    
    [SerializeField] float interest;
    private float inicialInterest;
    [SerializeField] float expectation;
    [SerializeField] Bubble preferedTrait;
    [SerializeField] Bubble dislikedTrait;
    [SerializeField] Bubble hatedTrait;

    public Bubble HatedTrait { get => hatedTrait; set => hatedTrait = value; }
    public Bubble DislikedTrait { get => dislikedTrait; set => dislikedTrait = value; }
    public Bubble PreferedTrait { get => preferedTrait; set => preferedTrait = value; }
    public float Interest { get => interest; set => interest = value; }
    public float Expectation { get => expectation; set => expectation = value; }
    public float InicialInterest { get => inicialInterest; set => inicialInterest = value; }

    void Start()
    {
        InicialInterest = interest;
    }


    void Update()
    {

    }
}
