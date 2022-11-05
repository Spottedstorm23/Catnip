using System.Collections.Generic;
using UnityEngine;

public class TriggerActiveStatus : MonoBehaviour
{
    public GameObject taskWindow;

    public GameObject OneObjOne; // türkises Polygon
    public GameObject OneObjTwo; // Käse
    public GameObject OneObjThree; // Blauer Ball
    public GameObject OneObjFour; // Wood Polygon
    public GameObject OneObjFive; // Tasse
    public GameObject OneObjSix; // Grüner Ball
    public GameObject OneObjSeven; // Baum
    public GameObject OneObjEight; // Ballon

    public GameObject TwoObjOne; // türkises Polygon
    public GameObject TwoObjTwo; // Käse
    public GameObject TwoObjThree; // Blauer Ball
    public GameObject TwoObjFour; // Wood Polygon
    public GameObject TwoObjFive; // Tasse
    public GameObject TwoObjSix; // Grüner Ball
    public GameObject TwoObjSeven; // Baum
    public GameObject TwoObjEight; // Ballon

    public GameObject ThreeObjOne; // türkises Polygon
    public GameObject ThreeObjTwo; // Käse
    public GameObject ThreeObjThree; // Blauer Ball
    public GameObject ThreeObjFour; // Wood Polygon
    public GameObject ThreeObjFive; // Tasse
    public GameObject ThreeObjSix; // Grüner Ball
    public GameObject ThreeObjSeven; // Baum
    public GameObject ThreeObjEight; // Ballon

    public int randomNumberOne;
    public int randomNumberTwo;
    public int randomNumberThree;

    private void OnEnable()
    {
        Debug.Log("StartMiniGame()");
        StartMiniGame();
    }

    public void StartMiniGame()
    {
        Debug.Log("SetTask()");
        SetTask();
        // add timer here
    }
    
    private void SetTask()
    {
        randomNumberOne = Random.Range(1, 8);

        randomNumberTwo = Random.Range(1, 8);
        while (randomNumberTwo == randomNumberOne)
        {
            randomNumberTwo = Random.Range(1, 8);
        }

        randomNumberThree = Random.Range(1, 8);
        while (randomNumberThree == randomNumberOne | randomNumberThree == randomNumberTwo)
        {
            randomNumberThree = Random.Range(1, 8);
        }

        switch (randomNumberOne)
        {
            // row 0
            case 1: // türkis Polygon
                OneObjOne.SetActive(true);
                break;
            case 2: // Käse
                OneObjTwo.SetActive(true);
                break;
            case 3: // Blauer Ball
                OneObjThree.SetActive(true);
                break;
            case 4: // Anderes Türkises thingy
                OneObjFour.SetActive(true);
                break;

            // row 1
            case 5: // Tasse
                OneObjFive.SetActive(true);
                break;
            case 6: // Grüner Ball
                OneObjSix.SetActive(true);
                break;
            case 7: // Baum
                OneObjSeven.SetActive(true);
                break;
            case 8: // Ballon
                OneObjEight.SetActive(true);
                break;
            default:
                Debug.Log("randomNumberOne: " + randomNumberOne);
                break;
        }
        
        switch (randomNumberTwo)
        {
            // row 0
            case 1: // türkis Polygon
                TwoObjOne.SetActive(true);
                break;
            case 2: // Käse
                TwoObjTwo.SetActive(true);
                break;
            case 3: // Blauer Ball
                TwoObjThree.SetActive(true);
                break;
            case 4: // Anderes Türkises thingy
                TwoObjFour.SetActive(true);
                break;

            // row 1
            case 5: // Tasse
                TwoObjFive.SetActive(true);
                break;
            case 6: // Grüner Ball
                TwoObjSix.SetActive(true);
                break;
            case 7: // Baum
                TwoObjSeven.SetActive(true);
                break;
            case 8: // Ballon
                TwoObjEight.SetActive(true);
                break;
            default:
                Debug.Log("randomNumberTwo: " + randomNumberTwo);
                break;
        }

        switch (randomNumberThree)
        {
            // row 0
            case 1: // türkis Polygon
                ThreeObjOne.SetActive(true);
                break;
            case 2: // Käse
                ThreeObjTwo.SetActive(true);
                break;
            case 3: // Blauer Ball
                ThreeObjThree.SetActive(true);
                break;
            case 4: // Anderes Türkises thingy
                ThreeObjFour.SetActive(true);
                break;

            // row 1
            case 5: // Tasse
                ThreeObjFive.SetActive(true);
                break;
            case 6: // Grüner Ball
                ThreeObjSix.SetActive(true);
                break;
            case 7: // Baum
                ThreeObjSeven.SetActive(true);
                break;
            case 8: // Ballon
                ThreeObjEight.SetActive(true);
                break;
            default:
                Debug.Log("randomNumberThree: " + randomNumberThree);
                break;
        }

        Debug.Log("random Numbers:"+
            " one:" + randomNumberOne +
            " | two: " + randomNumberTwo +
            " | three: " + randomNumberThree);
    }
}
