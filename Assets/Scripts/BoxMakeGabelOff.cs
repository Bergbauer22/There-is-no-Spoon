using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMakeGabelOff : MonoBehaviour
{
    public GameObject Box1;
    public GameObject Box2;
    public GameObject Box3;

    public ParticleSystem Box1Partikel;
    public ParticleSystem Box2Partikel;
    public ParticleSystem Box3Partikel;
    public ParticleSystem MeinePartikel;
    
    public GameObject ItemGabel;
    

    public GameObject IchSelber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        print("? In mir");
        if(other.tag == "GabelKiste")
        
        {
            print("Box In mir");
            Box1Partikel.Play();
            Box2Partikel.Play();
            Box3Partikel.Play();
            MeinePartikel.Play();
            
            ItemGabel.GetComponent<SpriteRenderer>().enabled = false;
            Box1.GetComponent<SpriteRenderer>().enabled = false;
            Box2.GetComponent<SpriteRenderer>().enabled = false;
            Box3.GetComponent<SpriteRenderer>().enabled = false;
            IchSelber.GetComponent<SpriteRenderer>().enabled = false;
            StartCoroutine(Deaktivieren());
            
        }
    }
    IEnumerator Deaktivieren() {
            yield return new WaitForSeconds(2);
            ItemGabel.SetActive(false);
            Box1.SetActive(false);
            Box2.SetActive(false);
            Box3.SetActive(false);
            IchSelber.SetActive(false);
        }
}
