using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinking : MonoBehaviour
{
    public float waktu;
    public GameObject model;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waktu -= Time.deltaTime;

        if (waktu <= 0)
        {
            waktu = 3;
            model.SetActive(false);
            StartCoroutine(delayBlink());
        }
        
    }

    IEnumerator delayBlink()
    {
        yield return new WaitForSeconds(0.5f);
        model.SetActive(true);
    }
}
