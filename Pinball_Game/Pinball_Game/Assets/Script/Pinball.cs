using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class Pinball : MonoBehaviour
{
   
    public Animator rightPalaAnimator;
    public Animator leftPalaAnimator;
    public Text puntosTexto;
    private int puntos = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rightPalaAnimator.SetInteger("Pressed", 1);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            leftPalaAnimator.SetInteger("Pressed", 1);
        }
        else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {

            rightPalaAnimator.SetInteger("Pressed", 2);
        }
        else if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            leftPalaAnimator.SetInteger("Pressed", 2);
        }

        
        if (puntos >= 100) {
            SceneManager.LoadScene(0);
        }
    }
    public void AddScore()
    {   
        puntos += 10;
        puntosTexto.text = "SCORE: " + puntos;
    }

    public void RestarScore()
    {
        puntos -= 5;
        if (puntos < 0) {
            puntos = 0;
        }
        puntosTexto.text = "SCORE: " + puntos;
    }

    
}
