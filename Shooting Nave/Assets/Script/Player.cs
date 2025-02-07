using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject Tiro;
    public float velocidade;
    Vector3 novaescala;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.name = "Player";
        //gameObject.SetActive(true); // habilita e desabilita o objeto.
        novaescala = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        movimento();
        tiro();
    }

    //Função responsável pelo movimento do objeto.
    void movimento()
    {
        Vector3 teleporte = new Vector3 (-0.03f, -0.1f, 0.105f );

        if (Input.GetKey(KeyCode.W) && transform.position.y <= 3.9)
        {
            transform.Translate(0, velocidade * Time.deltaTime, 0); 
        }
        if (Input.GetKey(KeyCode.S) && transform.position.y >= -4.21)
        {
            transform.Translate(0, -velocidade * Time.deltaTime, 0);           
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x <= 7.56)
        {
            transform.Translate(velocidade * Time.deltaTime, 0, 0);           
        }
        if (Input.GetKey(KeyCode.A) && transform.position.x >= -7.84)
        {
            transform.Translate(-velocidade * Time.deltaTime, 0, 0);           
        }
    }

   void tiro()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            print("FOGO");
            Instantiate(Tiro, transform.position, transform.rotation);
        }
    }
}


