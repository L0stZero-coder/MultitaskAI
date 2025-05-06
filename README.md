# MultitaskAI
MultitaskAI_Unity is an experimental Unity project that simulates an intelligent AI system capable of multitasking in a game environment. Inspired by VTuber AI models like Neuro-sama, this project combines real-time Twitch chat interaction, voice command recognition, and game control logic into a single system.

> Features
Voice-to-Text Commands — Uses Windows' speech recognition to interpret live microphone input.

Twitch Chat Integration — Connects to Twitch via TwitchLib.Client to receive and respond to live chat messages.

In-Game Actions — AI translates input into Unity game actions like jumping or moving the player.

Modular AI Processor — Handles all incoming inputs (chat/voice) and determines appropriate game responses.

-> Use Cases
Building AI-driven VTubers or streamer assistants

Research and prototyping for real-time input fusion

Creating interactive NPCs or avatars in games

-> Technologies Used
Unity 2021.3+

C# with .NET Framework (Mono backend)

TwitchLib.Client (for Twitch chat)

System.Speech.Recognition (Windows-only voice input)

-> What's Included
Modular C# scripts for each subsystem (Chat, Voice, AI Logic, Game Control)

Unity scene template

Example GameObject integration

-> Demo Actions
Say or type "jump" – makes the player jump

Say or type "move right" – moves the player to the right

Any other input gets a generic AI fallback response
