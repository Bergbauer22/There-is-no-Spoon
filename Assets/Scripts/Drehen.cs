using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drehen : MonoBehaviour
{
    public float DrehSpeed= 1;
    public GameObject GedrehtesObject;
    // Start is called before the first frame update
   
    void Start()
    {
        int randomInterval = Random.Range(1,4);
        float randomSpeed = Random.Range(8.0f,14.0f);
        if(randomInterval <= 2){
            DrehSpeed = DrehSpeed * randomSpeed * -1;
            print("Flip");
        }
       else {
        DrehSpeed = DrehSpeed * randomSpeed;
        print("NoFlip");
       }
    }

    // Update is called once per frame
    void Update()
    {
        
        GedrehtesObject.transform.Rotate(0,0,DrehSpeed*Time.deltaTime);
    }
}
