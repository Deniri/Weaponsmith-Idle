using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slotQuest : MonoBehaviour
{

    public int number;

    public Image _imageIcon;
    public Sprite[] _spriteIcon;

    public GameObject _bar;

    private Vector3 scaleBar = new Vector3(1f,1f,1f);
    private Vector3 posCur;

    void Update()
    {
        scaleBar.x = (float)(1d / playerManager.questProgressNeed[playerManager.questSlot[number]] * playerManager.questProgress[playerManager.questSlot[number]]);
        if (scaleBar.x > 1f)
            scaleBar.x = 1f;
        _bar.transform.localScale = scaleBar;
    }




    public void UpdateSlot()
    {
        _imageIcon.sprite = _spriteIcon[playerManager.questSlot[number]];
    }





    private void OnMouseEnter()
    {
        playerManager._tooltipQuest.gameObject.SetActive(true);
        posCur = transform.position;
        posCur.x -= 1.4f;
        posCur.y += 0f;
        playerManager._tooltipQuest.transform.position = posCur;
        playerManager._tooltipQuest.TooltipSize(number);
    }
    private void OnMouseExit()
    {
        playerManager._tooltipQuest.gameObject.SetActive(false);
    }





}
