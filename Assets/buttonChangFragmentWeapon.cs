using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonChangFragmentWeapon : MonoBehaviour
{
    public int number;

    public panelChangeWeapon _pCW;

    public Image _image;
    public Sprite[] _icon;
    
    private bool onOff = true;
    private Vector3 pos;


    private void Awake()
    {
        pos = transform.localPosition;
    }

    private void Update()
    {
        if (playerManager.panelFragmentWeapon == number)
        {
            if (onOff == false)
            {
                pos.x = 475f;
                transform.localPosition = pos;
                onOff = true;
            }
        }
        else
        {
            if (onOff == true)
            {
                pos.x = 465f;
                transform.localPosition = pos;
                onOff = false;
            }
        }
    }



    public void ChangeWeaponIcon()
    {
        _image.sprite = _icon[playerManager.panelTypeWeapon[panelChangeWeapon.weaponOn]];
    }





    private void OnMouseUpAsButton()
    {
        if (playerManager.panelFragmentWeapon != number)
        {
            playerManager.panelFragmentWeapon = number;
            _pCW.UpdatePanel();
        }
    }

}
