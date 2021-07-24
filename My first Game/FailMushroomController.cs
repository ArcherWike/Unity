using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailMushroomController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            other.gameObject.GetComponent<Animator>().SetTrigger("fail");
        }
    }
}
