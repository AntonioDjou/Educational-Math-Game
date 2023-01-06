using UnityEngine;

public class Resposta : MonoBehaviour
{
    public Transform spawnPos0; // Referencia a posição que será criado o prefab para o valor de número 0.
    public Transform spawnPos1;
    public Transform spawnPos2;
    public Transform spawnPos3;
    public Transform spawnPos4;
    public Transform spawnPos5;
    public Transform spawnPos6;
    public Transform spawnPos7;
    public Transform spawnPos8;
    public Transform spawnPos9;
    public GameObject prefab;
    public int resp = 10; // Variável com o valor da resposta para ser comparada na hora da pontuação. [Criada com um número que não pode ser contabilizado como resposta certa]


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0)){ // Compara se o botão 0 foi apertado no teclado (alfanumérico ou numérico).
            resp = 0; // Abribui zero à resposta.
            Instantiate(prefab, spawnPos0.position, spawnPos0.rotation); // Cria uma instância do prefab na posicão referente ao número 0 no jogo.
        }

        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1)){
            resp = 1;
            Instantiate(prefab, spawnPos1.position, spawnPos1.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2)){
            resp = 2;
            Instantiate(prefab, spawnPos2.position, spawnPos2.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3)){
            resp = 3;
            Instantiate(prefab, spawnPos3.position, spawnPos3.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4)){
            resp = 4;
            Instantiate(prefab, spawnPos4.position, spawnPos4.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5)){
            resp = 5;
            Instantiate(prefab, spawnPos5.position, spawnPos5.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6)){
            resp = 6;
            Instantiate(prefab, spawnPos6.position, spawnPos6.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7)){
            resp = 7;
            Instantiate(prefab, spawnPos7.position, spawnPos7.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8)){
            resp = 8;
            Instantiate(prefab, spawnPos8.position, spawnPos8.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9)){
            resp = 9;
            Instantiate(prefab, spawnPos9.position, spawnPos9.rotation);
        }
    } 
}
