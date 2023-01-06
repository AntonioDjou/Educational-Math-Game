using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontos : MonoBehaviour {

    public static int score; //Cria a pontuação (de acertos) do jogo como uma variável que não pode ser mudada. [É utilizada desta forma para ser lida no Script "Verificador"]
    Text text;

	void Awake () {
        text = GetComponent<Text>();
        score = 0;
	}
	
	void Update () {
        text.text = "Pontuação: " + score; //Imprime a quantidade de acertos a cada instante. [Note que a pontuação durante o jogo permanece invisível e só se torna visível, alfa = 255, quando começa a tela de GameOver]
	}
}
