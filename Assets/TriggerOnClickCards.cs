using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOnClickCards : MonoBehaviour
{
    private int randomNumberOneScript;
    private int randomNumberTwoScript;
    private int randomNumberThreeScript;

    TriggerActiveStatus triggerActiveStatusScript;

    [SerializeField] GameObject flowerTask; // still private, but you can see it in the editor
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

    private void Awake()
    {
        Debug.Log("Awake");
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
        // er bekommt nicht die richtigen Werte!
        randomNumberOneScript = triggerActiveStatusScript.randomNumberOne;
        randomNumberTwoScript = triggerActiveStatusScript.randomNumberTwo;
        randomNumberThreeScript = triggerActiveStatusScript.randomNumberThree;
    }

    private void CheckForRightSymbol()
    {
        switch (randomNumberOneScript)
        {
            case 1:
              if (index == 1)
                {
                    CurrentButton.SetActive(false);
                    miniGameOne1.SetActive(false);
                }
                break;
            case 2:
                if (index == 2)
                {
                    CurrentButton.SetActive(false);
                    miniGameOne2.SetActive(false);
                }
                break;
            case 3:
                if (index == 3)
                {
                    CurrentButton.SetActive(false);
                    miniGameOne3.SetActive(false);
                }
                break;
            case 4:
                if (index == 4)
                {
                    CurrentButton.SetActive(false);
                    miniGameOne4.SetActive(false);
                }
                break;
            case 5:
                if (index == 5)
                {
                    CurrentButton.SetActive(false);
                    miniGameOne5.SetActive(false);
                }
                break;
            case 6:
                if (index == 6)
                {
                    CurrentButton.SetActive(false);
                    miniGameOne6.SetActive(false);
                }
                break;
            case 7:
                if (index == 7)
                {
                    CurrentButton.SetActive(false);
                    miniGameOne7.SetActive(false);
                }
                break;
            case 8:
                if (index == 8)
                {
                    CurrentButton.SetActive(false);
                    miniGameOne8.SetActive(false);
                }
                break;
            default:
                Debug.Log("randomNumberOneScript: " + randomNumberOneScript + " | index: " + index);
                break;
        }

        switch (randomNumberTwoScript)
        {
            case 1:
                if (index == 1)
                {
                    CurrentButton.SetActive(false);
                    miniGameTwo1.SetActive(false);
                }
                break;
            case 2:
                if (index == 2)
                {
                    CurrentButton.SetActive(false);
                    miniGameTwo2.SetActive(false);
                }
                break;
            case 3:
                if (index == 3)
                {
                    CurrentButton.SetActive(false);
                    miniGameTwo3.SetActive(false);
                }
                break;
            case 4:
                if (index == 4)
                {
                    CurrentButton.SetActive(false);
                    miniGameTwo4.SetActive(false);
                }
                break;
            case 5:
                if (index == 5)
                {
                    CurrentButton.SetActive(false);
                    miniGameTwo5.SetActive(false);
                }
                break;
            case 6:
                if (index == 6)
                {
                    CurrentButton.SetActive(false);
                    miniGameTwo6.SetActive(false);
                }
                break;
            case 7:
                if (index == 7)
                {
                    CurrentButton.SetActive(false);
                    miniGameTwo7.SetActive(false);
                }
                break;
            case 8:
                if (index == 8)
                {
                    CurrentButton.SetActive(false);
                    miniGameTwo8.SetActive(false);
                }
                break;
            default:
                Debug.Log("randomNumberTwoScript: " + randomNumberTwoScript+" | index: "+index);
                break;
        }

        switch (randomNumberThreeScript)
        {
            case 1:
                if (index == 1)
                {
                    CurrentButton.SetActive(false);
                    miniGameThree1.SetActive(false);
                }
                break;
            case 2:
                if (index == 2)
                {
                    CurrentButton.SetActive(false);
                    miniGameThree2.SetActive(false);
                }
                break;
            case 3:
                if (index == 3)
                {
                    CurrentButton.SetActive(false);
                    miniGameThree3.SetActive(false);
                }
                break;
            case 4:
                if (index == 4)
                {
                    CurrentButton.SetActive(false);
                    miniGameThree4.SetActive(false);
                }
                break;
            case 5:
                if (index == 5)
                {
                    CurrentButton.SetActive(false);
                    miniGameThree5.SetActive(false);
                }
                break;
            case 6:
                if (index == 6)
                {
                    CurrentButton.SetActive(false);
                    miniGameThree6.SetActive(false);
                }
                break;
            case 7:
                if (index == 7)
                {
                    CurrentButton.SetActive(false);
                    miniGameThree7.SetActive(false);
                }
                break;
            case 8:
                if (index == 8)
                {
                    CurrentButton.SetActive(false);
                    miniGameThree8.SetActive(false);
                }
                break;
            default:
                Debug.Log("randomNumberThreeScript: " + randomNumberThreeScript + " | index: " + index);
                break;
        }

        /*
        if (index == randomNumberOneScript | index == randomNumberTwoScript | index == randomNumberThreeScript)
        {
            CurrentButton.SetActive(false);
            // hier das mini game symbol noch deaktivieren
        }
        */

    }
}
