using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonChangTypeWeapon : MonoBehaviour
{

    public int number;


    public panelChangeWeapon _pCW;


    public Image _image;
    public Sprite[] _icon;

    private bool onOff = true;
    private Vector3 pos;
    private bool onOff2 = true;

    private void Awake()
    {
        pos = transform.localPosition;
    }

    private void Update()
    {
        if(playerManager.panelTypeWeapon[panelChangeWeapon.weaponOn] == number)
        {
            if(onOff == false)
            {
                pos.y = 122f;
                transform.localPosition = pos;
                onOff = true;
            }
        }
        else
        {
            if (onOff == true)
            {
                pos.y = 112f;
                transform.localPosition = pos;
                onOff = false;
            }
        }

        if(playerManager.fragnetOn[number,0,0] > 0)
        {
            if(onOff2 == false)
            {
                _image.sprite = _icon[0];
                onOff2 = true;
            }
        }
        else
        {
            if (onOff2 == true)
            {
                _image.sprite = _icon[1];
                onOff2 = false;
            }
        }



    }



    private void OnMouseUpAsButton()
    {
        if(onOff2 == true && playerManager.panelTypeWeapon[panelChangeWeapon.weaponOn] != number)
        {
            playerManager.panelTypeWeapon[panelChangeWeapon.weaponOn] = number;
            _pCW.UpdatePanel();
            _pCW.UpdateWeapon();
        }
    }




}
