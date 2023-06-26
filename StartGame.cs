using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject player;
    public float hideSpeed = 5f;
    public GameObject logotext;

    public static bool isStart;
    
    private void Update()
    {
        if (isStart && logotext != null)
        {
            logotext.transform.Translate(Vector2.up * hideSpeed * Time.deltaTime);
        }
    }

    public void GameStart()
    {
        CreatePlayer();
        isStart= true;
        logotext.GetComponent<Animator>().enabled = false;
        Destroy(logotext, 2f);
        GetComponent<Animation>().Play("HidePlayBtn");
    }

    public void CreatePlayer()
    {
        Instantiate(player, new Vector2(-0.99f, -2.95f), Quaternion.identity);
    }
}
