using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private float inputDirection;   //Crea un componente para almacenar el movimiento en x
    private float verticalVelocity;   //Crea un componente para almacenar el movimiento en y
    private Vector3 moveVector;   //Crea los componenetes para vector en 3 dimensiones
    private CharacterController controller;   //Crea un controlador para manejar el personaje
    private float gravity = 1.0f;
    private float speed = 5.0f;

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();   //Crea la conexión entre el controlador de este script y el del objeto
	}
	
	// Update is called once per frame
	void Update () {
        inputDirection = Input.GetAxis("Horizontal");   //Almacen la información obtenida al moverse horizontalmente en pantalla
                                                        //Debug.Log(inputDirection);   //Muestra en consola los valores obtenidos en inputDirection

        if (controller.isGrounded)
        {
            verticalVelocity = 0;   //Si el personaje está en el suelo, no hay velocidad vertical
        }
        else
        {
            verticalVelocity -= gravity;   //Si el personaje no está en el suelo, tiene velocidad vertical
        }

        moveVector = new Vector3(inputDirection * 80, verticalVelocity * 2, 0);   //Mueve el personaje de acuerdo a la información obtenida
        Debug.Log(moveVector);   //Muestra en consola la variación en los vectores x, y, z
        controller.Move(moveVector * Time.deltaTime);
	}
}
