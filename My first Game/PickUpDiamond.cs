using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpDiamond : MonoBehaviour
{
    CounterController counterController;
    // Start is called before the first frame update
    void Start()
    {
        counterController = GameObject.Find("Manager").GetComponent<CounterController>();
        if (counterController == null)
        {
            Debug.LogError("CounterController nie zostal znaleziony!");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            Destroy(this.gameObject);
            counterController.IncrementCounter();
        }
    }
}
