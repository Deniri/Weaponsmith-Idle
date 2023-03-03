using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelQuest : MonoBehaviour
{
    public int number;

    public slotQuest[] _allSlot;

    private void Awake()
    {
        transform.localPosition = new Vector3(357f, -50f, 0f);
        playerManager._pQ = this;
        gameObject.SetActive(false);
    }


    private void OnEnable()
    {
        playerManager.UpdateQuest();
    }



    void FixedUpdate()
    {
        if (playerManager.numberPanelMain != number)
        {
            gameObject.SetActive(false);
        }
    }


    public void UpdateAllSlot()
    {
        for(int i = 0; i < 36; i++)
        {
            if(playerManager.questAmountOn > i)
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
