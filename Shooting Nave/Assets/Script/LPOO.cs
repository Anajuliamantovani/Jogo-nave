using NUnit.Framework.Internal;
using System;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class LPOO : MonoBehaviour
{
    //5 EXERCICIOS
    //TODOS A SAIDA DO PROGRAMA � PELO PRINT
    //TODOS OS EXERCICIOS TEM QUE ESTAR DENTRO DESSE SCRIPTY
    //TESTAR OS METODOS NA CLASSE LPOO 
    //UTILIZAR O ARQUIIVO LEMBRETE.TXT PARA REVIS�O
    //UTILIZAR RACIOCIONIO LOGIO PARA SABER QUANDO USAR AS FERRAMENTAS NO ARQUIVO TXT
    //REOLVER OS EXERCICIOS USANDO SUA LOGIA DE PROGRAMA��O


    // 1- FA�A UMA CLASSE CHAMADA CALCULADORA COM OS METODOS SOMA SUBTRA��O DIVIS�O E MULTPLICA��O

    // 2- FA�A UM METODO NA CLASSE CALCULLADORA QUE SAIDA � TODAS AS TABUADAS

    // 3- FA�A UMA CLASSE CHAMADA PESSOA COM OS SEGUINTES ATRIBUTOS, NOME, IDADE, PESO, ALTURA, GENERO

    // 4- FA�A UM METODO NA CLASSE PESSOA PARA CALCULAR O IMC DE PESSOA 

    // 5- FA�A UM METODO PARA SABER IDADE ATUAL DA PESSOA

    // DESAFIO - FA�A UMA FU��O NA CLASSE CALCULADORA PARA CALCULAR O FATORIAL DE UM NUMERO

    private void Start()
    {
        print(Calculadora.soma(5,5));
        print(Calculadora.subtracao(4,2));
        print(Calculadora.multiplicacao(5,5));
        print(Calculadora.divisao(25,5));
        //Calculadora.tabuadona();
        print(Pessoa.calculoImc(71, 1.75));
        print(Pessoa.idadePessoa(21));
        print(Calculadora.fatorial(5));
    }
    
    
}

public class Calculadora
{ 
    public static int soma(int num1, int num2) 
    {
        return num1 + num2;
    }
    public static double subtracao(double num1, double num2) 
    {
        return num1 - num2;
    }
    public static double divisao(double num1, double num2) 
    {  
        return num1 / num2; 
    }
    public static double multiplicacao(double num1, double num2) 
    {
        return num1 * num2;
    }

    public static void tabuadona() 
    {
        int resultado;
        for (int i = 1; i <= 10; i++) 
        {
            for(int j = 0; j <= 10; j++) 
            {
               resultado = i * j;
               Debug.Log( i + "X" + j + "=" + resultado); //descobri q o print s� existe no monobehavior, ent to usando debug.log pra printar
            }
            
        }

    }
    public static int fatorial(int n)
    {
        int resultado = 1;
        
        for (int i = 1; i <= n; i++)
        {
            resultado = resultado * i;
        }
        return resultado;
    }
}
//5! = 1 x 2 x 3 x 4 x 5 = 120


public class Pessoa
{
    String nome;
    char genero;
    int idade;
    double peso;
    float altura;

    public static double calculoImc(double peso, double altura) 
    {
        return peso / altura;
    }

    public static int idadePessoa(int idade) 
    {
        return idade;
    }
}

