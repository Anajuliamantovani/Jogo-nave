using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.name = "Player";
    }

    // Update is called once per frame
    void Update()
    {
        //exemplo();
        escala();
        exercicio();
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
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (Input.GetKey(KeyCode.S) || y == -1)
        {
            transform.Translate(0, -velocidade * Time.deltaTime, 0);
            GetComponent<SpriteRenderer>().color = Color.cyan;
        }
        if (Input.GetKey(KeyCode.D) || x == 1)
        {
            transform.Translate(velocidade * Time.deltaTime, 0, 0);
            GetComponent<SpriteRenderer>().color = Color.white;
        }
        if (Input.GetKey(KeyCode.A) || x == -1)
        {
            transform.Translate(-velocidade * Time.deltaTime, 0, 0);
            GetComponent<SpriteRenderer>().color = Color.black;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("FOGO");
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

    void exemplo()
    {
        //chegar ate uma propriedade
        print(gameObject.transform.position.x); //<-exceção  
        print(GetComponent<Transform>().position.x);//<-sempre
        print(this.GetComponent<Transform>().position.x);//<-mais antiga

        //quando solta a tecla P
        if (Input.GetKeyUp(KeyCode.P))
        {
            GetComponent<SpriteRenderer>().flipY = true;
        }

        //quando mantem precionado a tecla P
        if (Input.GetKey(KeyCode.P))
        {
            GetComponent<SpriteRenderer>().flipY = true;
        }

        //quando precionou a tecla P
        if (Input.GetKeyDown(KeyCode.P))
        {
            GetComponent<SpriteRenderer>().flipY = true;
        }
    }

    void escala() 
    {
        GetComponent <SpriteRenderer>().color = Color.green;
        print(transform.localScale.y);
        print(transform.localScale.x);
        print(transform.localScale.z);
    }

    void exercicio() 
    {
        if (Input.GetKeyDown(KeyCode.U)) 
        {
            GetComponent<SpriteRenderer> ().flipY = true;
        }
        if (Input.GetKeyUp(KeyCode.U)) 
        {
            GetComponent<SpriteRenderer>().flipY = false;
        }
    }
}
