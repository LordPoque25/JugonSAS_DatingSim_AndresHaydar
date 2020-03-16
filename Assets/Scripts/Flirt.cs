using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flirt : Bubble
{           

    void Start()
    {
     
    }

    
    void Update()
    {
        movement();
    }


    public override void ScoreAdding()
    {
        if (DatePreference is Flirt)
        {
            Debug.Log("My preferense is " + DatePreference);
            player.Score = player.Score + (scoreValue + (scoreValue * 0.2f));
        }
        else if (DateDislike is Flirt)
        {
            player.Score = player.Score + (scoreValue * 0.55f);
        }
        else if (DateHate is Flirt)
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

    public override void movement()
    {
        gameObject.transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
    }

    private void OnMouseDown()
    {
        ScoreAdding();
        gameObject.SetActive(false);
    }

}
