using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerButtonPressed : MonoBehaviour
{
    public GameObject flowerButton;
    public GameObject taskWindow;

    public void ButtonClicked()
    {
        if (taskWindow.activeSelf != true)
        {
            taskWindow.SetActive(true);
        }

        // if(!gameObject.ActiveSelf) {
        //      gameObject.ActiveSelf = true;
        
        // }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
