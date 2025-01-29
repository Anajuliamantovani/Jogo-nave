using NUnit.Framework.Constraints;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using System;
using static Unity.Burst.Intrinsics.X86;

public class LPOO : MonoBehaviour
{
    public int idade, idadeMinima;
    public float n1, n2, n3;
    public float peso, altura;
    public string msgTrue, msgFalse;
    [SerializeField] static public string contagem = "";
    [SerializeField] public string contagemFrontEnd = "";
    public int teste;
    public string Nome01;
    public string Nome02;
    public string Nome03;
    public string [] Nomes = new string [5];
    public bool macaco;
    public Color cor;
    public Example Pessoa;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Nomes = new string[4];
        /*print(Soma(10, 10));
        print(Subtracao(15, 5));
        print(Divisao(10,2));
        print(Multiplicacao(5,2));
        print("média" + Media(10, 10, 10));
        ImprimirCrescente(1, 10);
        ImprimirDecrescente(10,2);
        tabuada(5);*/
        //fatorial(20);
        //ImparPar(true);
        //contador(10);
        //danoninho(2);
        //yakult();
        contagem = contagemFrontEnd;
        exercicios.Contador(teste);

        if (exercicios.validarIdade(idade, idadeMinima) == true)
        {
            print(msgTrue);
        }
        else
        {
            print(msgFalse);
        }

        exercicios.notas(n1, n2, n3);
        exercicios.IMC(peso, altura);
        exercicios.RaizQuadrada(81);

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

    void contador(int num1)
    {
        int resultado = 0;

        for (int i = 0; i < num1; i++)
        {
            print(resultado + "+" + (i + 1) + "=" + (resultado + (i + 1)));
            resultado = resultado + (i + 1);        
        }

        print("Resultado final" + "=" + resultado);
    }

    void danoninho(int num1)
    {
        int resultado = 0;

        for(int i = 10; i > 0; i--)
        {
            resultado = num1 * i;
            print(i + "x" + num1 + "=" + resultado);
        }
    }

    void yakult()
    {
        int resultado = 0;

        for (int i = 1; i <= 10; i++)
        {
            for(int j = 0; j <= 10; j++)
            {
                resultado = i * j;
                print(i + "x" + j + "=" + resultado);
            }
        }
    }
}

public class exercicios : MonoBehaviour
{

    static public bool validarIdade(int idade, int idadeCerta)
    {
        if (idade >= idadeCerta)
        {
            return true;
        }
        
        else
        {
            return false;
        }
        
    }

    static public float notas(float n1, float n2, float n3)
    {
        float media;
        media = (n1 + n2 + n3) / 3;

        if (media >= 6)
        {
            print("Você mandou bem, aproveite as férias");
        }
        else
        {
            print("Estude mais no próximo ano, não foi dessa vez :(");
        }
        return 0;
    }

    static public float IMC(float peso, float altura)
    {
        float IMC;
        IMC = (altura * altura) / peso;
        print("Seu IMC é :" + IMC);
        return 0;
    }

    static public void RaizQuadrada(int raiz)
    {
       for (int i = 0; i < raiz; i++)
        {
            if (raiz == (i * i))
            {
                print("A raiz quadrada de" + raiz + "=" + i);
            }
            else
            {
                print("Coloque uma raiz normal seu maluco !!!! #@!");
            }
        }
    }

    static public void Contador(int numero)
    {
        for(int i = 0;i < numero; i++)
        {
            LPOO.contagem = LPOO.contagem + "" + i; //transformando um int em string ( STRING = "" + OUTROS TIPOS )
            
        }
        print(LPOO.contagem);
    }
}

