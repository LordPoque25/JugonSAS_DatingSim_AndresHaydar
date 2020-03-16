using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Affection : Bubble

{   

    void Start()
    {
      
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
        Debug.Log(gameManager.AffectionBonusCount);
        Debug.Log(gameManager.AffectionBubblesCount);
        gameManager.AffectionBubblesCount += 1;
    }

    private void OnMouseDown()
    {        
        ScoreAdding();
        gameObject.SetActive(false);
    }
    
}