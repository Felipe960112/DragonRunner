using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo1 : MonoBehaviour {


        private float inputDirection;   //Crea un componente para almacenar la dirección
        private Vector3 moveVector;   //Crea los componenetes para vector en 3 dimensiones
        private CharacterController controller;   //Crea un controlador para manejar el personaje

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();   //Crea la conexión entre el controlador de este script y el del objeto

    }

    // Update is called once per frame
    void Update()
        {
            moveVector = new Vector3(0, -1, 0);   //Agrega gravedad constante al enemigo
            controller.Move(moveVector);
    }
    }