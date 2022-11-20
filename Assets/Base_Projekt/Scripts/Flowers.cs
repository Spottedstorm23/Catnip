using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Flowers : MonoBehaviour
{
    public TMP_Text flowerText;
    public int flower = 0;
    public GameObject WinWindow;

    void Update()
    {
        flowerText.text = flower.ToString();
        GameWon();
    }

    public void GetFlower()
    {
        flower = flower + 1;
    }

    public void GameWon()
    {
        if (flower == 10)
        {
            WinWindow.SetActive(true);
        }

    }
}
