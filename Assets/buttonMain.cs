using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonMain : MonoBehaviour
{

    public int number;

    public GameObject panel;

    private Vector3 pos;
    private bool onOff = true;

    private void Awake()
    {
        pos = transform.localPosition;
    }

    private void Update()
    {
        if (playerManager.numberPanelMain == number)
        {
            if(onOff == false)
            {
                pos.y = 215f;
                transform.localPosition = pos;
                onOff = true;
            }
        }
        else
        {
            if (onOff == true)
            {
                pos.y = 205f;
                transform.localPosition = pos;
                onOff = false;
            }
        }
    }




    private void OnMouseUpAsButton()
    {
        if(playerManager.numberPanelMain != number)
        {
            playerManager.numberPanelMain = number;
            panel.gameObject.SetActive(true);
        } 
    }

}
