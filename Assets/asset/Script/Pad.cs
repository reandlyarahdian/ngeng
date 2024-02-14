using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pad : MonoBehaviour
{
    public Text test;

    private bool hasCoroutineStarted = false;

    void OnTriggerEnter(Collider other)
    {
            hasCoroutineStarted = true;
            StartCoroutine(DoSomething(other));
    }
    private void OnTriggerExit(Collider other)
    {
        hasCoroutineStarted = false;
    }

    IEnumerator DoSomething(Collider other)
    {
        while (hasCoroutineStarted == true)
        {
            yield return new WaitForSeconds(10);
            test.text = other.name.ToString();
        }


    }
}