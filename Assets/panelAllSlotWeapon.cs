using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelAllSlotWeapon : MonoBehaviour
{

    public slotChangeWeapon[] _allSlot;

    public void Start()
    {
        UpdateAllSlot();
    }


    public void UpdateAllSlot()
    {
        for(int i = 0; i < 20; i++)
        {
            if(playerManager.fragnetOn[playerManager.panelTypeWeapon[panelChangeWeapon.weaponOn], playerManager.panelFragmentWeapon, i] < 2)
            {
                _allSlot[i].gameObject.SetActive(true);
                _allSlot[i].UpdateIcon();
            }
            else
            {
                _allSlot[i].gameObject.SetActive(false);
            }
        }
    }



}
