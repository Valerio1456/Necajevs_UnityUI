using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class JiggleScript : MonoBehaviour
{
    public string rezultats;
    public InputField vards;
    public InputField gads;
    public Text text;

    void Start()
    {
        gads.onValueChanged.AddListener(delegate { ValidateYearInput(); });
    }

    public void izvadit()
    {
        string vardss = vards.text;
        string gadsText = gads.text;

        if (string.IsNullOrEmpty(vardss) ||
            string.IsNullOrEmpty(gadsText) || !int.TryParse(gadsText, out int dzG))
        {
            return;
        }

        if (dzG < 1 || dzG > DateTime.Now.Year)
        {
            text.text = "Lūdzu, ievadiet derīgu gadu.";
            return;
        }

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

    private void ValidateYearInput()
    {
        string text = gads.text;
        gads.text = string.Concat(text.Where(char.IsDigit));
    }
}
