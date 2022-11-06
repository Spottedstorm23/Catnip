using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Seeds : MonoBehaviour
{
    public TMP_Text seedText;
    public int seed = 0;
    public GameObject FirstBox;
    public GameObject SecondBox;
    public GameObject ThirdBox;
    public GameObject FourthBox;
    public GameObject FifthBox;
    public GameObject PlantOne;
    public GameObject PlantTwo;
    public GameObject PlantThree;
    public GameObject PlantFour;
    public GameObject PlantFive;

    void Update()
    {
        seedText.text = "Samenanzahl: " + seed.ToString();

        if (seed < 1)
        {
            FirstBox.SetActive(false);
            SecondBox.SetActive(false);
            ThirdBox.SetActive(false);
            FourthBox.SetActive(false);
            FifthBox.SetActive(false);
        }
        else
        {
            FirstBox.SetActive(true);
            SecondBox.SetActive(true);
            ThirdBox.SetActive(true);
            FourthBox.SetActive(true);
            FifthBox.SetActive(true);
        }
    }

    public void GetSeed()
    {
        seed = seed + 1;
    }

    public void Plant()
    {
        seed = seed - 1;
    }
}
