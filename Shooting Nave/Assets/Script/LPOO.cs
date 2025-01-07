using UnityEngine;

public class LPOO : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(Soma(10, 10));
        print(Subtracao(15, 5));
        print(Divisao(10,2));
        print(Multiplicacao(5,2));
        print("média" + Media(10, 10, 10));
        ImprimirCrescente(1, 10);
        ImprimirDecrescente(10,2);
        tabuada(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float Soma(float num1, float num2) 
    {
        return num1 + num2;
    }
    float Subtracao(float num1, float num2) 
    {
        return num1 - num2;
    }
    float Divisao(float num1, float num2)
    {
        return num1 / num2;
    }
    float Multiplicacao(float num1, float num2)
    {
        return num1 * num2;
    }
    float Media(float num1, float num2, float num3) 
    {
        float media;
        media = (num1 + num2 + num3) / 3;

        return media;
    }
    int ImprimirCrescente(int num1, int num2)
    {
        
        for (int i = num1; i <= num2; i++) 
        {
            print(i);
        }
        return 0;
    }

    int ImprimirDecrescente(int num1, int num2)
    {
        for(int i = num1; i >= num2; i--)
        {
            print("decrescente" + i);
        }
        return 0;
    }

    int tabuada(int num1)
    {
        int resultado;
        for(int i = 1; i <= 10; i++ )
        {
            resultado = i * num1;
            print(num1 + "X" + i + "=" + resultado);
        }
        return 0;
    }

}
