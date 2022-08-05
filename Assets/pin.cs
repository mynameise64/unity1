using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (transform.position.y < 0) {
        Instantiate(gameObject,new(transform.position.x,0.4f,transform.position.z),transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //print("r");
        //print(Mathf.Abs(transform.rotation.x));
        if (Mathf.Abs(transform.rotation.x) >= .15 || Mathf.Abs(transform.rotation.z) >= .25) {
            //print("h");
            //scoring.pinsDown++;
            if (bowl.shot == 1) {
                bowl.shot1++;
            } else {
                bowl.shot2++;
            }
            Destroy(gameObject);
        }
    }
}
