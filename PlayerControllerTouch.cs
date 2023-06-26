using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEditor;
using UnityEngine;

public class PlayerControllerTouch : MonoBehaviour
{
    public GameObject player;
    private Vector3 targetPosition;
    public float speed = 5f;

    private void Update()
    {
        if (StartGame.isStart)
        {
#if UNITY_ANDROID
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Moved)
                {
                    targetPosition = Camera.main.ScreenToWorldPoint(touch.position);
                }
            }
#endif
#if UNITY_EDITOR
            if (Input.GetMouseButton(1))
            {
                targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
#endif
            float step = speed * Time.deltaTime;

            if (targetPosition.x < -2.5f)
            {
                targetPosition.x = -2.5f;
            }

            if (targetPosition.x > 2.5f)
            {
                targetPosition.x = 2.5f;
            }

            if (targetPosition.y < -4.2f)
            {
                targetPosition.y = -4.2f;
            }

            if (targetPosition.y > 4.5f)
            {
                targetPosition.y = 4.5f;
            }

            player.transform.position = Vector3.MoveTowards(new Vector3(targetPosition.x, player.transform.position.y, player.transform.position.z), player.transform.position, step);
        }
    }
}
