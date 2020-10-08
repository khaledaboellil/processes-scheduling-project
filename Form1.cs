using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        public void swap(ref float i, ref float j)
        {
            float aux = i;
            i = j;
            j = aux;
        }
        public float averagewaitingpreemptive(ref float [] processes,ref float[] brust,ref float[] arrival, float[] waitingtime, float[] arr4, float[] arr5, float [] arr6, float avwaiting, int c, int nofprocesses)
        {
            int v;
            int cc = 0;
            float[] arive;float []bru;
            arive = new float[c];
            bru = new float[c];
            for (int d = 0; d < c; d++)
            {
                for (int j = 0; j < nofprocesses; j++)
                {
                    if (processes[d] == arr5[j])
                    {
                        arive[d] = arr4[j];
                        bru[d] = arr6[j];
                    }
                }
            }
            float sum = arive[0];
            sum += brust[0];
            for (int i = 0; i < c; i++)
            {

                v = 0;
                
                if(i!=0)
                {
                    if(sum<arive[i])
                    {
                        sum += arive[i] - sum;
                    }
                    sum += brust[i];
                }
                
                for (int j = i + 1; j < c; j++)
                {

                    if (processes[i] == processes[j])
                    {
                        v = 1;
                    }

                }
                if (v == 0)
                {
                    waitingtime[cc] = sum - bru[i] - arive[i];
                    avwaiting += waitingtime[cc];
                    cc++;
                }
            }
            avwaiting = avwaiting / nofprocesses;

            return avwaiting;
        }
        public void sortprocssesbyarivaltime(ref float[] processes, ref float[] arrival, ref float[] brust, int nofprocesses, int flag)
        {

            for (int i = 0; i < nofprocesses; i++) // sort by arrival time 
            {

                for (int j = 0; j < nofprocesses - 1; j++)
                {
                    if (arrival[j] > arrival[j + 1])
                    {
                        swap(ref arrival[j], ref arrival[j + 1]);
                        swap(ref processes[j], ref processes[j + 1]);
                        swap(ref brust[j], ref brust[j + 1]);
                    }
                    if (flag == 1) if (arrival[j] == arrival[j + 1])
                        {
                            if (brust[j] > brust[j + 1])
                            {
                                swap(ref arrival[j], ref arrival[j + 1]);
                                swap(ref processes[j], ref processes[j + 1]);
                                swap(ref brust[j], ref brust[j + 1]);
                            }
                        }
                }
            }
        }
      public  void sortprocssesbypriority(ref float[] processes,ref float[] priority, ref float[] arrival,ref float[] brust, int nofprocesses, int flag)
        {

            for (int i = 0; i < nofprocesses; i++) // sort by arrival time 
            {

                for (int j = 0; j < nofprocesses - 1; j++)
                {
                    if (arrival[j] > arrival[j + 1])
                    {
                        swap(ref arrival[j], ref arrival[j + 1]);
                        swap(ref processes[j], ref processes[j + 1]);
                        swap(ref brust[j],ref brust[j + 1]);
                        swap(ref priority[j],ref priority[j + 1]);
                    }
                    if (flag == 1) if (arrival[j] == arrival[j + 1])
                        {
                            if (priority[j] > priority[j + 1])
                            {
                                swap(ref arrival[j], ref arrival[j + 1]);
                                swap(ref processes[j], ref processes[j + 1]);
                                swap(ref brust[j], ref brust[j + 1]);
                                swap(ref priority[j], ref priority[j + 1]);
                            }
                        }
                }
            }
        }
      public  void gantchartt(float[] processes, float[] arrival, float[] brust, int num)
        {
            float sum =arrival[0];
          
            gantchart.AppendText (Environment.NewLine);
            for (int i = 0; i < num; i++)
            {
                if (i == 0)
                {
                    gantchart.AppendText("p" + (processes[i].ToString()) + "(" + sum.ToString() + ")");
                    for (int j = 0; j < brust[i]; j++)
                    {
                        gantchart.AppendText("=");
                    }
                }
                else
                {
                    sum += brust[i - 1];
                    if (sum < arrival[i])
                    {
                        gantchart.AppendText("(" + sum.ToString() + ")");
                        for (int j = 0; j < arrival[i]-sum; j++)
                        {
                            gantchart.AppendText("=");
                        }
                        sum += arrival[i] - sum; 
                    }
                    gantchart.AppendText("p" + (processes[i].ToString()) +"("+sum.ToString()+")");
                    for (int j = 0; j < brust[i]; j++)
                    {
                        gantchart.AppendText("=");
                    }
                    if (i == num - 1)
                        gantchart.AppendText("("+(sum + brust[i]).ToString() + ")");
                }

            }
           
            gantchart.AppendText (Environment.NewLine);
       
        }
        public float averagewaiting(ref float[] brust, ref float[] arrival, ref float[] start, float[] waitingtime, float avwaiting, int nofprocesses)
        {

            for (int i = 0; i < nofprocesses; i++)
            {
                if (i != 0)
                {
                    start[i] = brust[i - 1] + start[i - 1];
                    waitingtime[i] = start[i] - arrival[i];
                    avwaiting += waitingtime[i];
                }
                start[0] = 0;
                waitingtime[0] = 0;
            }
            return avwaiting;
        }
        public int nofprocesses;
        public float[] processes;
        public float[] arrival;
        public float[] brust;
        public float[] waitingtime;
        public float[] priority;
        public float[] arr0; public float[] arr1; public float[] arr2;float[] arr3;
        float[] arr4; float[] arr5; float[] arr6; float[] readyqueue;
        public int flag;
        public int flag1;
        public float brusttotal = 0;
        public float brustexit = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            nofprocesses = Convert.ToInt32(processesnumber.Text);
            arrival = new float[nofprocesses];
            brust = new float[nofprocesses];
            processes = new float[nofprocesses];
            priority = new float[nofprocesses];
            waitingtime= new float[nofprocesses];
            arr0 = new float[200];
            arr1 = new float[200];
            arr2 = new float[200];
            arr3 = new float[200];
            arr4 = new float[200];
            arr5 = new float[200];
            arr6 = new float[200];
            readyqueue = new float[200];
            brusttotal = 0;
            brustexit = 0;
            for (int i = 0; i < nofprocesses; i++)
            {
                processes[i] = Convert.ToSingle(Interaction.InputBox("enter the processes id ", "inputbox", "", 75, 75));
                textBox1.Text = textBox1.Text + processes[i];
                textBox1.AppendText(Environment.NewLine);
                arr5[i] = processes[i];
                arrival[i] = Convert.ToSingle(Interaction.InputBox("enter the arrival time ", "inputbox", "", 75, 75));
                textBox1.Text = textBox1.Text + arrival[i];
                textBox1.AppendText(Environment.NewLine);
                arr4[i] = arrival[i];
                brust[i] = Convert.ToSingle(Interaction.InputBox("enter the brust time ", "inputbox", "", 75, 75));
                textBox1.Text = textBox1.Text + brust[i];
                textBox1.AppendText(Environment.NewLine);
                brusttotal += brust[i];
                arr6[i] = brust[i];
                if(prioritycheck.Checked)
                {
                    priority[i] = Convert.ToSingle(Interaction.InputBox("enter the priority time ", "inputbox", "", 75, 75));
                    textBox1.Text = textBox1.Text + priority[i];
                    textBox1.AppendText(Environment.NewLine);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            //////////////////fcfs//////////
            if (Fcfscheck.Checked == true)
            {
                float avwaiting = 0;
                flag = 0;
                sortprocssesbyarivaltime(ref processes, ref arrival, ref brust, nofprocesses, flag);
                avwaiting = averagewaitingpreemptive(ref processes,ref brust,ref arrival, waitingtime, arr4, arr5, arr6, avwaiting, nofprocesses, nofprocesses);
                waitinglable.Text = (avwaiting).ToString();
               gantchartt(processes,arrival, brust, nofprocesses);
            }
            ////////////////////////sjfpreemptive/////////////////
            if (preemptivecheck.Checked && sjfcheck.Checked)
            {
               
                nofprocesses = Convert.ToInt32(processesnumber.Text);
                sortprocssesbyarivaltime(ref processes, ref arrival, ref brust, nofprocesses, flag);
                waitingtime = new float[nofprocesses];
                float avwaiting = 0;
                flag1 = 1;
                bool wh1 = true;
                int i = 0;
                int c = 0;
                int num = nofprocesses;
                while (brustexit != brusttotal)
                {
                    wh1 = true;
                    if (i == 0)
                    {
                        sortprocssesbyarivaltime(ref processes, ref arrival, ref brust, num, flag1);
                    }
                    int j = i + 1;
                    if (j == num)
                    {
                        arr0[c] = processes[i];
                        arr1[c] = arrival[i];
                        arr2[c] = brust[i];
                        brustexit += arr2[c];
                        c++;
                        processes[i] = 0;
                        arrival[i] = 0;
                        brust[i] = 0;
                        i = 0;
                        num -= 1;
                    }
                    else if ((brust[i] + arrival[i]) >= arrival[j])
                    {
                        if ((brust[i] - (arrival[j] - arrival[i])) > brust[j])
                        {
                            arr0[c] = processes[i];
                            arr1[c] = arrival[i];
                            arr2[c] = arrival[j] - arrival[i];
                            brustexit += arr2[c];
                            brust[i] = brust[i] - (arrival[j] - arrival[i]);
                            for (int f = 0; f < j; f++)
                            {
                                arrival[f] = arrival[j];
                            }
                            i = j;
                            c++;
                        }
                        else
                        {
                            while (wh1 && (j != num - 1))
                            {
                                j++;
                                if ((brust[i] + arrival[i]) >= arrival[j])
                                {
                                    if ((brust[i] - (arrival[j] - arrival[i])) > brust[j])
                                    {

                                        arr0[c] = processes[i];
                                        arr1[c] = arrival[i];
                                        arr2[c] = arrival[j] - arrival[i];
                                        brustexit += arr2[c];
                                        brust[i] = brust[i] - (arrival[j] - arrival[i]);
                                        for (int f = 0; f < j; f++)
                                        {
                                            arrival[f] = arrival[j];
                                        }
                                        i = j;
                                        c++;
                                        wh1 = false;
                                    }
                                }
                            }
                            if (wh1 == true)
                            {
                                arr0[c] = processes[i];
                                arr1[c] = arrival[i];
                                arr2[c] = brust[i];
                                for (int b = 0; b < num; b++)
                                {
                                    if (b != i)
                                        if (arrival[b] <= (arrival[i] + brust[i]))
                                        {
                                            arrival[b] = arrival[i] + brust[i];
                                        }
                                }
                                processes[i] = 0;
                                arrival[i] = 0;
                                brust[i] = 0;
                                for (int b = 0; b < num - 1; b++)
                                {
                                    if (processes[b] == 0)
                                    {
                                        swap(ref processes[b], ref processes[b + 1]);
                                        swap(ref arrival[b], ref arrival[b + 1]);
                                        swap(ref brust[b], ref brust[b + 1]);

                                    }

                                }
                                num -= 1;
                                brustexit += arr2[c];
                                i = 0;
                                c++;
                            }
                        }

                    }
                    else
                    {
                        if (arrival[i] <= brustexit)
                        {
                            arr0[c] = processes[i];
                            arr1[c] = arrival[i];
                            arr2[c] = brust[i];
                            for (int b = 0; b < num; b++)
                            {
                                if (b != i)
                                    if (arrival[b] <= (arrival[i] + brust[i]))
                                    {
                                        arrival[b] = arrival[i] + brust[i];
                                    }
                            }
                            processes[i] = 0;
                            arrival[i] = 0;
                            brust[i] = 0;
                            for (int b = 0; b < nofprocesses - 1; b++)
                            {
                                if (processes[b] == 0)
                                {
                                    swap(ref processes[b], ref processes[b + 1]);
                                    swap(ref arrival[b], ref arrival[b + 1]);
                                    swap(ref brust[b], ref brust[b + 1]);

                                }

                            }
                            num -= 1;
                            brustexit += arr2[c];
                            i = 0;
                            c++;
                        }
                    }
                    if (num == 1)
                    {
                        arr0[c] = processes[i];
                        arr1[c] = arrival[i];
                        arr2[c] = brust[i];
                        brustexit += arr2[c];
                        c++;
                    }
                }

                avwaiting = averagewaitingpreemptive(ref arr0,ref arr2,ref arr1, waitingtime, arr4, arr5, arr6, avwaiting, c, nofprocesses);
                waitinglable.Text = (avwaiting).ToString();
                gantchartt(arr0,arr1, arr2, c);
            }


            ///////////////////////////sjfnonpreemptive//////////
            if (nonpreemcheck.Checked && sjfcheck.Checked)
            {
                nofprocesses = Convert.ToInt32(processesnumber.Text);
                waitingtime = new float[nofprocesses];
                float avwaiting = 0;
                flag = 1;
                sortprocssesbyarivaltime(ref processes, ref arrival, ref brust, nofprocesses, flag);
                float st = brust[0];
                for (int i = 0; i < nofprocesses; i++)
                {
                    int t = 0;
                    if (i != 0)
                        st += brust[i];
                    for (int j = i + 1; j < nofprocesses; j++)
                        if (arrival[j] <= st)
                        {
                            arr0[t] = processes[j];
                            arr1[t] = arrival[j];
                            arr2[t] = brust[j];
                            t++;
                        }
                    Array.Sort(arr2,0,t);
                    int j1 = i + 1;
                    int i1 = 0;
                    int b = 0;
                    while (b != t)
                    {
                        if (brust[j1] == arr2[i1])
                        {

                            swap(ref arrival[j1], ref arrival[i1 + j1]);
                            swap(ref processes[j1], ref processes[i1 + j1]);
                            swap(ref brust[j1], ref brust[i1 + j1]);
                            b++;
                            i1 = 0;
                        }
                        else
                        {
                            i1++;
                        }

                    }
                }
                avwaiting = averagewaitingpreemptive(ref processes, ref brust, ref arrival, waitingtime, arr4, arr5, arr6, avwaiting, nofprocesses, nofprocesses);
                waitinglable.Text = (avwaiting).ToString();
                gantchartt(processes,arrival, brust, nofprocesses);
            }


            ///////////////////////////prioritypreemptive//////////
            if (preemptivecheck.Checked && prioritycheck.Checked)
            {
                nofprocesses = Convert.ToInt32(processesnumber.Text);
                waitingtime = new float[nofprocesses];
                float avwaiting = 0;
                flag1 = 1;

                bool wh1 = true;
                int num = nofprocesses;
                int i = 0;
                int c = 0;

                while (brustexit != brusttotal)
                {
                    wh1 = true;
                    if (i == 0)
                    {
                        sortprocssesbypriority(ref processes, ref priority, ref arrival, ref brust, num, flag1);
                    }
                    int j = i + 1;
                    if (j == num)
                    {
                        arr0[c] = processes[i];
                        arr1[c] = arrival[i];
                        arr2[c] = brust[i];
                        arr3[c] = priority[i];
                        brustexit += arr2[c];
                        c++;
                        processes[i] = 0;
                        arrival[i] = 0;
                        brust[i] = 0;
                        priority[i] = 0;
                        i = 0;
                        num -= 1;
                    }
                    else if ((brust[i] + arrival[i]) >= arrival[j])
                    {
                        if (priority[i] > priority[j])
                        {
                            arr0[c] = processes[i];
                            arr1[c] = arrival[i];
                            arr2[c] = arrival[j] - arrival[i];
                            arr3[c] = priority[i];
                            brustexit += arr2[c];
                            brust[i] = brust[i] - (arrival[j] - arrival[i]);
                            i = j;
                            c++;
                            for (int f = 0; f < j; f++)
                            {
                                arrival[f] = arrival[j];
                            }
                        }
                        else
                        {
                            while (wh1 && (j != num - 1))
                            {
                                j++;
                                if ((brust[i] + arrival[i]) >= arrival[j])
                                {
                                    if (priority[i] > priority[j])
                                    {
                                        arr0[c] = processes[i];
                                        arr1[c] = arrival[i];
                                        arr2[c] = arrival[j] - arrival[i];
                                        arr3[c] = priority[i];
                                        brustexit += arr2[c];
                                        brust[i] = brust[i] - (arrival[j] - arrival[i]);
                                        i = j;
                                        c++;
                                        for (int f = 0; f < j; f++)
                                        {
                                            arrival[f] = arrival[j];
                                        }
                                        wh1 = false;
                                    }
                                }
                            }
                            if (wh1 == true)
                            {
                                arr0[c] = processes[i];
                                arr1[c] = arrival[i];
                                arr2[c] = brust[i];
                                arr3[c] = priority[i];
                                for (int b = 0; b < num; b++)
                                {
                                    if (b != i)
                                        if (arrival[b] <= (arrival[i] + brust[i]))
                                        {
                                            arrival[b] = arrival[i] + brust[i];
                                        }
                                }
                                processes[i] = 0;
                                arrival[i] = 0;
                                brust[i] = 0;
                                priority[i] = 0;
                                for (int b = 0; b < num - 1; b++)
                                {
                                    if (processes[b] == 0)
                                    {
                                        swap(ref processes[b], ref processes[b + 1]);
                                        swap(ref arrival[b], ref arrival[b + 1]);
                                        swap(ref brust[b], ref brust[b + 1]);
                                        swap(ref priority[b], ref priority[b + 1]);

                                    }

                                }
                                num -= 1;
                                brustexit += arr2[c];
                                i = 0;
                                c++;
                            }
                        }
                    }
                    else
                    {
                        if (arrival[i] <= brustexit)
                        {
                            arr0[c] = processes[i];
                            arr1[c] = arrival[i];
                            arr2[c] = brust[i];
                            arr3[c] = priority[i];
                            for (int b = 0; b < num; b++)
                            {
                                if (b != i)
                                    if (arrival[b] <= (arrival[i] + brust[i]))
                                    {
                                        arrival[b] = arrival[i] + brust[i];
                                    }
                            }
                            processes[i] = 0;
                            arrival[i] = 0;
                            brust[i] = 0;
                            priority[i] = 0;
                            for (int b = 0; b < num - 1; b++)
                            {
                                if (processes[b] == 0)
                                {
                                    swap(ref processes[b], ref processes[b + 1]);
                                    swap(ref arrival[b], ref arrival[b + 1]);
                                    swap(ref brust[b], ref brust[b + 1]);
                                    swap(ref priority[b], ref priority[b + 1]);
                                }

                            }
                            num -= 1;
                            brustexit += arr2[c];
                            i = 0;
                            c++;
                        }
                    }
                    if (num == 1)
                    {
                        arr0[c] = processes[i];
                        arr1[c] = arrival[i];
                        arr2[c] = brust[i];
                        arr3[c] = priority[i];
                        brustexit += arr2[c];
                        c++;
                    }
                }
                int index = c;
                avwaiting = averagewaitingpreemptive(ref arr0,ref arr2,ref arr1, waitingtime, arr4, arr5, arr6, avwaiting, c, nofprocesses);
                waitinglable.Text = (avwaiting).ToString();
                gantchartt(arr0, arr1,arr2, c);
            }
            ///////////////////////////prioritynonpreemptive//////////
            if (nonpreemcheck.Checked && prioritycheck.Checked)
            {
                flag1 = 1;
                nofprocesses = Convert.ToInt32(processesnumber.Text);
                waitingtime = new float[nofprocesses];
                float avwaiting = 0;
                sortprocssesbypriority(ref processes,ref priority,ref arrival,ref brust, nofprocesses, flag1);
                float st = brust[0];
                for (int i = 0; i < nofprocesses; i++)
                {
                    int t = 0;
                    if (i != 0)
                        st += brust[i];
                    for (int j = i + 1; j < nofprocesses; j++)
                        if (arrival[j] <= st)
                        {
                            arr0[t] = processes[j];
                            arr1[t] = arrival[j];
                            arr2[t] = brust[j];
                            arr3[t] = priority[j];
                            t++;
                        }
                    Array.Sort(arr3,0,t);
                    int j1 = i + 1;
                    int i1 = 0;
                    int b = 0;
                    while (b != t)
                    {
                        if (priority[j1] == arr3[i1])
                        {

                            swap(ref priority[j1],ref priority[i1 + j1]);
                            swap(ref arrival[j1], ref arrival[i1 + j1]);
                            swap(ref processes[j1], ref processes[i1 + j1]);
                            swap(ref brust[j1], ref brust[i1 + j1]);
                            b++;
                            i1 = 0;
                        }
                        else
                        {
                            i1++;
                        }

                    }


                }
                avwaiting = averagewaitingpreemptive(ref processes, ref brust, ref arrival, waitingtime, arr4, arr5, arr6, avwaiting, nofprocesses, nofprocesses);
                waitinglable.Text = (avwaiting).ToString();
                gantchartt(processes,arrival, brust, nofprocesses);
            }
            ///////////////////////////RoundRobin//////////
            if (RRcheck.Checked == true)
            {
                int timeslice = Convert.ToInt32(timetextbox.Text);
                nofprocesses = Convert.ToInt32(processesnumber.Text);
                waitingtime = new float[nofprocesses];
                float avwaiting = 0;
                flag = 0;
                int index = 0;
                sortprocssesbyarivaltime(ref processes, ref arrival, ref brust, nofprocesses, flag);
                int t = 1;
            
                int i = 0;
                int ii = 0;
                int j = 0;
                float m = arrival[0];
                int n = 0;
                int k = 1;
                int h = 0;
                readyqueue[n] = processes[0];
                n++;
                while (t != 0)
                {
                    t = 0;
                    for (int d = 0; d < nofprocesses; d++)
                    {
                        if (processes[d] == readyqueue[i])
                            ii = d;
                    }
                    if (brust[ii] <= timeslice && brust[ii] > 0)
                    {
                        arr0[j] = processes[ii];
                        arr1[j] = arrival[ii];
                        arr2[j] = brust[ii];
                        m += brust[ii];
                        brust[ii] = 0;
                        j++;
                        index++;
                    }
                    else if (brust[ii] > timeslice)
                    {
                        arr0[j] = processes[ii];
                        arr1[j] = arrival[ii];
                        arr2[j] = timeslice;
                        brust[ii] = brust[ii] - timeslice;
                        m += timeslice;
                        j++;
                        index++;
                    }
                    h = k;
                    if (k == nofprocesses)
                    {
                        if (brust[ii] > 0)
                        {
                            readyqueue[n] = processes[ii];
                            n++;
                        }
                    }
                    for (int b = h; b < nofprocesses; b++)
                    {
                        if (arrival[b] <= m)
                        {
                            readyqueue[n] = processes[b];
                            n++;
                            k++;
                        }
                        if (b == nofprocesses - 1)
                        {
                            if (brust[ii] > 0)
                            {
                                readyqueue[n] = processes[ii];
                                n++;
                            }
                        }
                    }

                    for (int l = 0; l < nofprocesses; l++)
                    {
                        if (brust[l] > 0)
                        {
                            t = 1;
                        }
                    }

                    i++;
                }
                avwaiting = averagewaitingpreemptive(ref arr0, ref arr2, ref arr1, waitingtime, arr4, arr5, arr6, avwaiting, index, nofprocesses);
                waitinglable.Text = (avwaiting).ToString();
                gantchartt(arr0, arr1,arr2, index);
            }
            
        }
        private void sjfcheck_CheckedChanged(object sender, EventArgs e)
        {
            preemptivecheck.Enabled = sjfcheck.Checked;
            nonpreemcheck.Enabled = sjfcheck.Checked;
          
               
        }
        private void prioritycheck_CheckedChanged(object sender, EventArgs e)
        {
            preemptivecheck.Enabled = prioritycheck.Checked;
            nonpreemcheck.Enabled = prioritycheck.Checked;
        }

        private void RRcheck_CheckedChanged(object sender, EventArgs e)
        {
            timelabel.Enabled = RRcheck.Checked;
            timetextbox.Enabled = RRcheck.Checked;
        }
   
    }
}
