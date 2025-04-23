using System;
using System.Speech.Synthesis;

namespace Content.Shared
{
    public class TextToSpeech
    {
        private readonly SpeechSynthesizer _synthesizer;

        public TextToSpeech()
        {
            _synthesizer = new SpeechSynthesizer();
            _synthesizer.Volume = 100; // Set volume (0-100)
            _synthesizer.Rate = 0;     // Set speed (-10 to 10)
        }

        public void Speak(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("No text provided for speech synthesis.");
                return;
            }

            _synthesizer.Speak(text);
        }

        public void Dispose()
        {
            _synthesizer.Dispose();
        }
    }
}