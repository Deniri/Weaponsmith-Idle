using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelUpgrade : MonoBehaviour
{

    public int number;

    public slotUpgrade[] _allSlot;

    private void Awake()
    {
        transform.localPosition = new Vector3(357f, -50f, 0f);
        playerManager._pU = this;
    }

    private void OnEnable()
    {
        playerManager.UpdateUpgrade();
    }


    void FixedUpdate()
    {
        if(playerManager.numberPanelMain != number)
        {
            gameObject.SetActive(false);
        }
    }


    public void UpdateAllSlot()
    {
        for(int i = 0; i < _allSlot.Length; i++)
        {
            if (playerManager.upgradeAmountOn > i)
            {
                _allSlot[i].gameObject.SetActive(true);
                _allSlot[i].UpdateSlot();
            }
            else
            {
                _allSlot[i].gameObject.SetActive(false);
            }
        }
        
    }


}
