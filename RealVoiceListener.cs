using System.Speech.Recognition;
using System;
using System.Threading.Tasks;

public class RealVoiceListener
{
    public event Action<string> OnVoiceHeard;
    private SpeechRecognitionEngine recognizer;

    public async Task ListenAsync()
    {
        await Task.Run(() =>
        {
            recognizer = new SpeechRecognitionEngine();
            recognizer.LoadGrammar(new DictationGrammar());
            recognizer.SetInputToDefaultAudioDevice();
            recognizer.SpeechRecognized += (s, e) =>
            {
                foreach (var result in e.Result.Alternates)
                    OnVoiceHeard?.Invoke(result.Text);
            };
            recognizer.RecognizeAsync(RecognizeMode.Multiple);
        });
    }
}