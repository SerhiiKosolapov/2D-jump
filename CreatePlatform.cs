using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlatform : MonoBehaviour
{
    public GameObject plaform;
    private bool isSpawn;
    private float waitTime = 1f;
    private void Update()
    {
        if (StartGame.isStart && !isSpawn)
        {
            StartCoroutine(spawnPlatform());
            isSpawn = true;
        }
    }

    IEnumerator spawnPlatform()
    {
        while (true)
        {
            Instantiate(plaform, new Vector2(Random.Range(-2.5f, 2.5f), 7.8f), Quaternion.identity );
            yield return new WaitForSeconds(waitTime);
        }
    }
}
