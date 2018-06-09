using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))] //skrypt nie wykona się jeśli nie ma tego komponentu
public class Paddle : MonoBehaviour {

    Rigidbody2D Rigidbody;

    [SerializeField] //zmienna jest prywatna w ramach innych obiektów ale jest widoczna w inspektorze.
    float Speed = 5f;

    [SerializeField]
    float MaxPosition = 5f;

    // Use this for initialization
    void Start () {

        Rigidbody = GetComponent<Rigidbody2D>(); // pobieramy komponent Rigidbody
	}
	
	// Update is called once per frame
	void FixedUpdate () { //FixedUpdate ponieważ zachodzą tu zmiany związane z fizyką i musi być to liczone na bieżąco (?)

        var targetSpeed = Vector3.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
            targetSpeed = Vector3.left * Speed;

        else if (Input.GetKey(KeyCode.RightArrow))
            targetSpeed = Vector3.right * Speed;

        Rigidbody.velocity = targetSpeed;

        //ograniczenie ruchu paletki żeby nie wyjeżdżała poza planszę

        var positionX = Mathf.Clamp(transform.position.x, -MaxPosition, MaxPosition);
        //funkcja Clamp zwraca daną wartość z  określonego przedziału
        //jeżeli ta wartość x zawiera się w przedziale to jest zwracana, w innym przypadku zwracana jest skrajna wartość
        transform.position = new Vector3(positionX, transform.position.y);



    }
}
