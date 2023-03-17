using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonBuyWeapon : MonoBehaviour
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
        if (playerManager.ingot >= playerManager.CostWeapon[number])
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
        playerManager._tooltipButtonBuyWeapon.gameObject.SetActive(true);
        posCur = transform.position;
        posCur.x += 2f;
        posCur.y += 1f;
        playerManager._tooltipButtonBuyWeapon.transform.position = posCur;
        playerManager._tooltipButtonBuyWeapon.TooltipSize(number);
    }
    private void OnMouseExit()
    {
        playerManager._tooltipButtonBuyWeapon.gameObject.SetActive(false);
    }




    public void OnMouseUpAsButton()
    {
        if (buttonOnOff == true)
        {
            playerManager.ingot -= playerManager.CostWeapon[number];
            playerManager.levelWeapon[number] += playerManager.XBuyWeapon[number];

            //quest 5
            if (playerManager.questOn[5] > 0 && playerManager.questLevel[5] < playerManager.questLevelMax[5])
            {
                playerManager.questProgress[5] += playerManager.XBuyWeapon[number];
                if (playerManager.questProgress[5] >= playerManager.questProgressNeed[5])
                {
                    playerManager.questProgress[5] = 0;
                    playerManager.questLevel[5] += 1;
                    playerManager.upgradeLevelMax[5] += 1;

                    playerManager.UpdateQuest();
                    playerManager.UpdateUpgrade();

                }
            }

            _tLU.StartAnim();
            playerManager.UpdateWeapon();
            OnMouseEnter();
        }
    }
}
