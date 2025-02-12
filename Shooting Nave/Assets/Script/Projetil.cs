using UnityEngine;

public class Projetil : MonoBehaviour
{
    public float Velocidade;
    public int TipoTiros;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.localScale = new Vector3(0.2f,1f,0f);
        GetComponent<SpriteRenderer>().color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        //translate é o comando que da movimento
        Tiros();
        SumicoTiro();
    }

    void SumicoTiro ()
    {
        if (transform.position.y >= 7)
        {
            Destroy(this.gameObject);
        }
    }

    void Tiros()
    {
        switch (TipoTiros)
        {
            case 0:
                transform.Translate(0, Velocidade * Time.deltaTime, 0);
            break;
     
            case 1:
                transform.Translate(Velocidade * Time.deltaTime, Velocidade * Time.deltaTime,0);
            break;

            case 2:
                transform.Translate(-Velocidade * Time.deltaTime, Velocidade * Time.deltaTime, 0);
            break;
        }
    }
}
