using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        movimento();
        velocidadeAumentada();
        velocidadeDiminuida();
    }

    //Função responsável pelo movimento do objeto.
    void movimento()
    {
        float x = Input.GetAxis("Horizontal"); 
        float y = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.W) || y == 1)
        {
            transform.Translate(0, velocidade * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S) || y == -1)
        {
            transform.Translate(0, -velocidade * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D) || x == 1)
        {
            transform.Translate(velocidade * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A) || x == -1)
        {
            transform.Translate(-velocidade * Time.deltaTime, 0, 0);
        }
    }

    //Aumenta a velocidade do objeto 
    void velocidadeAumentada() 
    {
        float A = Input.GetAxis("Fire1");

        if(Input.GetKey(KeyCode.Q) || A == 1)
        {
            velocidade++;
        }
    }

    //Diminui a velocidade do objeto
    void velocidadeDiminuida() 
    {
        float B = Input.GetAxis("Fire2");

        if (Input.GetKey(KeyCode.R) || B == 1)
        {
            velocidade--;
        }
    }
}
