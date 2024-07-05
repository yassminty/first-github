using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collects : MonoBehaviour
{
    int myScore = 10;

    public int totalNanners = 5;
    public int currentNanners = 0;


    void OnTriggerEnter(Collider collectible)
    {
        if (collectible.gameObject.CompareTag("Player"))
        {
            //collision.gameObject.GetComponent<Player>().IncreaseScore(myScore);

            Debug.Log("wow! i got collected!");
            Destroy(gameObject);


        }
    }

    void CollectiblesCollected()
    {
        currentNanners++;

        if (currentNanners == totalNanners)
        {
            Debug.Log("congrats! you got them all :)");
        }
    }
}
