using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelManager : MonoBehaviour {

    public static LevelManager Instance { set; get; }

    private int vidas = 3;
    private int monedas = 0;

    public Transform spawnPosition;
    public Transform playerTrasnform;

    public Text MonedasNivel;
    public Text VidasNivel;
    
    private void Awake()   //private void Start, funciona antes del Start
    {
        Instance = this;
        MonedasNivel.text = "Monedas adquiridas : " + monedas.ToString();
        VidasNivel.text = "Vidas restantes : " + vidas.ToString();
    }

    private void Update()
    {
        if (playerTrasnform.position.y < -80)
        {
            playerTrasnform.position = spawnPosition.position;
            vidas--;

            if (vidas <= 0)
            {
                SceneManager.LoadScene("Menu");
            }
        }

        
        VidasNivel.text = "Vidas restantes : " + vidas.ToString();
    }

    public void Win()
    {
        if (monedas > PlayerPrefs.GetInt("Monedas reunidas: "))
        {
            PlayerPrefs.SetInt("Monedas reunidas: ", monedas);
        }
        
        SceneManager.LoadScene("Menu");
    }

    public void CollectCoin()
    {
        monedas++;
        Debug.Log("Obtuviste una moneda!");
        MonedasNivel.text = "Monedas adquiridas : " + monedas.ToString();
    }

}
