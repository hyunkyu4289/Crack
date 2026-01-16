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
    void Update()
    {
        transform.position += Vector3.down * Speed * Time.deltaTime;

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
