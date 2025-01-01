using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Aperte enter");
    }

    // Update is called once per frame
    void Update()
    {
        print("Oi");

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 5 * Time.deltaTime, 0);
        }

    }
}
