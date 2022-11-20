using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOnClickCards : MonoBehaviour
{
    private int randomNumberOneScript;
    private int randomNumberTwoScript;
    private int randomNumberThreeScript;

    TriggerActiveStatus triggerActiveStatusScript;

    [SerializeField] GameObject flowerTask;
    [SerializeField] GameObject CurrentButton;
    public int index;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;

    public GameObject miniGameOne1;
    public GameObject miniGameOne2;
    public GameObject miniGameOne3;
    public GameObject miniGameOne4;
    public GameObject miniGameOne5;
    public GameObject miniGameOne6;
    public GameObject miniGameOne7;
    public GameObject miniGameOne8;

    public GameObject miniGameTwo1;
    public GameObject miniGameTwo2;
    public GameObject miniGameTwo3;
    public GameObject miniGameTwo4;
    public GameObject miniGameTwo5;
    public GameObject miniGameTwo6;
    public GameObject miniGameTwo7;
    public GameObject miniGameTwo8;

    public GameObject miniGameThree1;
    public GameObject miniGameThree2;
    public GameObject miniGameThree3;
    public GameObject miniGameThree4;
    public GameObject miniGameThree5;
    public GameObject miniGameThree6;
    public GameObject miniGameThree7;
    public GameObject miniGameThree8;

    public bool successOne = false;
    public bool successTwo = false;
    public bool successThree = false;

    private void Awake()
    {
        triggerActiveStatusScript =
            flowerTask.GetComponent<TriggerActiveStatus>();
    }

    public void OnClick()
    {
        SetVars();
        CheckForRightSymbol();
    }

    private void SetVars()
    {
        randomNumberOneScript = triggerActiveStatusScript.RandomNumberOne;
        randomNumberTwoScript = triggerActiveStatusScript.RandomNumberTwo;
        randomNumberThreeScript = triggerActiveStatusScript.RandomNumberThree;
    }

    private void CheckForRightSymbol()
    {
        if (!successOne)
        {
            switch (randomNumberOneScript)
            {
                case 1:
                    if (index == 1)
                    {
                        successOne = true;
                        Debug.Log("index " + index + ", successOne " + successOne);
                        miniGameOne1.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                case 2:
                    if (index == 2)
                    {
                        successOne = true;
                        Debug.Log("index " + index + ", successOne " + successOne);
                        miniGameOne2.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                case 3:
                    if (index == 3)
                    {
                        successOne = true;
                        Debug.Log("index " + index + ", successOne " + successOne);
                        miniGameOne3.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                case 4:
                    if (index == 4)
                    {
                        successOne = true;
                        Debug.Log("index " + index + ", successOne " + successOne);
                        miniGameOne4.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                case 5:
                    if (index == 5)
                    {
                        successOne = true;
                        Debug.Log("index " + index + ", successOne " + successOne);
                        miniGameOne5.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                case 6:
                    if (index == 6)
                    {
                        successOne = true;
                        Debug.Log("index " + index + ", successOne " + successOne);
                        miniGameOne6.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                case 7:
                    if (index == 7)
                    {
                        successOne = true;
                        Debug.Log("index " + index + ", successOne " + successOne);
                        miniGameOne7.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                case 8:
                    if (index == 8)
                    {
                        successOne = true;
                        Debug.Log("index " + index + ", successOne " + successOne);
                        miniGameOne8.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                default:
                    Debug.Log("randomNumberOneScript: " + randomNumberOneScript + " | index: " + index);
                    break;
            }
        }

        if (!successTwo)
        {
            switch (randomNumberTwoScript)
            {
                case 1:
                    if (index == 1)
                    {
                        successTwo = true;
                        Debug.Log("index " + index + ", successTwo " + successTwo);
                        miniGameTwo1.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                case 2:
                    if (index == 2)
                    {
                        successTwo = true;
                        Debug.Log("index " + index + ", successTwo " + successTwo);
                        miniGameTwo2.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                case 3:
                    if (index == 3)
                    {
                        successTwo = true;
                        Debug.Log("index " + index + ", successTwo " + successTwo);
                        miniGameTwo3.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                case 4:
                    if (index == 4)
                    {
                        successTwo = true;
                        Debug.Log("index " + index + ", successTwo " + successTwo);
                        miniGameTwo4.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                case 5:
                    if (index == 5)
                    {
                        successTwo = true;
                        Debug.Log("index " + index + ", successTwo " + successTwo);
                        miniGameTwo5.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                case 6:
                    if (index == 6)
                    {
                        successTwo = true;
                        Debug.Log("index " + index + ", successTwo " + successTwo);
                        miniGameTwo6.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                case 7:
                    if (index == 7)
                    {
                        successTwo = true;
                        Debug.Log("index " + index + ", successTwo " + successTwo);
                        miniGameTwo7.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                case 8:
                    if (index == 8)
                    {
                        successTwo = true;
                        Debug.Log("index " + index + ", successTwo " + successTwo);
                        miniGameTwo8.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                default:
                    Debug.Log("randomNumberTwoScript: " + randomNumberTwoScript + " | index: " + index);
                    break;
            }
        }

        if (!successThree)
        {
            switch (randomNumberThreeScript)
            {
                case 1:
                    if (index == 1)
                    {
                        successThree = true;
                        Debug.Log("index " + index + ", successThree " + successThree);
                        miniGameThree1.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                case 2:
                    if (index == 2)
                    {
                        successThree = true;
                        Debug.Log("index " + index + ", successThree " + successThree);
                        miniGameThree2.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                case 3:
                    if (index == 3)
                    {
                        successThree = true;
                        Debug.Log("index " + index + ", successThree " + successThree);
                        miniGameThree3.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                case 4:
                    if (index == 4)
                    {
                        successThree = true;
                        Debug.Log("index " + index + ", successThree " + successThree);
                        miniGameThree4.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                case 5:
                    if (index == 5)
                    {
                        successThree = true;
                        Debug.Log("index " + index + ", successThree " + successThree);
                        miniGameThree5.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                case 6:
                    if (index == 6)
                    {
                        successThree = true;
                        Debug.Log("index " + index + ", successThree " + successThree);
                        miniGameThree6.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                case 7:
                    if (index == 7)
                    {
                        successThree = true;
                        Debug.Log("index " + index + ", successThree " + successThree);
                        miniGameThree7.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                case 8:
                    if (index == 8)
                    {
                        successThree = true;
                        Debug.Log("index " + index + ", successThree " + successThree);
                        miniGameThree8.SetActive(false);
                        // CurrentButton.SetActive(false);
                    }
                    break;
                default:
                    Debug.Log("randomNumberThreeScript: " + randomNumberThreeScript + " | index: " + index);
                    break;
            }
        }
    }
}
