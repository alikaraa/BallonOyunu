using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonKontrolcu : MonoBehaviour
{
    public GameObject patlama;
    OyunKontrolcu oyunKontrolScripti;

    void Start(){
        oyunKontrolScripti = GameObject.Find ("_Script").GetComponent<OyunKontrolcu> ();
    }

    void OnMouseDown(){
        GameObject go = Instantiate (patlama, transform.position,transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy (go, 0.117f);
        oyunKontrolScripti.BalonEkle ();
    }

}
