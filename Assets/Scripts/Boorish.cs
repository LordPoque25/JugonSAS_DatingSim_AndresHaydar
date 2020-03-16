using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boorish : Bubble

{
    void Start()
    {
     date = gameManager.Date;
    }

    public override void movement()
    {
        gameObject.transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
    }

    void Update()
    {
        movement();
    }

    public override void ScoreAdding()
    {

        float temporaryScore = player.Score - (scoreValue * 0.75f); ;

        date.Interest = date.Interest - (date.InicialInterest * 0.05f);
        if (player.Score - temporaryScore < 0)
        {
            player.Score = 0;
        }
        else
        {
            player.Score = player.Score - (scoreValue * 0.75f);
        }
    }

    private void OnMouseDown()
    {
        ScoreAdding();
        gameObject.SetActive(false);
    }

}