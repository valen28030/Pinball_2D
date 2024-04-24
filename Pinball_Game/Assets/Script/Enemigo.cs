using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restar : MonoBehaviour
{
    public Pinball ninja;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        ninja.RestarScore();
        this.GetComponent<SpriteRenderer>().color = Color.red;
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        this.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
