using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intimacy : Bubble

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
        date.Interest = date.Interest + (date.Interest * 0.02f);
    }

    private void OnMouseDown()
    {
        ScoreAdding();
        gameObject.SetActive(false);
    }

}