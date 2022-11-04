using UnityEngine;

public class triggerActiveStatus : MonoBehaviour
{
    public GameObject taskWindow;

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
    public GameObject TwoObjSeven;
    public GameObject TwoObjEight;

    public GameObject ThreeObjOne; // t�rkises Polygon
    public GameObject ThreeObjTwo; // K�se
    public GameObject ThreeObjThree; // Blauer Ball
    public GameObject ThreeObjFour; // Wood Polygon
    public GameObject ThreeObjFive; // Tasse
    public GameObject ThreeObjSix; // Gr�ner Ball
    public GameObject ThreeObjSeven; // Baum
    public GameObject ThreeObjEight; // Ballon

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  

    }

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
        float randomNumberOne = Random.Range(1, 8);

        float randomNumberTwo = Random.Range(1, 8);
        while (randomNumberTwo == randomNumberOne)
        {
            randomNumberTwo = Random.Range(1, 8);
        }

        float randomNumberThree = Random.Range(1, 8);
        while (randomNumberThree == randomNumberOne || randomNumberThree == randomNumberTwo)
        {
            randomNumberTwo = Random.Range(1, 8);
        }

        switch (randomNumberOne)
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
                // insert println(randomNumberOne) here
                break;
        }

        switch (randomNumberTwo)
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
                // insert println(randomNumberTwo) here
                break;
        }

        switch (randomNumberThree)
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
                // insert println(randomNumberThree) here
                break;
        }

        Debug.Log("random Numbers:"+
            " one:" + randomNumberOne +
            " | two: " + randomNumberTwo +
            " | three: " + randomNumberThree);


        /*
    possibleAnswerRow0Col0; // t�rkis Polygon
    possibleAnswerRow0Col1; // K�se
    possibleAnswerRow0Col2; // Blauer Ball
    possibleAnswerRow0Col3; // Anderes T�rkises thingy

    possibleAnswerRow1Col0; // Tasse
    possibleAnswerRow1Col1; // Gr�ner Ball
    possibleAnswerRow1Col2; // Baum
    possibleAnswerRow1Col3; // Ballon
    */
    }
}
