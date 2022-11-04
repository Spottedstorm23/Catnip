using UnityEngine;

public class triggerActiveStatus : MonoBehaviour
{
    public GameObject taskWindow;

    public GameObject miniGameObjOne;
    public GameObject miniGameObjTwo;
    public GameObject miniGameObjThree;

    public GameObject possibleAnswerRow0Col0; // t�rkis Polygon
    public GameObject possibleAnswerRow0Col1; // K�se
    public GameObject possibleAnswerRow0Col2; // Blauer Ball
    public GameObject possibleAnswerRow0Col3; // Anderes T�rkises thingy

    public GameObject possibleAnswerRow1Col0; // Tasse
    public GameObject possibleAnswerRow1Col1; // Gr�ner Ball
    public GameObject possibleAnswerRow1Col2; // Baum
    public GameObject possibleAnswerRow1Col3; // Ballon

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
                miniGameObjOne = Instantiate(possibleAnswerRow0Col0);
                break;
            case 2: // K�se
                miniGameObjOne = Instantiate(possibleAnswerRow0Col1);
                break;
            case 3: // Blauer Ball
                miniGameObjOne = Instantiate(possibleAnswerRow0Col2);
                break;
            case 4: // Anderes T�rkises thingy
                miniGameObjOne = Instantiate(possibleAnswerRow0Col3);
                break;

            // row 1
            case 5: // Tasse
                miniGameObjOne = Instantiate(possibleAnswerRow1Col0);
                break;
            case 6: // Gr�ner Ball
                miniGameObjOne = Instantiate(possibleAnswerRow1Col1);
                break;
            case 7: // Baum
                miniGameObjOne = Instantiate(possibleAnswerRow1Col2);
                break;
            case 8: // Ballon
                miniGameObjOne = Instantiate(possibleAnswerRow1Col3);
                break;
            default:
                // insert println(randomNumberOne) here
                break;
        }

        switch (randomNumberTwo)
        {
            // row 0
            case 1: // t�rkis Polygon
                miniGameObjTwo = Instantiate(possibleAnswerRow0Col0);
                break;
            case 2: // K�se
                miniGameObjTwo = Instantiate(possibleAnswerRow0Col1);
                break;
            case 3: // Blauer Ball
                miniGameObjTwo = Instantiate(possibleAnswerRow0Col2);
                break;
            case 4: // Anderes T�rkises thingy
                miniGameObjTwo = Instantiate(possibleAnswerRow0Col3);
                break;

            // row 1
            case 5: // Tasse
                miniGameObjTwo = Instantiate(possibleAnswerRow1Col0);
                break;
            case 6: // Gr�ner Ball
                miniGameObjTwo = Instantiate(possibleAnswerRow1Col1);
                break;
            case 7: // Baum
                miniGameObjTwo = Instantiate(possibleAnswerRow1Col2);
                break;
            case 8: // Ballon
                miniGameObjTwo = Instantiate(possibleAnswerRow1Col3);
                break;
            default:
                // insert println(randomNumberTwo) here
                break;
        }

        switch (randomNumberThree)
        {
            // row 0
            case 1: // t�rkis Polygon
                miniGameObjThree = Instantiate(possibleAnswerRow0Col0);
                break;
            case 2: // K�se
                miniGameObjThree = Instantiate(possibleAnswerRow0Col1);
                break;
            case 3: // Blauer Ball
                miniGameObjThree = Instantiate(possibleAnswerRow0Col2);
                break;
            case 4: // Anderes T�rkises thingy
                miniGameObjThree = Instantiate(possibleAnswerRow0Col3);
                break;

            // row 1
            case 5: // Tasse
                miniGameObjThree = Instantiate(possibleAnswerRow1Col0);
                break;
            case 6: // Gr�ner Ball
                miniGameObjThree = Instantiate(possibleAnswerRow1Col1);
                break;
            case 7: // Baum
                miniGameObjThree = Instantiate(possibleAnswerRow1Col2);
                break;
            case 8: // Ballon
                miniGameObjThree = Instantiate(possibleAnswerRow1Col3);
                break;
            default:
                // insert println(randomNumberThree) here
                break;
        }

        Debug.Log("random Numbers:"+
            " one:" + randomNumberOne +
            " | two: " + randomNumberTwo +
            " | three: " + randomNumberThree);
    }
}
