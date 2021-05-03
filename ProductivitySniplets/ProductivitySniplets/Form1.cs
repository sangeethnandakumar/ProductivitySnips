using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductivitySniplets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region YIELD

        //Example of yielding values from IEnumerator
        private void yieldDemo_Click(object sender, EventArgs e)
        {
            var allStudents = new List<int> { 8, 9, 10, 11, 12, 13 };
            foreach (var student in FilterStudents(allStudents))
            {
                MessageBox.Show(student.ToString());
            }
        }

        private static IEnumerable<int> FilterStudents(List<int> allStudents)
        {
            foreach (var student in allStudents)
            {
                if (student > 10)
                {
                    yield return student;
                }
            }
        }

        #endregion YIELD

        #region REF

        //Ref is a two way variable update. Means, val will be accessible inside the callie function argument
        private void refDemo_Click(object sender, EventArgs e)
        {
            var a = 10;
            ChangeRef(ref a);
            MessageBox.Show($"A is - {a}");
        }

        private static void ChangeRef(ref int b)
        {
            b = b + 10;
        }

        #endregion REF

        #region OUT

        //Out is a one way variable update. Means, val will be not be accessible inside the callie function argument but output reflects
        private void outDemo_Click(object sender, EventArgs e)
        {
            var a = 10;
            ChangeOut(out a);
            MessageBox.Show($"A is - {a}");
        }

        private static void ChangeOut(out int b)
        {
            b = 30;
            b = b + 10;
        }

        #endregion OUT

        #region IS

        //Is is used to match types
        private void isDemo_Click(object sender, EventArgs e)
        {
            object random = "sangee";
            if (random is string)
            {
                MessageBox.Show($"The var is a string");
            }
        }

        #endregion IS

        #region AS

        //As is used to type cast. If 'as' fails then the result will be null
        private void asDemo_Click(object sender, EventArgs e)
        {
            object random = "sangee";
            string randomString = random as string;
            MessageBox.Show($"Object converted to string");
        }

        #endregion AS

        #region AS

        //Delegate is usefull to call callbacks
        private void delegateDemo_Click(object sender, EventArgs e)
        {
            var longTask = new LongTask();
            longTask.RunLongTask(MyCallback);
        }

        public static void MyCallback(int i)
        {
            MessageBox.Show(i.ToString());
        }

        #endregion AS

        #region LAMBDA EXPRESSIONS

        //
        private void lambdaDemo_Click(object sender, EventArgs e)
        {
        }

        #endregion LAMBDA EXPRESSIONS

        #region EVENTS AND DELEGATES

        //Delegates to raise events for subscribers
        private void eventsAndDelegatesDemo_Click(object sender, EventArgs e)
        {
            var videoEncorder = new VideoEncorder();
            videoEncorder.OnEncodingStarted += OnVideoEncodingStarted;
            videoEncorder.OnEncodingFinished += OnVideoEncodingFinished_SubscriberA;
            videoEncorder.OnEncodingFinished += OnVideoEncodingFinished_SubscriberB;
            videoEncorder.Encode(@"C:\text.mp4");
        }

        private void OnVideoEncodingStarted(object sender, VideoEventArgs args)
        {
            MessageBox.Show("Video Encoding Started");
        }

        private void OnVideoEncodingFinished_SubscriberA(object sender, VideoEventArgs args)
        {
            MessageBox.Show("Video Encoding Finished");
        }

        private void OnVideoEncodingFinished_SubscriberB(object sender, VideoEventArgs args)
        {
            MessageBox.Show("The encoded video is at : " + args.EncodedVideoLocation);
        }

        #endregion EVENTS AND DELEGATES

        #region ASYNC AND AWAIT

        private async void asyncAwaitDemo_Click(object sender, EventArgs e)
        {
            //Call normal fucntion synchronously
            SynchronousFunction();

            //Another methord
            await Task.Run(new Action(SynchronousFunction));

            //Make Tasks
            //Boil eggs async
            var eggTask = FryEggsAsync();
            //Toast bread async
            var toastTask = ToastBreadAsync();

            //Wait for all tasks to finish
            var breakfastTasks = new List<Task> { eggTask, toastTask };
            while (breakfastTasks.Count > 0)
            {
                var finishedTask = await Task.WhenAny(breakfastTasks);
                if (finishedTask == eggTask)
                {
                    MessageBox.Show($"{eggTask.Result} Eggs are ready");
                }
                else if (finishedTask == toastTask)
                {
                    MessageBox.Show("Toats are ready");
                }
                breakfastTasks.Remove(finishedTask);
            }

            //Done
            MessageBox.Show("Breakfast done");
        }

        private void SynchronousFunction()
        {
            MessageBox.Show("Synchronous function called");
        }

        private async Task<int> FryEggsAsync()
        {
            MessageBox.Show("Frying eggs...");
            await Task.Delay(5000);
            return 3;
        }

        private async Task<string> ToastBreadAsync()
        {
            MessageBox.Show("Toasting bread...");
            await Task.Delay(5000);
            return "Bread toasted";
        }

        #endregion ASYNC AND AWAIT

        #region TASK PARALLEL LIBRARY

        private void tplDemo_Click(object sender, EventArgs e)
        {
            //Create a cancellation token
            var tokenSource = new CancellationTokenSource();
            //Pass token and start execution
            var task1 = Task.Factory.StartNew(() => ParallelTask(tokenSource.Token));
            //Cancel when requested
            tokenSource.Cancel();

            MessageBox.Show("Other tasks are still running...");
        }

        private void ParallelTask(CancellationToken token)
        {
            try
            {
                if (token.IsCancellationRequested)
                {
                    MessageBox.Show("Cancelling this task");
                    token.ThrowIfCancellationRequested();
                }
                Thread.Sleep(2000);
                MessageBox.Show("This task might runned on a different core");
            }
            catch (Exception ex)
            {
            }
        }

        #endregion TASK PARALLEL LIBRARY

        #region TASK PARALLEL LIBRARY

        private void multicoreLoopDemo_Click(object sender, EventArgs e)
        {
            //Multicore for loop but *blocking
            Parallel.For(0, 100000, i =>
            {
            });

            //Multicore foreach loop but *blocking
            Parallel.ForEach(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, item =>
            {
            });

            MessageBox.Show("Multi Core Loops Completed");
        }

        #endregion TASK PARALLEL LIBRARY

        private void singlecoreLoopDemo_Click(object sender, EventArgs e)
        {
            //Traditional
            for (var i = 0; i < 10000; i++)
            {
                Console.WriteLine(i);
            }
            MessageBox.Show("Single Core Loops Completed");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}