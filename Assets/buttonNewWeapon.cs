using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class buttonNewWeapon : MonoBehaviour
{
    public TextMeshProUGUI textCost;

    public GameObject[] panelWeapon;

    public Button _button;

    private float[] posX = new float[] { -330f, -190f, -50f, 90f };
    private Vector3 vec3;

    private bool onOff = true;

    private void Awake()
    {
        vec3 = transform.localPosition;

    }

    private void Start()
    {
        UpdatePos();
    }

    void Update()
    {

        if (playerManager.weaponAmount >= 5)
            gameObject.SetActive(false);
        else
        {
            textCost.text = $"Weapon\n<sprite=2>{playerManager.Reduction_0(playerManager.costNewWeapon[playerManager.weaponAmount - 1])}";

            if (playerManager.ingot >= playerManager.costNewWeapon[playerManager.weaponAmount - 1])
            {
                if (onOff == false)
                {
                    _button.interactable = true;
                    onOff = true;
                }
            }
            else
            {
                if (onOff == true)
                {
                    _button.interactable = false;
                    onOff = false;
                }
            }
        }






    }


    public void UpdatePos()
    {
        vec3.x = posX[playerManager.weaponAmount - 1];
        transform.localPosition = vec3;
    }




    private void OnMouseDown()
    {
        if (playerManager.ingot >= playerManager.costNewWeapon[playerManager.weaponAmount - 1])
        {
            playerManager.ingot -= playerManager.costNewWeapon[playerManager.weaponAmount - 1];
            playerManager.weaponAmount += 1;
            panelWeapon[playerManager.weaponAmount - 1].gameObject.SetActive(true);

            if (playerManager.weaponAmount < 5)
                UpdatePos();

            playerManager.UpdateWeapon();
        }
    }
}
