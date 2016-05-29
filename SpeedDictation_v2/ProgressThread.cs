using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpeedDictation_v2
{
    class ProgressThread
    {
        Form1 mainForm;
        bool _progressStop;
        bool _forceSet;
        bool _checkStop;
        int progressValue;
        int stepTimer;
        int score;
        Word answer;
        string txtLabelScore;

        List<Word> words;


        HashSet<int> rands;
        Random rand;
        int num;


        public ProgressThread(Form1 mainForm)
        {
            this.mainForm = mainForm;
            this._progressStop = false;
            this._forceSet = false;
            this._checkStop = false;
            this.progressValue = 0;
            this.stepTimer = 1000;
            this.score = 100;
            this.txtLabelScore = "Score : ";

            this.words = new List<Word>();
            SetWord();


            rands = new HashSet<int>();
            rand = new Random((int)DateTime.Now.Ticks);


            new Thread(new ThreadStart(Progress)).Start();
            new Thread(new ThreadStart(WordCheck)).Start();
        }

        void SetWord()
        {
            words.Add(new Word("abroad"));
            words.Add(new Word("activate"));
            words.Add(new Word("apple"));
            words.Add(new Word("application"));
            words.Add(new Word("appropriative"));
            words.Add(new Word("background"));
            words.Add(new Word("block"));
            words.Add(new Word("cap"));
            words.Add(new Word("cloud"));
            words.Add(new Word("computer"));
            words.Add(new Word("controller"));
            words.Add(new Word("create"));
            words.Add(new Word("critical"));
            words.Add(new Word("domestic"));
            words.Add(new Word("download"));
            words.Add(new Word("event"));
            words.Add(new Word("global"));
            words.Add(new Word("handle"));
            words.Add(new Word("hat"));
            words.Add(new Word("hexadecimal"));
            words.Add(new Word("initial"));
            words.Add(new Word("instance"));
            words.Add(new Word("institute"));
            words.Add(new Word("kiwi"));
            words.Add(new Word("lab"));
            words.Add(new Word("local"));
            words.Add(new Word("march"));
            words.Add(new Word("may"));
            words.Add(new Word("network"));
            words.Add(new Word("notification"));
            words.Add(new Word("panic"));
            words.Add(new Word("phone"));
            words.Add(new Word("population"));
            words.Add(new Word("premium"));
            words.Add(new Word("pretend"));
            words.Add(new Word("private"));
            words.Add(new Word("property"));
            words.Add(new Word("request"));
            words.Add(new Word("restore"));
            words.Add(new Word("series"));
            words.Add(new Word("shred"));
            words.Add(new Word("shrimp"));
            words.Add(new Word("specific"));
            words.Add(new Word("speed"));
            words.Add(new Word("static"));
            words.Add(new Word("suspend"));
            words.Add(new Word("system"));
            words.Add(new Word("talk"));
            words.Add(new Word("thread"));
            words.Add(new Word("unique"));
            words.Add(new Word("unity"));
            words.Add(new Word("wallet"));
            words.Add(new Word("watch"));
            words.Add(new Word("water"));
            words.Add(new Word("word"));
        }

        void PrintWord()
        {
            while (true)
            {
                num = rand.Next(words.Count);
                /* 중복제거 */
                if (rands.Contains(num) == false)
                {
                    rands.Add(num);
                    try
                    {/* 컬렉션에서 단어 한개 골라 출력 */
                        mainForm.labelWord.Text = words[num].HiddenWord;
                        answer = words[num];
                    }
                    catch (Exception e) { }
                    /* 음성재생 */
                    words[num].SoundPlay();

                    mainForm.labelScore.Text = txtLabelScore + score.ToString();

                    /* 단어가 끝나면 스레드 종료 */
                    if (rands.Count == words.Count)
                        _forceSet = true;
                    break;
                }
            }
           
        }

        void Progress()
        {
            PrintWord();
            while (!_progressStop)
            {
                try
                {
                    mainForm.progressBar.Value = progressValue++;
                    mainForm.labelTimer.Text = ((1001 - progressValue)/10).ToString();
                    mainForm.labelWordTimer.Text = ((stepTimer -= 10)/100).ToString();
                    Thread.Sleep(100); /* 1초마다 진행 */

                    if (isTimeOver(_forceSet))
                    {
                        stepTimer = 1000;
                        _forceSet = false;
                        words[num].SoundStop();
                        PrintWord();
                    }
                    if (stepTimer < 300)
                    {
                        mainForm.labelWord.Text = answer.Eng;
                    }
                }
                catch (Exception e) { }

                /* ProgressBar가 MAX일때 스레드 종료 */
                if (progressValue > 1000 || mainForm._goBack) {
                    mainForm.progressBar.Value = 0;
                    mainForm.labelWord.Text = "END!";
                    mainForm.labelTimer.Text = "";
                    mainForm.labelWordTimer.Text = "";
                    RequestProgressStop();
                    RequestCheckStop();
                }
                
            }
        }

        void RequestProgressStop()
        {
            _progressStop = true;
           
        }

        bool isTimeOver(bool _forceSet)
        {
            return ((stepTimer < 0)||_forceSet);
        }

        void WordCheck()
        {
            while (!_checkStop)
            {
                /* 키보드 입력이 되기전까지 locking */
                if (mainForm._putEnter)
                {
                    
                    if (mainForm.txtInput.Text == answer.Eng)
                    {
                        score += answer.Score;
                    }
                    else
                    {
                        score -= answer.Score;
                    }
                    _forceSet = true; /* 정답일 경우 다음단어로 진행 */
                    mainForm.txtInput.Text = "";
                    /* 다시 키보드 입력까지 locking */
                    mainForm._putEnter = false;
                }
            }
        }

        void RequestCheckStop()
        {
            _checkStop = true;
        }
    }
}
