using System;
using System.Threading.Tasks;
using UnityEngine;

public class AIProcessor
{
    private ChatHandler chat;
    private VoiceListener voice;
    private GameController game;

    public AIProcessor(ChatHandler chat, VoiceListener voice, GameController game)
    {
        this.chat = chat;
        this.voice = voice;
        this.game = game;

        chat?.OnChatMessage += HandleInput;
        voice?.OnVoiceHeard += HandleInput;
    }

    public async Task ProcessLoopAsync()
    {
        while (true)
        {
            await Task.Delay(500);
        }
    }

    public void HandleInput(string input)
    {
        Debug.Log($"AI Received: {input}");

        if (input.ToLower().Contains("jump"))
            game.PerformAction("jump");
        else if (input.ToLower().Contains("right"))
            game.PerformAction("move_right");
        else
            Debug.Log("AI: I’m not sure what that means.");
    }
}