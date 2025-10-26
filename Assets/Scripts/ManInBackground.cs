using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManInBackground : MonoBehaviour
{
    public GameObject MannInBackground;
    float Richtung = 1.0f;
    public float DrehiSpeed;
    float EndRichtung = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        float randomSpeed = Random.Range(8.0f,14.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(MannInBackground.transform.eulerAngles.z > 6){
            float randomSpeed = Random.Range(8.0f,14.0f);
            Richtung = -Richtung;
            EndRichtung = Richtung * randomSpeed;
            MannInBackground.transform.Rotate(0,0,Richtung*Time.deltaTime*DrehiSpeed);
        }
        else if(MannInBackground.transform.eulerAngles.z < -6){
            print("SSS");
            float randomSpeed = Random.Range(8.0f,14.0f);
            Richtung = -Richtung;
            EndRichtung = Richtung * randomSpeed;
            MannInBackground.transform.Rotate(0,0,Richtung*Time.deltaTime*DrehiSpeed);
        }
        else{
        MannInBackground.transform.Rotate(0,0,EndRichtung *Time.deltaTime);
        }
        
    }
}
