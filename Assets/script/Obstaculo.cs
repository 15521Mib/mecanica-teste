using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.8f;
    [SerializeField]
    private float variacaoY;
    
    private Vector3 posicaoPombo;

    private bool Pontuar;

    private UIscript ScriptDaUI;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoY, variacaoY));
    }
    private void Start()
    {
        this.posicaoPombo = GameObject.FindAnyObjectByType<fat>().transform.position;
        this.ScriptDaUI = GameObject.FindAnyObjectByType<UIscript>();
    }
    // Update is called once per frame
    void Update()
    {
        if(!this.Pontuar && this.transform.position.x < posicaoPombo.x){
            Debug.Log("Pontuou");
            this.Pontuar = true;
            this.ScriptDaUI.adicinarPontos();
        }
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }
    // private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    this.Destruir();
    //}

    //void Destruir()
    //{
    //   GameObject.Destroy(this.gameObject);
    //}
}
