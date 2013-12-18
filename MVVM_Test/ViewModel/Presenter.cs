using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Threading.Tasks;
//using MVVM_Test.Model;

namespace MVVM_Test.ViewModel
{

    
    public class Presenter : ObservableObject
    {
        //private readonly TextConverter _textConverter = new TextConverter(s => s.ToUpper());
        private string _Input;
        private string _Output;
        
        private int _Fuzzy;
        private int _Buzzy;
        private int _FuzzBuzzy;
        private string _Duration;
        
        //private readonly ObservableCollection<string> _history = new ObservableCollection<string>();

        private AsyncObservableCollection<string> items;
        public AsyncObservableCollection<string> Items
        {
            get
            {
                if (items == null)
                {
                    items = new AsyncObservableCollection<string>();
                }
                return items;
            }
        }

        public string Input
        {
            get { return _Input; }
            set
            {
                _Input = value;
                RaisePropertyChangedEvent("Input");
            }
        }
        public string Output
        {
            get { return _Output; }
            set
            {
                _Output = value;
                RaisePropertyChangedEvent("Output");
            }
        }
        public int Fuzzy
        {
            get { return _Fuzzy; }
            set
            {
                _Fuzzy = value;
                RaisePropertyChangedEvent("Fuzzy");
            }
        }
        public int Buzzy
        {
            get { return _Buzzy; }
            set
            {
                _Buzzy = value;
                RaisePropertyChangedEvent("Buzzy");
            }
        }
        public int FuzzBuzzy
        {
            get { return _FuzzBuzzy; }
            set
            {
                _FuzzBuzzy = value;
                RaisePropertyChangedEvent("FuzzBuzzy");
            }
        }
        public string Duration
        {
            get { return _Duration; }
            set
            {
                _Duration = value;
                RaisePropertyChangedEvent("Duration");
            }
        }
        
        public IEnumerable<string> History
        {
            get { return Items; }
        }

        public ICommand TestCommand
        {
            get { return new DelegateCommand(MainTest); }
        }

        private void MainTest()
        {
            if (string.IsNullOrEmpty(Input))
                Input="0";
            Int32 input= Convert.ToInt32( Input);
            Int32 FirstInput=input/2;

            Task t1 = new Task
            (
                () =>
                {
                    Test(1, FirstInput);
                    Console.WriteLine("Ended the task");
                }
            );
            Task t2 = new Task
            (
                () =>
                {
                    Test(FirstInput+1,input);
                    Console.WriteLine("Ended the task");
                }
            );
            t1.Start();
            t2.Start();
        }

        private void Test(Int32 FromInt, Int32 ToInt)
        {
            DateTime dtStart = DateTime.Now;
            Output = string.Empty;

            for (Int32 i = FromInt; i < ToInt; i++)
            {
                if (i % 3 == 0)
                { 
                    Fuzzy++;
                    if (!(Output.IndexOf("Fuzzy")>=0))
                        Output += "Fuzzy";
                }
                if (i % 5== 0)
                {
                    Buzzy++;
                    if (!(Output.IndexOf("Buzzy") >= 0))
                        Output += "Buzzy";
                }
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    FuzzBuzzy++;
                    if (!(Output.IndexOf("FuzzBuzzy") >= 0))
                        Output += "FuzzBuzzy";
                }

                if (i % 100000 == 0) 
                {
                    AddToHistory(i.ToString());
                }
            }
            DateTime dtEnd = DateTime.Now;
            Duration = dtEnd.Subtract(dtStart).TotalMilliseconds.ToString();
            Input = String.Empty;
        }

        private void AddToHistory(string item)
        {
            if (!Items.Contains(item))
                Items.Add(item);
        }
    }
}
