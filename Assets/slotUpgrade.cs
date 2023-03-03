using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slotUpgrade : MonoBehaviour
{

    public int number;

    public Image _imageIcon;
    public Sprite[] _spriteIcon;

    public Image _image;
    public Sprite[] _iconOnOff;

    private bool onOff = true;

    private Vector3 scaleBar = new Vector3(1f, 1f, 1f);
    private Vector3 posCur;

    void Update()
    {
        if(playerManager.money >= playerManager.upgradeCost[playerManager.upgradeSlot[number]])
        {
            if(onOff == false)
            {
                _image.sprite = _iconOnOff[0];
                onOff = true;
            }
        }
        else
        {
            if (onOff == true)
            {
                _image.sprite = _iconOnOff[1];
                onOff = false;
            }
        }
    }




    public void UpdateSlot()
    {
        _imageIcon.sprite = _spriteIcon[playerManager.upgradeSlot[number]];
    }





    private void OnMouseEnter()
    {
        playerManager._tooltipUpgrade.gameObject.SetActive(true);
        posCur = transform.position;
        posCur.x -= 1.4f;
        posCur.y += 0f;
        playerManager._tooltipUpgrade.transform.position = posCur;
        playerManager._tooltipUpgrade.TooltipSize(number);
    }
    private void OnMouseExit()
    {
        playerManager._tooltipUpgrade.gameObject.SetActive(false);
    }





    private void OnMouseUpAsButton()
    {
        if(playerManager.money >= playerManager.upgradeCost[playerManager.upgradeSlot[number]])
        {
            playerManager.money -= playerManager.upgradeCost[playerManager.upgradeSlot[number]];
            playerManager.upgradeLevel[playerManager.upgradeSlot[number]] += 1;

            playerManager.UpdateUpgrade();
            playerManager.UpdateOre();
            playerManager.UpdateIngot();
            playerManager.UpdateWeapon();

            if(playerManager.upgradeSlot[number] >= 0)
                OnMouseEnter();
            else
                OnMouseExit();
        }
    }




}
