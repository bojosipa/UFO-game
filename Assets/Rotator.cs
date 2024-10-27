using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Rotator : MonoBehaviour {
    // Update is called every frame
    void Update () {
        // Rotira objekat za 45 stupnjeva oko Z ose svake sekunde
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }
}

