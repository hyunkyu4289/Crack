using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public float Speed = 5;

    void Update()
    {
        transform.position += Vector3.down * Speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.A) && transform.position.x == -2)
        {
            gameObject.SetActive(false);

            if (transform.position.y > 4)
            {
                Debug.Log("Miss");
            }
            if (transform.position.y < 3 && transform.position.y > 2)
            {
                Debug.Log("Good");
            }
            if (transform.position.y < 2 && transform.position.y > 1)
            {
                Debug.Log("Great");
            }
            if (transform.position.y < 1 && transform.position.y > -1)
            {
                Debug.Log("Perfect");
            }
        }
        if (Input.GetKeyDown(KeyCode.S) && transform.position.x == 0)
        {
            gameObject.SetActive(false);

            if (transform.position.y > 4)
            {
                Debug.Log("Miss");
            }
            if (transform.position.y < 3 && transform.position.y > 2)
            {
                Debug.Log("Good");
            }
            if (transform.position.y < 2 && transform.position.y > 1)
            {
                Debug.Log("Great");
            }
            if (transform.position.y < 1 && transform.position.y > -1)
            {
                Debug.Log("Perfect");
            }
        }
        if (Input.GetKeyDown(KeyCode.Semicolon) && transform.position.x == 2)
        {
            gameObject.SetActive(false);

            if (transform.position.y > 4)
            {
                Debug.Log("Miss");
            }
            if (transform.position.y < 3 && transform.position.y > 2)
            {
                Debug.Log("Good");
            }
            if (transform.position.y < 2 && transform.position.y > 0.5)
            {
                Debug.Log("Great");
            }
            if (transform.position.y < 0.5 && transform.position.y > -0.5)
            {
                Debug.Log("Perfect");
            }
        }
        if (Input.GetKeyDown(KeyCode.Quote) && transform.position.x == 4)
        {
            gameObject.SetActive(false);

            if (transform.position.y > 4)
            {
                Debug.Log("Miss");
            }
            if (transform.position.y < 3 && transform.position.y > 2)
            {
                Debug.Log("Good");
            }
            if (transform.position.y < 2 && transform.position.y > 1)
            {
                Debug.Log("Great");
            }
            if (transform.position.y < 1 && transform.position.y > -1)
            {
                Debug.Log("Perfect");
            }
        }

        if (transform.position.y < -1.3)
        {
            gameObject.SetActive(false);
            Debug.Log("Miss");
        }
    }
}