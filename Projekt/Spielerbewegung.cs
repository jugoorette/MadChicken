using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spielerbewegung : MonoBehaviour {


    //Horizontal velocity
    public float horizontal = 0;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        //Spieler bewegt sich nach vorne
        GetComponent<Rigidbody>().velocity = new Vector3(horizontal, 0, 3);

         //bewegt sich nach links
        if(Input.GetKeyDown(KeyCode.A)){
            horizontal = -2;
            //ruft stop() auf
            StartCoroutine(stop());
        }

        //bewegt sich nach links
        if (Input.GetKeyDown(KeyCode.D))
        {
            horizontal = 2;
            //ruft stop() auf
            StartCoroutine(stop());

        }

	}
    //stoppt nach 0,5s, damit es nicht an den Zaun fährt
    IEnumerator stop(){
        yield return new WaitForSeconds(0.5f);
        horizontal = 0;
    }
}
