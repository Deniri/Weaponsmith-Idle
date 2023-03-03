using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weaponOnIncomePanel : MonoBehaviour
{
    public Image _imageTop;
    public Image _imageMid;
    public Image _imageDown;


    //меч
    public Sprite[] _iconSwordTop;
    public Sprite[] _iconSwordMid;
    public Sprite[] _iconSwordDown;

    //дагер
    public Sprite[] _iconDaggerTop;
    public Sprite[] _iconDaggerMid;
    public Sprite[] _iconDaggerDown;

    //саи
    public Sprite[] _iconSaiTop;
    public Sprite[] _iconSaiMid;
    public Sprite[] _iconSaiDown;

    //копьё
    public Sprite[] _iconSpearTop;
    public Sprite[] _iconSpearMid;
    public Sprite[] _iconSpearDown;

    //молот
    public Sprite[] _iconHammerTop;
    public Sprite[] _iconHammerMid;
    public Sprite[] _iconHammerDown;

    //булава
    public Sprite[] _iconMaceTop;
    public Sprite[] _iconMaceMid;
    public Sprite[] _iconMaceDown;




    public void UpdateWeapon()
    {

        if (playerManager.panelTypeWeapon[panelChangeWeapon.weaponOn] == 0)
        {
            _imageTop.sprite = _iconSwordTop[playerManager.SlotUsed[panelChangeWeapon.weaponOn, 0, 0]];
            _imageMid.sprite = _iconSwordMid[playerManager.SlotUsed[panelChangeWeapon.weaponOn, 0, 1]];
            _imageDown.sprite = _iconSwordDown[playerManager.SlotUsed[panelChangeWeapon.weaponOn, 0, 2]];
        }
        if (playerManager.panelTypeWeapon[panelChangeWeapon.weaponOn] == 1)
        {
            _imageTop.sprite = _iconDaggerTop[playerManager.SlotUsed[panelChangeWeapon.weaponOn, 1, 0]];
            _imageMid.sprite = _iconDaggerMid[playerManager.SlotUsed[panelChangeWeapon.weaponOn, 1, 1]];
            _imageDown.sprite = _iconDaggerDown[playerManager.SlotUsed[panelChangeWeapon.weaponOn, 1, 2]];
        }
        if (playerManager.panelTypeWeapon[panelChangeWeapon.weaponOn] == 2)
        {
            _imageTop.sprite = _iconSaiTop[playerManager.SlotUsed[panelChangeWeapon.weaponOn, 2, 0]];
            _imageMid.sprite = _iconSaiMid[playerManager.SlotUsed[panelChangeWeapon.weaponOn, 2, 1]];
            _imageDown.sprite = _iconSaiDown[playerManager.SlotUsed[panelChangeWeapon.weaponOn, 2, 2]];
        }
        if (playerManager.panelTypeWeapon[panelChangeWeapon.weaponOn] == 3)
        {
            _imageTop.sprite = _iconSpearTop[playerManager.SlotUsed[panelChangeWeapon.weaponOn, 3, 0]];
            _imageMid.sprite = _iconSpearMid[playerManager.SlotUsed[panelChangeWeapon.weaponOn, 3, 1]];
            _imageDown.sprite = _iconSpearDown[playerManager.SlotUsed[panelChangeWeapon.weaponOn, 3, 2]];
        }
        if (playerManager.panelTypeWeapon[panelChangeWeapon.weaponOn] == 4)
        {
            _imageTop.sprite = _iconHammerTop[playerManager.SlotUsed[panelChangeWeapon.weaponOn, 4, 0]];
            _imageMid.sprite = _iconHammerMid[playerManager.SlotUsed[panelChangeWeapon.weaponOn, 4, 1]];
            _imageDown.sprite = _iconHammerDown[playerManager.SlotUsed[panelChangeWeapon.weaponOn, 4, 2]];
        }
        if (playerManager.panelTypeWeapon[panelChangeWeapon.weaponOn] == 5)
        {
            _imageTop.sprite = _iconMaceTop[playerManager.SlotUsed[panelChangeWeapon.weaponOn, 5, 0]];
            _imageMid.sprite = _iconMaceMid[playerManager.SlotUsed[panelChangeWeapon.weaponOn, 5, 1]];
            _imageDown.sprite = _iconMaceDown[playerManager.SlotUsed[panelChangeWeapon.weaponOn, 5, 2]];
        }

        _imageTop.SetNativeSize();
        _imageMid.SetNativeSize();
        _imageDown.SetNativeSize();




    }
}
