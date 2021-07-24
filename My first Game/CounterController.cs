using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class CounterController : MonoBehaviour
{
    int numberOfDiamonds;
    public Text counterView;
    // Start is called before the first frame update
    void Start()
    {
        ResetCounter();
    }

    // Update is called once per frame
    public void IncrementCounter()
    {
        numberOfDiamonds++;
        counterView.text = numberOfDiamonds.ToString();
    }
    public void ResetCounter ()
    {
        numberOfDiamonds = 0;
        counterView.text = numberOfDiamonds.ToString();
    }
}
