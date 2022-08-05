using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowl : MonoBehaviour
{
    public static int shot = 1;
    public static int round = 1;
    public static int shot1;
    public static int shot2;
    public bool canMove = false;
    
    IEnumerator waitForSecs(float secs)
    {
        yield return new WaitForSeconds(secs);
    }
    private void Update() {
        if (player.holdingBall) {
            GetComponent<Rigidbody>().useGravity=false;
            transform.position = GameObject.Find("player").transform.position;
            if (Input.GetMouseButtonDown(1)) {
                canMove = true;
                //print("e");
            }
        }
        if (canMove) {
            
            if (player.holdingBall) {
                GetComponent<Rigidbody>().useGravity=true;
                transform.rotation = GameObject.Find("player").transform.rotation;
            }
            player.holdingBall = false;
            
            transform.position += transform.forward * player.bowlSpeed * Time.deltaTime;
            if (transform.position.z < -12 && shot<3) {
                transform.position = new(0,.5f,4);
                canMove = false;
                shot++;
            }
        } else
        if (Vector3.Distance(transform.position,GameObject.Find("player").transform.position) < 1f) {
            player.holdingBall = true;
           //print("e");
        }
        if (shot == 3) {
            
            scoring.game[0][round-1] = shot1;
            scoring.game[1][round-1] = shot2;
            shot1 = 0;
            shot2 = 0;
            waitForSecs(5);
                foreach(var pin in GameObject.FindGameObjectsWithTag("pin")) {
                    if (pin.transform.position.y > 0) {
                        Destroy(pin);
                    }
                }
                foreach(var pin in GameObject.FindGameObjectsWithTag("pin")) {
                    if (pin.transform.position.y<0)
                    Instantiate(pin,new(pin.transform.position.x,0.4f,pin.transform.position.z),pin.transform.rotation);
                }
                round++;
                shot = 1;
        }
    }
}
