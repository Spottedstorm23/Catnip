using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float MaxTime = 10f;

    public float CountDown = 10;

    public bool TimerIsRunning = false;

    public GameObject TaskWindow;

    public TriggerMiniGameFinished TriggerMiniGameFinished;
    public TriggerActiveStatus TriggerActiveStatus;

    [SerializeField] private TextMeshPro CountDownText;

    void Update()
    {
        if (TimerIsRunning)
        {
            CountDown -= Time.deltaTime;
            float seconds = Mathf.FloorToInt(CountDown);
            CountDownText.SetText("Zeit: " + seconds);

            if (CountDown <= 0)
            {
                TaskWindow.SetActive(false);

                TriggerMiniGameFinished.ResetSuccess();

                TimerIsRunning = false;
                CountDown = MaxTime;

                ResetTasks();
            }
        }
    }

    private void ResetTasks()
    {
        switch(TriggerActiveStatus.RandomNumberOne)
        {
            // row 0
            case 1: // türkis Polygon
                TriggerActiveStatus.OneObjOne.SetActive(false);
                break;
            case 2: // Käse
                TriggerActiveStatus.OneObjTwo.SetActive(false);
                break;
            case 3: // Blauer Ball
                TriggerActiveStatus.OneObjThree.SetActive(false);
                break;
            case 4: // Anderes Türkises thingy
                TriggerActiveStatus.OneObjFour.SetActive(false);
                break;

            // row 1
            case 5: // Tasse
                TriggerActiveStatus.OneObjFive.SetActive(false);
                break;
            case 6: // Grüner Ball
                TriggerActiveStatus.OneObjSix.SetActive(false);
                break;
            case 7: // Baum
                TriggerActiveStatus.OneObjSeven.SetActive(false);
                break;
            case 8: // Ballon
                TriggerActiveStatus.OneObjEight.SetActive(false);
                break;
            default:
                Debug.Log("randomNumberOne: " + TriggerActiveStatus.RandomNumberOne);
                break;
        }

        switch (TriggerActiveStatus.RandomNumberTwo)
        {
            // row 0
            case 1: // türkis Polygon
                TriggerActiveStatus.TwoObjOne.SetActive(false);
                break;
            case 2: // Käse
                TriggerActiveStatus.TwoObjTwo.SetActive(false);
                break;
            case 3: // Blauer Ball
                TriggerActiveStatus.TwoObjThree.SetActive(false);
                break;
            case 4: // Anderes Türkises thingy
                TriggerActiveStatus.TwoObjFour.SetActive(false);
                break;

            // row 1
            case 5: // Tasse
                TriggerActiveStatus.TwoObjFive.SetActive(false);
                break;
            case 6: // Grüner Ball
                TriggerActiveStatus.TwoObjSix.SetActive(false);
                break;
            case 7: // Baum
                TriggerActiveStatus.TwoObjSeven.SetActive(false);
                break;
            case 8: // Ballon
                TriggerActiveStatus.TwoObjEight.SetActive(false);
                break;
            default:
                Debug.Log("randomNumberTwo: " + TriggerActiveStatus.RandomNumberTwo);
                break;
        }

        switch (TriggerActiveStatus.RandomNumberThree)
        {
            // row 0
            case 1: // türkis Polygon
                TriggerActiveStatus.ThreeObjOne.SetActive(false);
                break;
            case 2: // Käse
                TriggerActiveStatus.ThreeObjTwo.SetActive(false);
                break;
            case 3: // Blauer Ball
                TriggerActiveStatus.ThreeObjThree.SetActive(false);
                break;
            case 4: // Anderes Türkises thingy
                TriggerActiveStatus.ThreeObjFour.SetActive(false);
                break;

            // row 1
            case 5: // Tasse
                TriggerActiveStatus.ThreeObjFive.SetActive(false);
                break;
            case 6: // Grüner Ball
                TriggerActiveStatus.ThreeObjSix.SetActive(false);
                break;
            case 7: // Baum
                TriggerActiveStatus.ThreeObjSeven.SetActive(false);
                break;
            case 8: // Ballon
                TriggerActiveStatus.ThreeObjEight.SetActive(false);
                break;
            default:
                Debug.Log("randomNumberThree: " + TriggerActiveStatus.RandomNumberThree);
                break;
        }
    }
}
