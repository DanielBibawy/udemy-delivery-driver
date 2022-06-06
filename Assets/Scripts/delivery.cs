using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delivery : MonoBehaviour
{

    public Color32 hasPackageColor = new Color32 (1, 1, 1, 1);
    public Color32 noPackageColor = new Color32 (1, 1, 1, 1);
    bool hasPackage = false;
    public float destroyDelay = 0.5f;

    SpriteRenderer spriteRenderer;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ouch!");
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        //package pick up
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }


        //package drop off
        if (other.tag == "Drop Off" && hasPackage)
        {
            Debug.Log("Package Dropped!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
