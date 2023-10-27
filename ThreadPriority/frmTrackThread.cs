using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ThreadPriority
{
    public partial class frmTrackThread : Form
    {
        Thread threadA, threadB, threadC, threadD;
        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            threadA = new Thread(MyThreadClass.Thread1);
            threadB = new Thread(MyThreadClass.Thread2);
            threadC = new Thread(MyThreadClass.Thread1);
            threadD = new Thread(MyThreadClass.Thread2);

            threadA.Name = "Thread A Process = ";
            threadB.Name = "Thread B Process = ";
            threadC.Name = "Thread C Process = ";
            threadD.Name = "Thread D Process = ";

            threadA.Priority = System.Threading.ThreadPriority.Highest;
            threadB.Priority = System.Threading.ThreadPriority.Normal;
            threadC.Priority = System.Threading.ThreadPriority.AboveNormal;
            threadD.Priority = System.Threading.ThreadPriority.BelowNormal;

            Console.WriteLine("- - Start of Thread - -");
            threadA.Start();threadB.Start();threadC.Start(); threadD.Start();
            threadA.Join();threadB.Join();threadC.Join();threadD.Join();
            Console.WriteLine("- -End of Thread - -");
        
        }
    }
}
