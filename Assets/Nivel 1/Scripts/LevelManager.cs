using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    private int hitpoint = 3;
    private int score = 0;

    public Transform spawnPosition;

    public Transform playerTrasnform;

    private void Update()
    {
        if (playerTrasnform.position.y < -80)
        {
            playerTrasnform.position = spawnPosition.position;
            hitpoint--;

            if (hitpoint <= 0)
            {
                Debug.Log("Perdiste!");
            }
        }
    }

}
