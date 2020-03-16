using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Love : Bubble
{
    public override void movement()
    {
        gameObject.transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
    }


    void Start()
    {
     
    }
    
    void Update()
    {
        movement();
    }

    public override void ScoreAdding()
    {
        if (DatePreference is Love)
        {            
            player.Score = player.Score + (scoreValue + (scoreValue * 0.2f));
        }
        else if (DateDislike is Love)
        {
            player.Score = player.Score + (scoreValue * 0.55f);
        }
        else if (DateHate is Love)
        {
            player.Score = player.Score + (scoreValue * 0.55f);
            date.Interest = date.Interest - (date.Interest * 0.02f);
        }
        else
        {
            player.Score = player.Score + (scoreValue);
        }

        Debug.Log(player.Score);
    }

    private void OnMouseDown()
    {
        ScoreAdding();
        gameObject.SetActive(false);
    }
}
