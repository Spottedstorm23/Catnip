using System.Collections.Generic;
using UnityEngine;

public class TriggerActiveStatus : MonoBehaviour
{
    public GameObject TaskWindow;

    public GameObject OneObjOne; // t�rkises Polygon
    public GameObject OneObjTwo; // K�se
    public GameObject OneObjThree; // Blauer Ball
    public GameObject OneObjFour; // Wood Polygon
    public GameObject OneObjFive; // Tasse
    public GameObject OneObjSix; // Gr�ner Ball
    public GameObject OneObjSeven; // Baum
    public GameObject OneObjEight; // Ballon

    public GameObject TwoObjOne; // t�rkises Polygon
    public GameObject TwoObjTwo; // K�se
    public GameObject TwoObjThree; // Blauer Ball
    public GameObject TwoObjFour; // Wood Polygon
    public GameObject TwoObjFive; // Tasse
    public GameObject TwoObjSix; // Gr�ner Ball
    public GameObject TwoObjSeven; // Baum
    public GameObject TwoObjEight; // Ballon

    public GameObject ThreeObjOne; // t�rkises Polygon
    public GameObject ThreeObjTwo; // K�se
    public GameObject ThreeObjThree; // Blauer Ball
    public GameObject ThreeObjFour; // Wood Polygon
    public GameObject ThreeObjFive; // Tasse
    public GameObject ThreeObjSix; // Gr�ner Ball
    public GameObject ThreeObjSeven; // Baum
    public GameObject ThreeObjEight; // Ballon

    public int RandomNumberOne;
    public int RandomNumberTwo;
    public int RandomNumberThree;

    private void OnEnable()
    {
        StartMiniGame();
    }

    public void StartMiniGame()
    {
        SetTask();
        // add timer here
    }
    
    private void SetTask()
    {
        RandomNumberOne = Random.Range(1, 9);

        RandomNumberTwo = Random.Range(1, 9);
        while (RandomNumberTwo == RandomNumberOne)
        {
            RandomNumberTwo = Random.Range(1, 9);
        }

        RandomNumberThree = Random.Range(1, 9);
        while (RandomNumberThree == RandomNumberOne | RandomNumberThree == RandomNumberTwo)
        {
            RandomNumberThree = Random.Range(1, 9);
        }

        switch (RandomNumberOne)
        {
            // row 0
            case 1: // t�rkis Polygon
                OneObjOne.SetActive(true);
                break;
            case 2: // K�se
                OneObjTwo.SetActive(true);
                break;
            case 3: // Blauer Ball
                OneObjThree.SetActive(true);
                break;
            case 4: // Anderes T�rkises thingy
                OneObjFour.SetActive(true);
                break;

            // row 1
            case 5: // Tasse
                OneObjFive.SetActive(true);
                break;
            case 6: // Gr�ner Ball
                OneObjSix.SetActive(true);
                break;
            case 7: // Baum
                OneObjSeven.SetActive(true);
                break;
            case 8: // Ballon
                OneObjEight.SetActive(true);
                break;
            default:
                Debug.Log("randomNumberOne: " + RandomNumberOne);
                break;
        }
        
        switch (RandomNumberTwo)
        {
            // row 0
            case 1: // t�rkis Polygon
                TwoObjOne.SetActive(true);
                break;
            case 2: // K�se
                TwoObjTwo.SetActive(true);
                break;
            case 3: // Blauer Ball
                TwoObjThree.SetActive(true);
                break;
            case 4: // Anderes T�rkises thingy
                TwoObjFour.SetActive(true);
                break;

            // row 1
            case 5: // Tasse
                TwoObjFive.SetActive(true);
                break;
            case 6: // Gr�ner Ball
                TwoObjSix.SetActive(true);
                break;
            case 7: // Baum
                TwoObjSeven.SetActive(true);
                break;
            case 8: // Ballon
                TwoObjEight.SetActive(true);
                break;
            default:
                Debug.Log("randomNumberTwo: " + RandomNumberTwo);
                break;
        }

        switch (RandomNumberThree)
        {
            // row 0
            case 1: // t�rkis Polygon
                ThreeObjOne.SetActive(true);
                break;
            case 2: // K�se
                ThreeObjTwo.SetActive(true);
                break;
            case 3: // Blauer Ball
                ThreeObjThree.SetActive(true);
                break;
            case 4: // Anderes T�rkises thingy
                ThreeObjFour.SetActive(true);
                break;

            // row 1
            case 5: // Tasse
                ThreeObjFive.SetActive(true);
                break;
            case 6: // Gr�ner Ball
                ThreeObjSix.SetActive(true);
                break;
            case 7: // Baum
                ThreeObjSeven.SetActive(true);
                break;
            case 8: // Ballon
                ThreeObjEight.SetActive(true);
                break;
            default:
                Debug.Log("randomNumberThree: " + RandomNumberThree);
                break;
        }

        Debug.Log("random Numbers:"+
            " one:" + RandomNumberOne +
            " | two: " + RandomNumberTwo +
            " | three: " + RandomNumberThree);
    }
}
