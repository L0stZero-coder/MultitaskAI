using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;
using System;

public class RealChatHandler
{
    public event Action<string> OnChatMessage;
    private TwitchClient client;

    public void Connect(string username, string token, string channel)
    {
        ConnectionCredentials credentials = new ConnectionCredentials(username, token);
        client = new TwitchClient();
        client.Initialize(credentials, channel);

        client.OnMessageReceived += OnMessageReceived;
        client.Connect();
    }

    private void OnMessageReceived(object sender, OnMessageReceivedArgs e)
    {
        OnChatMessage?.Invoke(e.ChatMessage.Message);
    }
}