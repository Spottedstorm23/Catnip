using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Flowers : MonoBehaviour
{
    public TMP_Text flowerText;
    public int flower = 0;

    void Update()
    {
        flowerText.text = flower.ToString();
    }

    public void GetFlower()
    {
        flower = flower + 1;
    }
}
