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
    private float jumpForce = 60.0f;
    private bool secondJumpAvail = false;
    //private Vector3 lastMotion;   //Bloquear el movimiento durante el salto

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();   //Crea la conexión entre el controlador de este script y el del objeto


    }
	
	// Update is called once per frame
	void Update () {
        //moveVector = Vector3.zero;   //Bloquear el movimiento durante el salto
        inputDirection = Input.GetAxis("Horizontal");   //Almacen la información obtenida al moverse horizontalmente en pantalla

       

        if (controller.isGrounded)
        {
            verticalVelocity = 0;   //Si el personaje está en el suelo, no hay velocidad vertical

            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpForce;   //Hacer que el personaje salte solo si esta en el piso
                secondJumpAvail = true;   //Permitir el segundo salto
            }

            //moveVector.x = inputDirection;   //Bloquear el movimiento durante el salto
        }
        else
        {
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (secondJumpAvail)
                {
                    verticalVelocity = jumpForce;   //Hacer que el personaje salte solo si esta en el aire
                    secondJumpAvail = false;   //Solo permitir dos saltos
                }

                //moveVector.x = lastMotion.x;   //Bloquear el movimiento durante el salto
            }

            verticalVelocity -= gravity + gravity/2;   //Si el personaje no está en el suelo, tiene velocidad vertical
        }

        //moveVector.y = verticalVelocity;   //Bloquear el movimiento durante el salto
        moveVector = new Vector3(inputDirection * 80, verticalVelocity * 2, 0);   //Mueve el personaje de acuerdo a la información obtenida
        //Debug.Log(moveVector);   //Muestra en consola la variación en los vectores x, y, z
        controller.Move(moveVector * Time.deltaTime);
        //lastMotion = moveVector;   //Bloquear el movimiento durante el salto
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (controller.collisionFlags == CollisionFlags.Sides)
        {
            //if (Input.GetKeyDown(KeyCode.Space))      //Saltar desde la pared
            //{
            //    moveVector = hit.normal * speed;
            //    moveVector.y = jumpForce;
            //}

            //Coleccionables
            switch (hit.gameObject.tag)
            {
                case "Coin":
                    Destroy(hit.gameObject);
                    LevelManager.Instance.CollectCoin();
                    break;

                case "Enemy1":
                    Destroy(hit.gameObject);
                    break;

                case "Muerte":
                    transform.position = hit.transform.GetChild(0).position;
                    break;

                case "Victoria":
                    LevelManager.Instance.Win();
                    break;

                default:
                    break;
            }

        }
    }


}
