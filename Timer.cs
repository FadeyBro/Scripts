using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public TextMeshProUGUI timer;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (seconds <= 0)
        {
            if (minutes > 0)
            {
                minutes -= 1;
                seconds = 59.0f;
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
