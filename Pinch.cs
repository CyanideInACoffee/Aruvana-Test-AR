using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinch : MonoBehaviour
{
    public GameObject logo;
    private float jarak;
    private Vector3 skala;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 2)
        {
            var touchNol = Input.GetTouch(0);
            var touchSatu = Input.GetTouch(1);

            if (touchNol.phase == TouchPhase.Ended || touchNol.phase == TouchPhase.Canceled || 
                    touchSatu.phase == TouchPhase.Ended || touchSatu.phase == TouchPhase.Canceled)
            {
                return;
            }

            if (touchNol.phase == TouchPhase.Began || touchSatu.phase == TouchPhase.Began)
            {
                jarak = Vector2.Distance(touchNol.position, touchSatu.position);
                skala = logo.transform.localScale;
                               
            }
            else
            {
                var titik_jarak = Vector2.Distance(touchNol.position, touchSatu.position);
                
                if (Mathf.Approximately(jarak,0))
                {
                    return;
                }

                var faktor = titik_jarak / jarak;
                logo.transform.localScale = skala * faktor;
            }
        }
        
    }
}
