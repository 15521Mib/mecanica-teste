using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculo : MonoBehaviour
{
    //Onde gerar? Posi��o do gerador
    // Quando gerar? tempo
    [SerializeField]
    private GameObject modeloObstaculo;

    [SerializeField]
    private float tempoParaGerar;
    private float cronometro;
    // Start is called before the first frame update
    private void Awake()
    {
        this.cronometro = this.tempoParaGerar;  
    }

    // Update is called once per frame
    void Update()
    {
        this.cronometro -= Time.deltaTime;
        if(this.cronometro < 0)
        {
            GameObject.Instantiate(this.modeloObstaculo,this.transform.position,Quaternion.identity);
            this.cronometro = this.tempoParaGerar;
        }
    }
}
