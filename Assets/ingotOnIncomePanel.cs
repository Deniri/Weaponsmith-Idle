using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ingotOnIncomePanel : MonoBehaviour
{
    public Image _image;

    public Sprite[] _iconIngot;
    public void UpdateIngot(int number)
    {

        _image.sprite = _iconIngot[playerManager.IngotUsed[number]];

        _image.SetNativeSize();
    }
}
