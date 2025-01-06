using UnityEngine;

public class Projetil : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.localScale = new Vector3(0.2f,1f,0f);
        GetComponent<SpriteRenderer>().color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 2 * Time.deltaTime, 0);
    }
}
