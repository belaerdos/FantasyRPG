using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevation_Entry : MonoBehaviour
{
    public Collider2D[] mountainColliders;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            foreach (Collider2D mountain in mountainColliders)
            {
                mountain.enabled = false;
            }
            collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 15;
        }
    }
}
