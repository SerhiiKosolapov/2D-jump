using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathZone : MonoBehaviour
{
    public GameObject player;
    public GameObject deathZone;

    private void Start()
    {
        //deathZone.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            deathZone.SetActive(true);
            Destroy(player);
            StartGame.isStart = false;
            SceneManager.LoadScene("Main");
        }
    }
}
