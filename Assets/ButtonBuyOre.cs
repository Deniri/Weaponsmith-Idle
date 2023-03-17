using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBuyOre : MonoBehaviour
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
        if (playerManager.money >= playerManager.CostOre[number])
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
        playerManager._tooltipButtonBuyOre.gameObject.SetActive(true);
        posCur = transform.position;
        posCur.x += 2f;
        posCur.y += 1f;
        playerManager._tooltipButtonBuyOre.transform.position = posCur;
        playerManager._tooltipButtonBuyOre.TooltipSize(number);
    }
    private void OnMouseExit()
    {
        playerManager._tooltipButtonBuyOre.gameObject.SetActive(false);
    }




    public void OnMouseUpAsButton()
    {
        if (buttonOnOff == true)
        {
            playerManager.money -= playerManager.CostOre[number];
            playerManager.levelOre[number] += playerManager.XBuyOre[number];

            //quest 3
            if (playerManager.questOn[3] > 0 && playerManager.questLevel[3] < playerManager.questLevelMax[3])
            {
                playerManager.questProgress[3] += playerManager.XBuyOre[number];
                if (playerManager.questProgress[3] >= playerManager.questProgressNeed[3])
                {
                    playerManager.questProgress[3] = 0;
                    playerManager.questLevel[3] += 1;
                    playerManager.upgradeLevelMax[3] += 1;

                    playerManager.UpdateQuest();
                    playerManager.UpdateUpgrade();
                }
            }

            _tLU.StartAnim();
            playerManager.UpdateOre();
            OnMouseEnter();
        }
    }
}
