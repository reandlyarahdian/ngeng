using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sign : MonoBehaviour
{
    public Rigidbody test;
    int count = 0;
    public Text tilang;
    bool good;
    public GameObject game;
    private void Start()
    {
        test.GetComponent<Rigidbody>();
    }
    IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("sign"))
        {
            yield return new WaitForSeconds(20);
            good = true;
            StartCoroutine(settext());
        }
        if (other.gameObject.CompareTag("cross"))
        {
            yield return new WaitForSeconds(5);
            good = true;
            StartCoroutine(settext());

        }
        if (other.gameObject.CompareTag("trotoar"))
        {
            good = true;
            StartCoroutine(settext());
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("sign"))
        {
            good = false;
        }
        if (other.gameObject.CompareTag("cross"))
        {
            good = false;
        }
        if (other.gameObject.CompareTag("trotoar"))
        {
            good = false;
        }
    }
    IEnumerator settext()
    {
        if (good) {
            count = count + 1;
            tilang.text = count + " Pelanggaran";
            if (count >= 1)
            {
                game.SetActive(true);
                test.velocity = new Vector3(0, 0, 0);
                yield return new WaitForSeconds(2);
                game.SetActive(false);
            }
        }
    }
}
