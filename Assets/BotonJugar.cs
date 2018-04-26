using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botonJugar : MonoBehaviour {



    public void cambiarEscena ()
    {
        SceneManager.LoadScene("Level1");
    }
}
