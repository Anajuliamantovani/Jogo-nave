using UnityEngine;

public class Meteoro : MonoBehaviour
{
    public float velocidade;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<SpriteRenderer>().color = Color.black;
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
            transform.position = new Vector3(-0.19f, 4.38f, 0);
        }
    }

}
