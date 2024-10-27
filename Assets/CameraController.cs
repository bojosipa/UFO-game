using System.Collections;
using System.Collections.Generic;
using UnityEngine; // Uključujemo UnityEngine namespace koji sadrži sve potrebne klasu za rad u Unity-u.

public class CameraController : MonoBehaviour // Definiramo klasu CameraController koja nasleđuje MonoBehaviour.
{
    public GameObject player; // Referenca na GameObject koji predstavlja igrača.
    private Vector3 offset; // Varijabla za skladištenje razmaka između kamere i igrača.

    // Use this for initialization
    void Start () 
    {
        if (player == null)
    {
        Debug.LogError("Player is not assigned in CameraController.");
    }
    else
    {
        offset = transform.position - player.transform.position; 
    }
        // Računamo početni offset između pozicije kamere i pozicije igrača.
        offset = transform.position - player.transform.position; 
        // transform.position se odnosi na trenutnu poziciju kamere, dok player.transform.position predstavlja trenutnu poziciju igrača.
    }

    // Update is called once per frame
    void Update () 
    {
        // Postavljamo poziciju kamere na poziciju igrača plus offset.
        transform.position = player.transform.position + offset; 
        // Ova linija osigurava da kamera prati igrača u svakom frame-u.
        // Budući da čuvamo offset, pozicija kamere će ostati konstantna u odnosu na poziciju igrača.
    }
}

