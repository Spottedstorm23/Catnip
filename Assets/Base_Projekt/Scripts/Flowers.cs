using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Flowers : MonoBehaviour
{
    public TMP_Text flowerText;
    public int flower = 0;
    public GameObject WinText;

    void Update()
    {
        flowerText.text = flower.ToString();
    }

    public void GetFlower()
    {
        flower = flower + 1;
    }

    public void GameWon()
    {
        if (flower >= 10)
        {
            WinText.SetActive(true);
        }

    }
}
