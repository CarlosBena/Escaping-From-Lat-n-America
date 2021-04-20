using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioVentana : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void EscenaJuego()
    {
        SceneManager.LoadScene("VentanaDeJuego");
    }
}
