using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonOlusturucu : MonoBehaviour
{
    public GameObject balon;
    float balonOlusturmaSuresi = 1f;
    float zamanSayaci = 0f;
    OyunKontrolcu okScripti;
    // Start is called before the first frame update
    void Start()
    {
        okScripti = this.gameObject.GetComponent<OyunKontrolcu> ();
    }

    // Update is called once per frame
    void Update()
    {
        zamanSayaci -= Time.deltaTime;
        int katsayi = (int)(okScripti.zamanSayaci / 10) -6;
        katsayi *= -1;
        if (zamanSayaci < 0 && okScripti.zamanSayaci > 0){
            GameObject go = Instantiate (balon, new Vector3 (Random.Range(-2.50f,2.50f), -6f, 0), Quaternion.Euler (0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce (new Vector3 (0,Random.Range(100f*katsayi, 200f*katsayi), 0));
            zamanSayaci = balonOlusturmaSuresi;
        }
        
    }
}
