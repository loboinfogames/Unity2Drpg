using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botoes : MonoBehaviour
{
    public void CarregarPrototype()
    {
        SceneManager.LoadScene("Prototype");
    }
    public void CarregarMenu()
    {//Chama no Onclick do botao de menu
        SceneManager.LoadScene("Menu");
    }

    public void CarregarGame()
    {//Chama no Onclick do botao de jogar

        SceneManager.LoadScene("Jogo");
    }
}
