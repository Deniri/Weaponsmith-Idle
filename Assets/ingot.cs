using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ingot : MonoBehaviour
{
    public Image _image;

    public Sprite[] _iconIngot;

    public void UpdateIngot()
    {

        _image.sprite = _iconIngot[playerManager.IngotUsed[panelChangeIngot.IngotOn]];

        _image.SetNativeSize();
    }
}
