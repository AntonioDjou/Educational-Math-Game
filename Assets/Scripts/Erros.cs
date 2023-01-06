using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Erros : MonoBehaviour {

    public static int erros; //Cria a pontuação (de equívocos) do jogo como uma variável que não pode ser mudada. [É utilizada desta forma para ser lida no Script "Verificador"]
    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        erros = 0;
    }

    void Update()
    {
        text.text = "Erros: " + erros; //Imprime a quantidade de erros a cada instante. [Note que a pontuação durante o jogo permanece invisível e só se torna visível, alfa = 255, quando começa a tela de GameOver]
    }
}
