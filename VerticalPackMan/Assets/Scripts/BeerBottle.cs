using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerBottle : MonoBehaviour
{
    public float speed;

    private void Awake()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = Random.Range(-3.3f, 3.3f);
        transform.position = newPosition;
    }


    private void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.y -= speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
