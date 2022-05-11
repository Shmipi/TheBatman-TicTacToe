using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSpace : MonoBehaviour {
    public Button button;

    [SerializeField] private Image riddlerLogo;
    [SerializeField] private Image batmanLogo;

    public Text text;

    private GameController gameController;

    private void Start()
    {
        riddlerLogo.enabled = false;
        batmanLogo.enabled = false;
    }

    public void SetGameControllerReference(GameController controller) {
        gameController = controller;
    }

    public void Update()
    {
        if (text.text == "")
        {
            riddlerLogo.enabled = false;
            batmanLogo.enabled = false;
        }
    }

    public void SetSpace() {

        text.text = gameController.GetPlayerSide();

        if (gameController.GetPlayerSide().Equals("X")) {
            batmanLogo.enabled = true;
            button.interactable = false;
            gameController.EndTurn();
        } else if (gameController.GetPlayerSide().Equals("O"))
        {
            riddlerLogo.enabled = true;
            button.interactable = false;
            gameController.EndTurn();
        }   
    }

    public void RestartGame()
    {
        riddlerLogo.enabled = false;
        batmanLogo.enabled = false;
    }
}
