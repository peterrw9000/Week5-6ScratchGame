using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceDisplay : MonoBehaviour
{
    public Text[] info;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        info[0].text = "Lives: " + GameManager.instance.lives;
        info[1].text = "Score: " + GameManager.instance.score;
        info[2].text = "Ammo: " + GameManager.instance.ammo;
    }
}
