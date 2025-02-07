using UnityEngine;

public class Projetil : MonoBehaviour
{
    public float Velocidade;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.localScale = new Vector3(0.2f,1f,0f);
        GetComponent<SpriteRenderer>().color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, Velocidade * Time.deltaTime, 0);
    }
}
