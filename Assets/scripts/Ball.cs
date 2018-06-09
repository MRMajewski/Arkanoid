using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]//skrypt musi posiadać ten komponent inaczej nie ruszy
public class Ball : MonoBehaviour {

    [SerializeField]
    float InitialSpeed = 5f;

	// Use this for initialization
	void Start () {

        GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * InitialSpeed;
            //nadanie kulce prędkości w losowym kierunku o takiej samej dlugosci wektora
	}
	

}
