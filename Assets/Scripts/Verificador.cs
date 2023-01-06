using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Verificador : MonoBehaviour
{
    private int num1; // Primeiro número da soma.
    private int num2; // Segundo número da soma.
    private int soma; // Soma (Para ser comparada com o valor que foi escolhido pelo jogador como resposta).

    public int accont; // Contabiliza a quantidade de acertos;
    public int ercont; // Contabiliza a quantidade de erros;

    private string ackey = "Quantidade de Acertos = ";
    private string erkey = "Quantidade de Erros = ";

    private int valor; // Referencia a resposta escolhida no Script "Resposta".
    public GameObject Círculos; // Referencia onde está o Script "Resposta".

    public Text textoNum1; // Mostra na tela o número gerado para a 1ª parte da soma.
    public Text textoNum2; // Mostra na tela o número gerado para a 2ª parte da soma.

    void GerarNum() // Gera aleatoriamente os números da soma.
    {
        num1 = Random.Range(0, 9);
        num2 = Random.Range(0, 9);
        soma = num1 + num2;
    }


    void Start()
    {
        GerarNum();
        accont = PlayerPrefs.GetInt(ackey);
        ercont = PlayerPrefs.GetInt(erkey);

    }

    void Update()
    {
        valor = Círculos.GetComponent<Resposta>().resp; // Aponta para o valor de "resp" do Script "Resposta".
        textoNum1.text = (" " + num1); // Imprime a primeira parte da soma.
        textoNum2.text = ("    + " + num2 + " = "); // Imprime a segunda parte da soma.
        if (soma >= 10) // Compara a restrição da soma e refaz, caso não seja atendida.
        {
            GerarNum();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision) // Cria a colisão do prefab com a Cesta.
    {
        if (collision.gameObject.tag == "Player") // Verifica se o que está sendo colidido possui a tag "Player".
        {
            Destroy(collision.gameObject); // Destrói o objeto colidido. [No caso, o prefab]
            if (valor == soma) // Compara a resposta escolhida pelo jogador com a soma dos números.
            {
                Pontos.score += 1; // Incrementa a quantidade de acertos caso o jogador tenha escolhido o valor certo.
                accont++;
                PlayerPrefs.SetInt(ackey, accont);
                //Debug.Log(ackey + accont);
            }
            else
            {
                Erros.erros += 1; // Incrementa a quantidade de erros caso o jogador tenha escolhido o valor errado.
                ercont++;
                PlayerPrefs.SetInt(erkey, ercont);
                //Debug.Log(erkey + ercont);
            }
            GerarNum(); // Gera outro valor para a soma.
        }
    }
}