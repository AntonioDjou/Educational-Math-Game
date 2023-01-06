using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Temporizador : MonoBehaviour {

    public int tempoRest = 60; //Tempo de jogo.
    public float restartDelay = 8f; //Tempo para reiniciar o jogo.
    public Text textoContagem; //Mostra o tempo disponível para o jogador.

    Animator anim; //Define o Animator como anim.
    float restartTimer; //Variável do tipo Float para zerar o atraso para reiniciar o jogo.

    public int pacont; // Contabiliza a quantidade de partidas;
    private string pakey = "Quantidade de Partidas = ";


    private void Awake()
    {
        anim = GetComponent<Animator>(); // Referencia o Animator.
        pacont = PlayerPrefs.GetInt(pakey);
    }

    void Start()
    {
        StartCoroutine("LoseTime"); // Chama a rotina de contagem de tempo de jogo.
        pacont++; // Incrementa a quantidade de partidas jogadas.
        PlayerPrefs.SetInt(pakey, pacont); //Grava a quantidade de partidas jogadas.
        //Debug.Log(pakey + pacont); //Imprime no Debug a quantidade de partidas.

    }

    void Update()
    {
        textoContagem.text = ("" + tempoRest); //Imprime o valor do tempo disponível.

        if (tempoRest == 0) //Prepara a função de GameOver
        {
            StopCoroutine("LoseTime"); //Para a rotina de contagem do tempo.
            textoContagem.text = "0"; //Imprime que o tempo disponível chegou ao zero.

            anim.SetTrigger("GameOver"); //Inicia a animação de Fim de Jogo.
            restartTimer += Time.deltaTime; //Faz o somatório do tempo em segundos que demorou para completar o último frame na variável "restartTimer" 
            if (restartTimer >= restartDelay) //Compara se o tempo da tela de GameOver já encerrou
            {
                SceneManager.LoadScene("FundoAlternativo"); //Carrega a cena inicial do jogo.
            }
        }
    }

    IEnumerator LoseTime() //Inicia a rotina de contagem de tempo. A cada um segundo decrementa o tempo de jogo.
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            tempoRest--;
        }
    }   
}


