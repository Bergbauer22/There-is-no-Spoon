using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSmartGlasses : MonoBehaviour
{
    public GameObject SmartGlassesPlayer;
    public GameObject SmartGlassesItem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Spieler"){
        SmartGlassesPlayer.SetActive(true);   
        SmartGlassesItem.SetActive(false);
        }
    }
}
