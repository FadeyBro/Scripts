using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip damageSound;

    public int health = 10;
    public int maxhealth = 10;

    public int coin = 0;

    public GameObject fireballPrefab;
    public Transform attackPoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }

    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health > 0)
        {
            print("Health:" + health);
            audioSource.PlayOneShot(damageSound);

        }
        else
        {
            print("You Dead");
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
     
    public void CollectCoins()
    {
        coin += 1;
        print("coins" + coin);
    }
}
