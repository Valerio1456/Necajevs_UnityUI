using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PokazatjVesi : MonoBehaviour
{
    public GameObject bron;
    public GameObject bron1;
    public GameObject bron2;
    public GameObject bron3;


    public void Brona(bool vertiba)
    {
        bron.SetActive(vertiba);
    }
    public void Brona1(bool vertiba)
    {
        bron1.SetActive(vertiba);
    }
    public void Brona2(bool vertiba)
    {
        bron2.SetActive(vertiba);
    }
    public void Brona3(bool vertiba)
    {
        bron3.SetActive(vertiba);
    }
}
