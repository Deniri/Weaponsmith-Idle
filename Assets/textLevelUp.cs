using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textLevelUp : MonoBehaviour
{

    private int state = 0;
    private Vector3 scaleText = new Vector3(1f, 1f, 1f);

    void Update()
    {
        if (state == 1)
        {
            scaleText.x += 5f * Time.deltaTime;
            scaleText.y += 5f * Time.deltaTime;

            if (scaleText.x >= 1.3f)
            {
                scaleText.x = 1.3f;
                scaleText.y = 1.3f;
                state = 2;
            }
            transform.localScale = scaleText;
        }
        if (state == 2)
        {
            scaleText.x -= 5f * Time.deltaTime;
            scaleText.y -= 5f * Time.deltaTime;

            if (scaleText.x <= 1f)
            {
                scaleText.x = 1f;
                scaleText.y = 1f;
                state = 0;
            }
            transform.localScale = scaleText;
        }
    }

    public void StartAnim()
    {
        state = 1;
        scaleText.x = 1f;
        scaleText.y = 1f;
    }
}
