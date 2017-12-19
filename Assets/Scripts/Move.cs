using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float speed = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Los cambios que haya hecho el usuario en el eje horizontal, se los aplico
        //al de este objeto.
        transform.Translate(Input.GetAxis("Horizontal") * speed ,0 ,0);
    }
}
