using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slotChangeIngot : MonoBehaviour
{
    public int number;


    public panelChangeIngot _pCI;

    public Image _image;

    public Sprite[] _iconSlot;

    private int onOff = 0;

    private void Update()
    {
        if (playerManager.IngotOn[number] == 0)
        {
            if (onOff != 2)
            {
                _image.sprite = _iconSlot[2];
                onOff = 2;
            }
        }
        else
        {
            if (playerManager.IngotUsed[panelChangeIngot.IngotOn] == number)
            {
                if (onOff != 1)
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




    private void OnMouseUpAsButton()
    {
        if (onOff == 0)
        {
            playerManager.IngotUsed[panelChangeIngot.IngotOn] = number;
            _pCI.UpdateIngot();
        }
    }
}
