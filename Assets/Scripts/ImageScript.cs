using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{

    public Slider slaideris;
    public Slider slaideris2;

    public Sprite[] Masivs;
    public GameObject mainigaisAttels;
    public Text tekst;


    public void Rost()
    {
        float pasreizejaVertiba = slaideris.GetComponent<Slider>().value;
        float garums = pasreizejaVertiba * 2;
        mainigaisAttels.transform.localScale = new Vector3(1F * garums, 1F * garums, 1);

    }
    public void shirina()
    {
        float pasreizejaVertiba = slaideris2.GetComponent<Slider>().value;
        float platums = pasreizejaVertiba * 2;
        mainigaisAttels.transform.localScale = new Vector3(1F * platums, 1, 1);
    }

    public void atteluM(int sk)
    {
        if (sk == 0)
        {
            mainigaisAttels.GetComponent<Image>().sprite = Masivs[0];
            tekst.text = "Stīvs ir spēlētāja varonis no 2011. gada smilškastes videospēles Minecraft. Stīvs, ko izveidojis zviedru videospēļu izstrādātājs Markuss  Persson un ieviests 2009. gada Java versijā, ir viens no deviņiem noklusējuma atskaņotāja varoņu apvalkiem, kas pieejami mūsdienu Minecraft versiju spēlētājiem. Stīvam trūkst oficiāla fona stāsta, jo viņš ir paredzēts kā pielāgojams spēlētāja iemiesojums, nevis iepriekš definēts varonis.";
        } if (sk == 1) {
                Debug.Log("OK");
                mainigaisAttels.GetComponent<Image>().sprite = Masivs[1];
                tekst.text = "Aleksa ir galvenā un spēlējamā Minecraft varone kopā ar viņas vīrišķo ekvivalentu Stīvu.";
            }
        


    }
}