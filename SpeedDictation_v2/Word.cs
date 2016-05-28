using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace SpeedDictation_v2
{
    /* 단어 클래스 */
    class Word
    {
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;

        /* 영문 프로퍼티 */
        internal string Eng { get; set; }
        /* 국문 프로퍼티(예) */
        //public string Kor { get; set; }
        /* 특수기호로 가려진 단어 프로퍼티 */
        internal string HiddenWord { get; set; }
        /* 단어 점수 */
        internal int Score { get; set; }
        /* 음성파일 경로 */
        internal string FileName { get; set; }

        /* 생성자 */
        public Word(string eng)
        {
            this.Eng = eng;

            /* 특수기호 처리 */
            for (int i = 0; i < eng.Length; i++)
            {
                if(i%2 == 0)
                    HiddenWord += eng[i];
                else
                    HiddenWord += "-";
            }

            /* 음성파일 경로 설정 */
            this.FileName = eng + ".mp3";

            this.Score = 10;
        }

        /* 음성을 실행하는 메소드 */
        public void SoundPlay()
        {
            waveOutDevice = new WaveOut();
            audioFileReader = new AudioFileReader(FileName);
            waveOutDevice.Init(audioFileReader);

            waveOutDevice.Play();
        }

        /* 음성을 멈추는 메소드 */
        public void SoundStop()
        {
            try
            {
                waveOutDevice.Stop();
                audioFileReader.Dispose();
                waveOutDevice.Dispose();
            }
            catch (Exception e) { }
        }
    }
}
