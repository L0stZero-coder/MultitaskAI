using UnityEngine;

public class GameController
{
    private GameObject player;

    public GameController(GameObject playerObj)
    {
        player = playerObj;
    }

    public void PerformAction(string action)
    {
        Rigidbody rb = player.GetComponent<Rigidbody>();
        switch (action)
        {
            case "jump":
                if (rb != null)
                    rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
                break;

            case "move_right":
                player.transform.Translate(Vector3.right * 1f);
                break;

            default:
                Debug.Log("Unknown action: " + action);
                break;
        }
    }
}