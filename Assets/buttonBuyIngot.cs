using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonBuyIngot : MonoBehaviour
{
    public int number;

    public Button _button;
    public GameObject _text;
    public textLevelUp _tLU;

    private bool buttonOnOff = true;
    private Vector3 posCur;

    private Vector3 textUp;
    private Vector3 textDown;

    private void Start()
    {
        textUp = _text.transform.localPosition;
        textDown = _text.transform.localPosition;
        textDown.y -= 2;
    }

    private void Update()
    {
        if (playerManager.ore >= playerManager.CostIngot[number])
        {
            if (buttonOnOff == false)
            {
                _button.interactable = true;
                buttonOnOff = true;
            }
        }
        else
        {
            if (buttonOnOff == true)
            {
                _button.interactable = false;
                buttonOnOff = false;
            }
        }
    }


    private void OnMouseDown()
    {
        if (buttonOnOff == true)
            _text.transform.localPosition = textDown;
    }
    private void OnMouseUp()
    {
        _text.transform.localPosition = textUp;
    }



    private void OnMouseEnter()
    {
        playerManager._tooltipButtonBuyIngot.gameObject.SetActive(true);
        posCur = transform.position;
        posCur.x += 2f;
        posCur.y += 1f;
        playerManager._tooltipButtonBuyIngot.transform.position = posCur;
        playerManager._tooltipButtonBuyIngot.TooltipSize(number);
    }
    private void OnMouseExit()
    {
        playerManager._tooltipButtonBuyIngot.gameObject.SetActive(false);
    }




    public void OnMouseUpAsButton()
    {
        if (buttonOnOff == true)
        {
            playerManager.ore -= playerManager.CostIngot[number];
            playerManager.levelIngot[number] += playerManager.XBuyIngot[number];

            //квест 4
            if (playerManager.questOn[4] > 0 && playerManager.questLevel[4] < playerManager.questLevelMax[4])
            {
                playerManager.questProgress[4] += playerManager.XBuyIngot[number];
                if (playerManager.questProgress[4] >= playerManager.questProgressNeed[4])
                {
                    playerManager.questProgress[4] = 0;
                    playerManager.questLevel[4] += 1;
                    playerManager.upgradeLevelMax[4] += 1;

                    playerManager.UpdateQuest();
                    playerManager.UpdateUpgrade();
                }
            }

            _tLU.StartAnim();
            playerManager.UpdateIngot();
            OnMouseEnter();
        }
    }
}
