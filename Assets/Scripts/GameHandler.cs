using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameHandler : MonoBehaviour {

    public GameObject Fundo;
    public GameObject Cesta;
    public string json; //String that keeps the values to be sent to the server.

    void Start () {

        PlayerData playerData = new PlayerData(); // Generate data for the player.
        playerData.Partidas = Fundo.GetComponent<Temporizador>().pacont; // Points to the amount of sucesses in the Script "Temporizador".
        playerData.Acertos = Cesta.GetComponent<Verificador>().accont; // Points to the amount of sucesses in the Script "Verificador".
        playerData.Erros = Cesta.GetComponent<Verificador>().ercont; // Points to the amount of errors in the Script "Verificador".

        json = JsonUtility.ToJson(playerData); // Saves the data in a string called 'json'.

        File.WriteAllText(Application.dataPath + "saveFile.json", json); // Saves the string in a Json file.

        POST(); // Calls the function to send the json for the server.
        //GET(); // Calls the function to read the json from the server.
        Debug.Log(json); // Prints the value of the json at the Debug.Log in Unity.
    }

    public WWW POST()
    {
        WWW www;
        //WebRequest postHeader = new Hashtable();
        Dictionary <string, string> postHeader = new Dictionary<string, string>(); //Creates the header for sending the json to the server as a dictionary with 2 strings.
        postHeader.Add("Content-Type", "application/json"); // Adds the type of the content to the header.

        var formData = System.Text.Encoding.UTF8.GetBytes(json); // Serialyze the data from the json string.
        string url = "https://api.jsonbin.io/b"; // Informs the adress to be sent.

        www = new WWW(url, formData, postHeader); // Sends the data for the url, json data and header.
        StartCoroutine(WaitForRequest(www)); // Calls the routine for verifying the code send.
        return www; // Return the values that have been sent.

    }


    public WWW GET()
    {
        WWW www;
        
        var formData = System.Text.Encoding.UTF8.GetBytes(json);
        string url = "https://api.jsonbin.io/b"; 

        www = new WWW(url, formData);
        StartCoroutine(WaitForRequest(www));
        return www;

    }


    private class PlayerData
    {
        public int Partidas;
        public int Acertos;
        public int Erros;
        
    }

    IEnumerator WaitForRequest(WWW www)
    {
        yield return www; // Wait for the www to be sent.

        if (www.error == null) 
        {
            Debug.Log("WWW Ok!: " + www.text); 
        }
        else
        {
            Debug.Log("WWW Error: " + www.error);
        }
    }
    
}
