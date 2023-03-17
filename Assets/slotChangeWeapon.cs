using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slotChangeWeapon : MonoBehaviour
{

    public int number;


    public panelChangeWeapon _pCW;

    public Image _image;
    public Image _imageIcon;

    public Sprite[] _iconSlot;

    //sword
    public Sprite[] _iconSwordTop;
    public Sprite[] _iconSwordMid;
    public Sprite[] _iconSwordDown;

    //dagger
    public Sprite[] _iconDaggerTop;
    public Sprite[] _iconDaggerMid;
    public Sprite[] _iconDaggerDown;

    //sai
    public Sprite[] _iconSaiTop;
    public Sprite[] _iconSaiMid;
    public Sprite[] _iconSaiDown;

    //spear
    public Sprite[] _iconSpearTop;
    public Sprite[] _iconSpearMid;
    public Sprite[] _iconSpearDown;

    //hammer
    public Sprite[] _iconHammerTop;
    public Sprite[] _iconHammerMid;
    public Sprite[] _iconHammerDown;

    //mace
    public Sprite[] _iconMaceTop;
    public Sprite[] _iconMaceMid;
    public Sprite[] _iconMaceDown;



    private int onOff = 0;

    private void Update()
    {
        if(playerManager.fragnetOn[playerManager.panelTypeWeapon[panelChangeWeapon.weaponOn], playerManager.panelFragmentWeapon, number] == 0)
        {
            if (onOff != 2)
            {
                _image.sprite = _iconSlot[2];
                onOff = 2;
            }   
        }
        else
        {
            if(playerManager.SlotUsed[panelChangeWeapon.weaponOn, playerManager.panelTypeWeapon[panelChangeWeapon.weaponOn], playerManager.panelFragmentWeapon] == number)
            {
                if(onOff != 1)
                {
                    _image.sprite = _iconSlot[1];
                    onOff = 1;
                }
            }
            else
            {
                if (onOff != 0)
                {
                    _image.sprite = _iconSlot[0];
                    onOff = 0;
                }
            }
        }
    }






    public void UpdateIcon()
    {
        if (playerManager.panelTypeWeapon[panelChangeWeapon.weaponOn] == 0)
        {
            if (playerManager.panelFragmentWeapon == 0)
                _imageIcon.sprite = _iconSwordTop[number];
            else if (playerManager.panelFragmentWeapon == 1)
                _imageIcon.sprite = _iconSwordMid[number];
            else if (playerManager.panelFragmentWeapon == 2)
                _imageIcon.sprite = _iconSwordDown[number];
        }
        if (playerManager.panelTypeWeapon[panelChangeWeapon.weaponOn] == 1)
        {
            if (playerManager.panelFragmentWeapon == 0)
                _imageIcon.sprite = _iconDaggerTop[number];
            else if (playerManager.panelFragmentWeapon == 1)
                _imageIcon.sprite = _iconDaggerMid[number];
            else if (playerManager.panelFragmentWeapon == 2)
                _imageIcon.sprite = _iconDaggerDown[number];
        }
        if (playerManager.panelTypeWeapon[panelChangeWeapon.weaponOn] == 2)
        {
            if (playerManager.panelFragmentWeapon == 0)
                _imageIcon.sprite = _iconSaiTop[number];
            else if (playerManager.panelFragmentWeapon == 1)
                _imageIcon.sprite = _iconSaiMid[number];
            else if (playerManager.panelFragmentWeapon == 2)
                _imageIcon.sprite = _iconSaiDown[number];
        }
        if (playerManager.panelTypeWeapon[panelChangeWeapon.weaponOn] == 3)
        {
            if (playerManager.panelFragmentWeapon == 0)
                _imageIcon.sprite = _iconSpearTop[number];
            else if (playerManager.panelFragmentWeapon == 1)
                _imageIcon.sprite = _iconSpearMid[number];
            else if (playerManager.panelFragmentWeapon == 2)
                _imageIcon.sprite = _iconSpearDown[number];
        }
        if (playerManager.panelTypeWeapon[panelChangeWeapon.weaponOn] == 4)
        {
            if (playerManager.panelFragmentWeapon == 0)
                _imageIcon.sprite = _iconHammerTop[number];
            else if (playerManager.panelFragmentWeapon == 1)
                _imageIcon.sprite = _iconHammerMid[number];
            else if (playerManager.panelFragmentWeapon == 2)
                _imageIcon.sprite = _iconHammerDown[number];
        }
        if (playerManager.panelTypeWeapon[panelChangeWeapon.weaponOn] == 5)
        {
            if (playerManager.panelFragmentWeapon == 0)
                _imageIcon.sprite = _iconMaceTop[number];
            else if (playerManager.panelFragmentWeapon == 1)
                _imageIcon.sprite = _iconMaceMid[number];
            else if (playerManager.panelFragmentWeapon == 2)
                _imageIcon.sprite = _iconMaceDown[number];
        }

        _imageIcon.SetNativeSize();
    }






    private void OnMouseUpAsButton()
    {
        if(onOff == 0)
        {
            playerManager.SlotUsed[panelChangeWeapon.weaponOn, playerManager.panelTypeWeapon[panelChangeWeapon.weaponOn], playerManager.panelFragmentWeapon] = number;
            _pCW.UpdateWeapon();
        }
    }

}
