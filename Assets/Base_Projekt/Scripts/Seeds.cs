using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Seeds : MonoBehaviour
{
    // public Button seedCollect;
    public TMP_Text seedText;
    public int seed = 0;

    void Start()
    {
        /*
        seedCollect.onClick.AddListener(delegate
        {
            seed = seed + 1;
        });
        */
    }

    void Update()
    {
        seedText.text = "Samenanzahl: " + seed.ToString();
    }

    public void FirstCat()
    {
        seed = seed + 1;
    }

    public void SecondCat()
    {
        seed = seed + 1;
    }

    public void ThirdCat()
    {
        seed = seed + 1;
    }

    public void FourthCat()
    {
        seed = seed + 1;
    }

    public void FifthCat()
    {
        seed = seed + 1;
    }
}
