using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text interestText;
    [SerializeField] Text affectionText;
    [SerializeField] Text affectionBubblesText;
    private int affectionBubblesCount;
    private int affectionBonusCount;
    List<Bubble> bubble;
    private Objective date;
    [SerializeField] Player player;
    [SerializeField] Flirt flirt;
    [SerializeField] Love love;
    [SerializeField] Intelligence intelligence;
    [SerializeField] Objective date1;
    [SerializeField] Objective date2;
    [SerializeField] Objective date3;

    public Objective Date { get => date; set => date = value; }

    private void Start()
    {
        affectionBonusCount = 0;
        affectionBubblesCount = 1;
    }

    private void Update()
    {
        interestText.text = date.Interest.ToString();

        if (player.Score >= date.Expectation)
        {
            Winning();
        }

        if (Date.Interest <= 1)
        {
            Losing();
        }
    }

    public int AffectionBubblesCount
    {
        get { return affectionBubblesCount; }
        set
        {
            if (affectionBubblesCount >= 10)
            {
                AffectionBonus();
                AffectionBonusCount += 1;
                affectionText.text = affectionBonusCount.ToString();
                affectionBubblesText.text = affectionBubblesCount.ToString();
                affectionBubblesCount = 0;
            }
            else
            {
                affectionBubblesText.text = affectionBubblesCount.ToString();
                affectionText.text = AffectionBonusCount.ToString();
                affectionBubblesCount = value;
            }
        }
    }


    public int AffectionBonusCount
        {
            get { return affectionBonusCount; }
            set
            {
                if (affectionBonusCount <=10)
                {
                    affectionBonusCount = value;
                }            
            }
        }


    public void AffectionBonus()
        {        
            if (affectionBonusCount <= 10)
            {
            flirt.scoreValue = flirt.scoreValue + (flirt.scoreValue * 0.05f);
            love.scoreValue = love.scoreValue + (love.scoreValue * 0.05f);
            intelligence.scoreValue = intelligence.scoreValue + (intelligence.scoreValue * 0.05f);
            }        
        }
        

    public void Winning()
    {
        SceneManager.LoadScene("Win");     
    }

    public void Losing()
    {
        SceneManager.LoadScene("Lose");
    }

    public void DateSelector(Objective date)
    {
        this.date = date;
    }

    public void selectDate1()
    {
        DateSelector(date1);
    }

    public void selectDate2()
    {
        DateSelector(date2);
    }

    public void selectDate3()
    {
        DateSelector(date3);
    }    



}


