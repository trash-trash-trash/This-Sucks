using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(TrailRenderer))]
public class ThisSucksPlayerGraphics : MonoBehaviour
{
    //this script controls the Player's Graphics

    //currently
    //Cigarette GameObject, Cigarette Smoke ParticleSystem

    //later
    //such as equipped object(s), hair and clothes variables

    Renderer cigObj;
    TrailRenderer cigSmoke;
    bool smoking;

    int smokingInt;



    private void Start()
    {
        int smokingInt = PlayerPrefs.GetInt("Smoking");

        cigObj = this.GetComponent<Renderer>();






        cigSmoke = this.GetComponent<TrailRenderer>();











        //if (smokingInt == 1)
        //{
       //     smoking = true;
       // }
       // else 
       // {
       //     smoking = false;
       // }

    }

    //ParticleSystem.Particle.startColor


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
            ToggleCig();

        switch (smoking)
        {
            case false:
                cigSmoke.enabled = false;
                cigObj.enabled = false;
                break;

            case true:
                cigSmoke.enabled = true;
                cigObj.enabled = true;
                break;
        }
    }
public void ToggleCig()
    {
        smoking = !smoking;
    }
}

    