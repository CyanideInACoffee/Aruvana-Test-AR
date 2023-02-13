using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suara : DefaultTrackableEventHandler
{
    // Start is called before the first frame update

    public AudioSource suara;
    private void Awake()
    {
        suara = GetComponent<AudioSource>();
    }

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        suara.Play();
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        suara.Stop();
    }

}
