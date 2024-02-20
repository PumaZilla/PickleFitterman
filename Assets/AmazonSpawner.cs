using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmazonSpawner : MonoBehaviour
{
    public void SpawnItem(GameObject item)
    {
        Instantiate(item, transform.position, transform.rotation);
    }
}
