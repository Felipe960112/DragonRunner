using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    public Text infoMonedasReunidas;
    private int monedasReunidas;
    // Use this for initialization
    private void Start()
    {
        monedasReunidas = PlayerPrefs.GetInt("Monedas reunidas: ");
        infoMonedasReunidas.text = "Monedas reunidas : " + monedasReunidas.ToString();
    }


    public void ToGame()
    {
        SceneManager.LoadScene("Nivel 1");
    }
    
    
    
    
	
	// Update is called once per frame
	void Update () {
		
	}
}
