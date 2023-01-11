using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlJuego : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textoTiempo;
    public float tiempoLimite;
    private float minutos;
    private float segundos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempoLimite -= Time.deltaTime;

        minutos = Mathf.Floor(tiempoLimite / 60);
        segundos = tiempoLimite % 60;

        textoTiempo.text = string.Format("{0:0}:{1:00}", minutos, segundos);

        if (tiempoLimite < 0)
            perdisteJuego();
    }
    public void perdisteJuego()
    {
    }
}
