using UnityEngine;
using System.Threading.Tasks;

public class MultitaskManager : MonoBehaviour
{
    private RealChatHandler chat;
    private RealVoiceListener voice;
    private GameController game;
    private AIProcessor ai;

    async void Start()
    {
        chat = new RealChatHandler();
        voice = new RealVoiceListener();
        game = new GameController(GameObject.Find("Player"));
        ai = new AIProcessor(null, null, game); // temporary, update below

        chat.OnChatMessage += ai.HandleInput;
        voice.OnVoiceHeard += ai.HandleInput;

        chat.Connect("YourBotUsername", "oauth:YourTokenHere", "ChannelName");

        await voice.ListenAsync();
    }
}