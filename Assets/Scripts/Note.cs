<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public float Speed = 5;

=======
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{
    static int Score;
    static int Combo;
    public float Speed = 5;
    public Text[] text;

     void Start()
    {
    }
>>>>>>> e146ca558b7557d0b2385c2fc5627e51ba955497
    void Update()
    {
        transform.position += Vector3.down * Speed * Time.deltaTime;

<<<<<<< HEAD
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
=======
        if (transform.position.y < -2)
        {
            Score -= 1000;
            Combo = 0;
            Debug.Log("Miss");
            gameObject.SetActive(false);
            text[0].text = "Score :" + Score.ToString();
            text[1].text = "Combo" + "\n" + "\n" + "     " + Combo.ToString();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (transform.position.y < 1 && transform.position.y > -1)
            {
                Combo += 1;
                gameObject.SetActive(false);
                text[1].text = "Combo" + "\n" + "\n" + "     " + Combo.ToString();
            }
        }
    }

}
>>>>>>> e146ca558b7557d0b2385c2fc5627e51ba955497
