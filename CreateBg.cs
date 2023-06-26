using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CreateBg : MonoBehaviour
{
    public GameObject now_bg;
    public GameObject bg_inst;
    private GameObject new_bg;

    // Update is called once per frame
    void Update()
    {
        if (StartGame.isStart)
        {
            if (now_bg.transform.position.y <= -1f && new_bg == null)
            {
                CreateNewBg();
            }
            else if (new_bg != null && new_bg.transform.position.y <= -1f)
            {
                CreateNewBg();
            }
        }
    }

    void CreateNewBg()
    {
        if (now_bg.transform.position.y < -6f)
        {
            Destroy(now_bg);
            now_bg = new_bg;                                                                                                                                                                    
        }
        new_bg = Instantiate(bg_inst, new Vector2(-3.11f, 7.8f), Quaternion.identity) as GameObject;
    }
}
