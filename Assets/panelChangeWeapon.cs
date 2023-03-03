using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class panelChangeWeapon : MonoBehaviour
{

    public static int weaponOn;

    public TextMeshProUGUI textName;
    public TextMeshProUGUI textProp;
    



    public buttonChangFragmentWeapon[] _bCFW;
    public panelAllSlotWeapon _pASW;

    public weapon _weapon;


    public panelWeapon[] _pw;



    private void Awake()
    {
        transform.localPosition = new Vector3(0f, 0f, 0f);
        gameObject.SetActive(false);
    }



    public void UpdatePanel()
    {
        _bCFW[0].ChangeWeaponIcon();
        _bCFW[1].ChangeWeaponIcon();
        _bCFW[2].ChangeWeaponIcon();

        _pASW.UpdateAllSlot();

        playerManager.UpdateWeapon();
        _pw[weaponOn].UpdateWeapon();
    }

    public void UpdateWeapon()
    {
        _weapon.UpdateWeapon();
        playerManager.UpdateWeapon();
        _pw[weaponOn].UpdateWeapon();


        textName.text = allTextManager.weaponName[playerManager.panelTypeWeapon[weaponOn]];
        textProp.text = $"Increased income: <#21CB1E>x{playerManager.Reduction_2(1d + playerManager.SlotUsedIncome[weaponOn, 0] + playerManager.SlotUsedIncome[weaponOn, 1] + playerManager.SlotUsedIncome[weaponOn, 2])}";
    }

}
