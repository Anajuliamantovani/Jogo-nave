using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Meteoro : MonoBehaviour
{
    //RETORNO é função

    public float velocidade;
    Vector3 posiocione;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<SpriteRenderer>().color = Color.black;
        gameObject.name = "Meteoro";
        print(name);
        posiocione = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -2 * Time.deltaTime, 0);
        posicao();
    }

    void posicao() 
    {
        if (transform.position.y <= -5.54f) 
        {
            transform.position = posiocione; // ATRIBUI UM VALOR DO MESMO TIPO
        }
    }

}
