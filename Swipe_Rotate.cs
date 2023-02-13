using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe_Rotate : MonoBehaviour
{
    private float posisiAwal;
    private float speedRotasi = 125.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    posisiAwal = touch.position.x;
                    break;
                case TouchPhase.Moved:
                    if (posisiAwal > touch.position.x)
                    {
                        transform.Rotate(Vector3.up, -speedRotasi * Time.deltaTime);
                    }else if (posisiAwal < touch.position.x)
                    {
                        transform.Rotate(Vector3.up, speedRotasi * Time.deltaTime);
                    }
                    break;
                case TouchPhase.Stationary:
                    posisiAwal = touch.position.x;
                    break;

            }
        }
    }
}
