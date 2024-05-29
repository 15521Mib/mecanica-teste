using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fat : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 2;
    
    Rigidbody2D fisica;
    // Start is called before the first frame update
    void Awake()
    {
        this.fisica = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
       {
            this.pula();
       }

    }
    void pula()
    {
        this.fisica.AddForce(Vector2.up * velocidade, ForceMode2D.Impulse);

    }

}
