using UnityEngine;

public class PowerUp : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool navizinha(bool flip)
    {
        if (flip == true)
        {
            return false;
        }

        else
        {
            return true;
        }
    }

    //Aumenta a velocidade do objeto 
    void velocidadeAumentada()
    {
        float A = Input.GetAxis("Fire1");

        if (Input.GetKey(KeyCode.Q) || A == 1)
        {
            //velocidade++;
        }
    }

    //Diminui a velocidade do objeto
    void velocidadeDiminuida()
    {
        float B = Input.GetAxis("Fire2");

        if (Input.GetKey(KeyCode.R) || B == 1)
        {
            //velocidade--;
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
        GetComponent<SpriteRenderer>().color = Color.green;
        print(transform.localScale.y);
        print(transform.localScale.x);
        print(transform.localScale.z);
    }

    void exercicio()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            GetComponent<SpriteRenderer>().flipY = true;
        }
        if (Input.GetKeyUp(KeyCode.U))
        {
            GetComponent<SpriteRenderer>().flipY = false;
        }
    }

    void AumentarNave()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            transform.localScale = new Vector3(2f, 2f, 2f);
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            //transform.localScale = novaescala;
        }
    }
}
