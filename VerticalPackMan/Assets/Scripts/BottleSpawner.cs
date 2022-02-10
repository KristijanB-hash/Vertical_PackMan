using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleSpawner : MonoBehaviour
{
    public GameObject Prefab;
   // public int numberOfBottles;
    public float bottlesSpawnDistance;
    public float delayOfSpawningBottles;

    private void Start()
    {
        InvokeRepeating("SpawnBeer", 0f, delayOfSpawningBottles);
    }

    private void SpawnBeer()
    {
        Instantiate(Prefab);
    }

   /* private IEnumerator SpawnBottlesWithDelay()
    {
        while(true)
        {
            Instantiate(beerBottlePrefab);
            yield return new WaitForSeconds(delayOfSpawningBottles);
        }
    }
   */



    /*private void Awake()
    {
        float posY = 6.2f;
        // spawn bottle objects
        for (int i = 0; i < numberOfBottles; i++)
        {
            GameObject beerBottleClone = Instantiate(beerBottlePrefab);
            var beerBottlePos = beerBottleClone.transform.position;
            beerBottlePos.y = posY;
            beerBottleClone.transform.position = beerBottlePos;

            posY += bottlesSpawnDistance;
        }
        
    }
    */

    
}
