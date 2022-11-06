using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMiniGameFinished : MonoBehaviour
{
    public TriggerOnClickCards TriggerOnClickCardsScriptIcosa;
    public TriggerOnClickCards TriggerOnClickCardsScriptCheese;
    public TriggerOnClickCards TriggerOnClickCardsScriptBucky;
    public TriggerOnClickCards TriggerOnClickCardsScriptIcosa1;
    public TriggerOnClickCards TriggerOnClickCardsScriptCup;
    public TriggerOnClickCards TriggerOnClickCardsScriptBucky1;
    public TriggerOnClickCards TriggerOnClickCardsScriptTree;
    public TriggerOnClickCards TriggerOnClickCardsScriptBallon;

    private bool successOneScript;
    private bool successTwoScript;
    private bool successThreeScript;

    [SerializeField] GameObject flowerTask;
    [SerializeField] GameObject flower;

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update Flower task - triggerminigamefinished");
        if (!successOneScript)
        {
            if (TriggerOnClickCardsScriptIcosa.successOne)
            {
                successOneScript = TriggerOnClickCardsScriptIcosa.successOne;
            }
            if (TriggerOnClickCardsScriptCheese.successOne)
            {
                successOneScript = TriggerOnClickCardsScriptCheese.successOne;
            }
            if (TriggerOnClickCardsScriptBucky.successOne)
            {
                successOneScript = TriggerOnClickCardsScriptBucky.successOne;
            }
            if (TriggerOnClickCardsScriptIcosa1.successOne)
            {
                successOneScript = TriggerOnClickCardsScriptIcosa1.successOne;
            }
            if (TriggerOnClickCardsScriptCup.successOne)
            {
                successOneScript = TriggerOnClickCardsScriptCup.successOne;
            }
            if (TriggerOnClickCardsScriptBucky1.successOne)
            {
                successOneScript = TriggerOnClickCardsScriptBucky1.successOne;
            }
            if (TriggerOnClickCardsScriptTree.successOne)
            {
                successOneScript = TriggerOnClickCardsScriptTree.successOne;
            }
            if (TriggerOnClickCardsScriptBallon.successOne)
            {
                successOneScript = TriggerOnClickCardsScriptBallon.successOne;
            }
        }

        if (!successTwoScript) {
            if (TriggerOnClickCardsScriptIcosa.successTwo)
            {
                successTwoScript = TriggerOnClickCardsScriptIcosa.successTwo;
            }
            if (TriggerOnClickCardsScriptCheese.successTwo)
            {
                successTwoScript = TriggerOnClickCardsScriptCheese.successTwo;
            }
            if (TriggerOnClickCardsScriptBucky.successTwo)
            {
                successTwoScript = TriggerOnClickCardsScriptBucky.successTwo;
            }
            if (TriggerOnClickCardsScriptIcosa1.successTwo)
            {
                successTwoScript = TriggerOnClickCardsScriptIcosa1.successTwo;
            }
            if (TriggerOnClickCardsScriptCup.successTwo)
            {
                successTwoScript = TriggerOnClickCardsScriptCup.successTwo;
            }
            if (TriggerOnClickCardsScriptBucky1.successTwo)
            {
                successTwoScript = TriggerOnClickCardsScriptBucky1.successTwo;
            }
            if (TriggerOnClickCardsScriptTree.successTwo)
            {
                successTwoScript = TriggerOnClickCardsScriptTree.successTwo;
            }
            if (TriggerOnClickCardsScriptBallon.successTwo)
            {
                successTwoScript = TriggerOnClickCardsScriptBallon.successTwo;
            }
        }
        
        if (!successThreeScript)
        {
            if (TriggerOnClickCardsScriptIcosa.successThree)
            {
                successThreeScript = TriggerOnClickCardsScriptIcosa.successThree;
            }
            if (TriggerOnClickCardsScriptCheese.successThree)
            {
                successThreeScript = TriggerOnClickCardsScriptCheese.successThree;
            }
            if (TriggerOnClickCardsScriptBucky.successThree)
            {
                successThreeScript = TriggerOnClickCardsScriptBucky.successThree;
            }
            if (TriggerOnClickCardsScriptIcosa1.successThree)
            {
                successThreeScript = TriggerOnClickCardsScriptIcosa1.successThree;
            }
            if (TriggerOnClickCardsScriptCup.successThree)
            {
                successThreeScript = TriggerOnClickCardsScriptCup.successThree;
            }
            if (TriggerOnClickCardsScriptBucky1.successThree)
            {
                successThreeScript = TriggerOnClickCardsScriptBucky1.successThree;
            }
            if (TriggerOnClickCardsScriptTree.successThree)
            {
                successThreeScript = TriggerOnClickCardsScriptTree.successThree;
            }
            if (TriggerOnClickCardsScriptBallon.successThree)
            {
                successThreeScript = TriggerOnClickCardsScriptBallon.successThree;
            }
        }

        if (successOneScript && successTwoScript && successThreeScript)
        {
            flower.SetActive(true);
            flowerTask.SetActive(false);
        }
    }
}
