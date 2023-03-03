using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class buttonNewIgnot : MonoBehaviour
{
    public TextMeshProUGUI textCost;

    public GameObject[] panelIngot;

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

        if (playerManager.IngotAmount >= 5)
            gameObject.SetActive(false);
        else
        {
            textCost.text = $"furnace\n<sprite=1>{playerManager.Reduction_0(playerManager.costNewIngot[playerManager.IngotAmount - 1])}";

            if (playerManager.ore >= playerManager.costNewIngot[playerManager.IngotAmount - 1])
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
        vec3.x = posX[playerManager.IngotAmount - 1];
        transform.localPosition = vec3;
    }




    private void OnMouseDown()
    {
        if (playerManager.ore >= playerManager.costNewIngot[playerManager.IngotAmount - 1])
        {
            playerManager.ore -= playerManager.costNewIngot[playerManager.IngotAmount - 1];
            playerManager.IngotAmount += 1;
            panelIngot[playerManager.IngotAmount - 1].gameObject.SetActive(true);

            if (playerManager.IngotAmount < 5)
                UpdatePos();

            playerManager.UpdateIngot();
        }
    }
}
