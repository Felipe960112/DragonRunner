using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonJugar : MonoBehaviour {

	
	//void OnTriggerEnter (Collider other) {
	//	if(other.tag == "BotonJugar")
 //       {
 //           SceneManager.LoadScene("Level1");
 //       }
	//}

    public void cambiarEscena ()
    {
        SceneManager.LoadScene("Level1");
    }
}
