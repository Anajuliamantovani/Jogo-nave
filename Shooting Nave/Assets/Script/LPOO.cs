using NUnit.Framework.Constraints;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class LPOO : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*print(Soma(10, 10));
        print(Subtracao(15, 5));
        print(Divisao(10,2));
        print(Multiplicacao(5,2));
        print("média" + Media(10, 10, 10));
        ImprimirCrescente(1, 10);
        ImprimirDecrescente(10,2);
        tabuada(5);*/
        fatorial(20);
        ImparPar(true);
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

    int fatorial(int num1)
    {
        int resultado = 1;
        int num2 = 0;
        string imprimir;

        imprimir = (num1 + "!" + "=");
        for ( int i = 1; i < num1 ; i++)
        {
            resultado = resultado * (i + 1);
            imprimir = imprimir + (i + "x");
            num2 = i;
        }
        imprimir = imprimir + ((num2 + 1) + "=");
        print(imprimir + resultado);
        return 0;
    }

    //Uma função chamda ImparPar que recebe  parametro do tipo booleano se for true, ele imprime do 0 ate 10 
    //apenas os numeros imperes e se o parametro for false, imprimir apenas os pares.
    void ImparPar(bool num1)
    {
        if (num1 == false)
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    print(i);
                }
            }
        }
        else
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    print(i);
                }
            }
        }
    }
}
