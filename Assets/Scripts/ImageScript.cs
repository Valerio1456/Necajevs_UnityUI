using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  

public class ImageScript : MonoBehaviour
{
    public GameObject imageHolder;
    public Slider rotationSlider;  
    public GameObject stiv;  
    public GameObject steve;  
    public Sprite[] spriteArray;  
    public void changeRotation()
    {
        float rotation = rotationSlider.GetComponent<Slider>().value;
        imageHolder.transform.localRotation = Quaternion.Euler(0, 0, rotation * 360);
    }

    public void showStiv(bool value)
    {
        stiv.SetActive(value);
    }

    public void showSteve(bool value)
    {
        steve.SetActive(value);
    }

    public void changeImage(int index)
    {
        if (index == 0)
        {
            imageHolder.GetComponent<Image>().sprite = spriteArray[0];
        }
        else if (index == 1)  
        {
            imageHolder.GetComponent<Image>().sprite = spriteArray[1];
        }
    }
}