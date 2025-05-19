# 🤖 MultitaskAI_Unity

**MultitaskAI_Unity** is an experimental Unity-based project designed to simulate an intelligent, multitasking AI system in a live game environment. Inspired by VTuber AI models like *Neuro-sama*, this project integrates **real-time Twitch chat interaction**, **voice command recognition**, and **in-game control logic** into a cohesive framework suitable for interactive entertainment or AI research.

---

## 🚀 Features

- 🗣️ **Voice-to-Text Commands**  
  Converts live microphone input into actionable commands using Windows' built-in `System.Speech.Recognition`.

- 💬 **Twitch Chat Integration**  
  Connects via `TwitchLib.Client` to interpret and respond to live messages from Twitch viewers.

- 🎮 **In-Game Action Control**  
  Maps chat and voice inputs to Unity-based player actions (e.g., jump, move).

- 🧠 **Modular AI Processor**  
  Central AI controller processes voice/chat inputs and triggers appropriate behaviors in the game.

---

## 🧠 Use Cases

- Developing **AI-powered VTuber assistants** or avatars  
- Prototyping **real-time multimodal AI systems**  
- Creating **interactive NPCs or companion bots** in Unity-based games  
- Academic **research in input fusion and cognitive simulation**

---

## 🛠️ Technologies Used

- **Unity 2021.3+**  
- **C# with .NET Framework (Mono backend)**  
- **TwitchLib.Client** — Twitch chat connectivity  
- **System.Speech.Recognition** — Windows-only speech-to-text functionality  

---

## 📦 What's Included

- Fully modular C# scripts for:
  - Twitch chat handler
  - Voice command recognition
  - Central AI decision logic
  - Game control execution

- Example Unity scene with pre-configured setup  
- GameObjects integrated with input response behavior  

---

## 🕹️ Demo Commands

You can interact with the AI using either **Twitch chat** or **voice**:

| Input              | Effect                    |
|-------------------|---------------------------|
| `"jump"`          | Makes the player character jump |
| `"move right"`    | Moves the character to the right |
| _Other inputs_    | Triggers a generic AI fallback response |

---

## 📄 License

This project is open for experimentation and educational use. A formal license may be added later.

---

## 🤝 Contributions

Contributions are welcome! Feel free to fork the repository and submit pull requests for new features or improvements.
