using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JiggleScript : MonoBehaviour
{
    public string rezultats;
    public InputField vards;
    public InputField gads;
    public Text text;

    public void izvadit()
    {
        string vardss = vards.text;
        
        int dzG= int.Parse(gads.text);
        DateTime dz = new DateTime(dzG, 1, 1);
        DateTime tagad = DateTime.Now;
        int vecums = tagad.Year - dz.Year;
        if (tagad.DayOfYear < dz.DayOfYear)
        {
            vecums--;
        }
         rezultats = "Tevi sauc " + vardss + " un Tu esi " + vecums + " gadus vecs!";
        text.text = rezultats;
    }
}
