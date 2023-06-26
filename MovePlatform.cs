using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform  : MonoBehaviour
{
    public float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        if (StartGame.isStart)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        if (transform.position.y <= -6f)
        {
            Destroy(gameObject);
        }
    }
}
