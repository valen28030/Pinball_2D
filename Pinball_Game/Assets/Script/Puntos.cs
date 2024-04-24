using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntos : MonoBehaviour
{
    public Pinball pinball;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        pinball.AddScore();
        this.GetComponent<SpriteRenderer>().color = Color.blue;
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        this.GetComponent<SpriteRenderer>().color = Color.white;
    }


}
