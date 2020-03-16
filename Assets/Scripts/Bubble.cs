using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bubble : MonoBehaviour
{    
    private float scoreAdd;    
    public abstract void ScoreAdding();
    public float scoreValue;
    public float speed;
    public abstract void movement();    

    [SerializeField] protected Player player;
    [SerializeField] protected GameManager gameManager;
    protected Objective date;    

    private float score;
    private Bubble dateHate;
    private Bubble datePreference;
    private Bubble dateDislike;
    private float interest;

    public Bubble DatePreference { get => datePreference; set => datePreference = value; }
    public Bubble DateHate { get => dateHate; set => dateHate = value; }
    public Bubble DateDislike { get => dateDislike; set => dateDislike = value; }
    public float Score { get => score; set => score = value; }
    public float Interest { get => interest; set => interest = value; }
    public float ScoreAdd { get => scoreAdd; set => scoreAdd = value; }
    public Player Player { get => player; set => player = value; }
    public Objective Date { get => date; set => date = value; }

    private void Start()
    {
        score = Player.Score;              
        interest = date.Interest;        
    }

    public void SetPreferences()
    {
        date = gameManager.Date;
        DatePreference = date.PreferedTrait;
        DateHate = date.DislikedTrait;
        DateDislike = date.HatedTrait;
        Debug.Log("my preference is " + datePreference);
        Debug.Log("My hated is " + dateHate);
        Debug.Log("My disliked is " + dateDislike);

    }
    
}
