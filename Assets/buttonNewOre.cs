using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class buttonNewOre : MonoBehaviour
{
    
    public TextMeshProUGUI textCost;

    public GameObject[] panelOre;

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

        if (playerManager.oreAmount >= 5)
            gameObject.SetActive(false);
        else
        {
            textCost.text = $"mine\n<sprite=0>{playerManager.Reduction_0(playerManager.costNewOre[playerManager.oreAmount - 1])}";

            if(playerManager.money >= playerManager.costNewOre[playerManager.oreAmount - 1])
            {
                if(onOff == false)
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
        vec3.x = posX[playerManager.oreAmount - 1];
        transform.localPosition = vec3;
    }




    private void OnMouseDown()
    {
        if(playerManager.money >= playerManager.costNewOre[playerManager.oreAmount - 1])
        {
            playerManager.money -= playerManager.costNewOre[playerManager.oreAmount - 1];
            playerManager.oreAmount += 1;
            panelOre[playerManager.oreAmount - 1].gameObject.SetActive(true);

            if (playerManager.oreAmount < 5)
                UpdatePos();

            playerManager.UpdateOre();
        }
    }


}
