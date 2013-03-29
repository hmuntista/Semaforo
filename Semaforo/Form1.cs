using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Semaforo
{
    public partial class Form1 : Form
    {
        Thread semaforo1;
        Thread semaforo2;
        Thread semaforo3;
        Thread semaforo4;
        Thread semaforo5;
        Thread semaforo6;
        Thread semaforo7;
        Thread semaforo8;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public void Inicializar()
        {
            Application.DoEvents();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            semaforo1 = new Thread(new ThreadStart(Hilo1));
            semaforo1.Start();

            semaforo2 = new Thread(new ThreadStart(Hilo2));
            semaforo2.Start();

            semaforo3 = new Thread(new ThreadStart(Hilo3));
            semaforo3.Start();

            semaforo4 = new Thread(new ThreadStart(Hilo4));
            semaforo4.Start();

            semaforo5 = new Thread(new ThreadStart(Hilo5));
            semaforo5.Start();

            semaforo6 = new Thread(new ThreadStart(Hilo6));
            semaforo6.Start();

            semaforo7 = new Thread(new ThreadStart(Hilo7));
            semaforo7.Start();

            semaforo8 = new Thread(new ThreadStart(Hilo8));
            semaforo8.Start();

        }

        public void Hilo1()
        {
            while (true)
            {
                
               // for (int i = 0; i < 15;i++)
                //{
                this.pictureBox18.Image = global::Semaforo.Properties.Resources.sem_verde;
                this.pictureBox2.Image = global::Semaforo.Properties.Resources.sem_rojo;
                this.pictureBox3.Image = global::Semaforo.Properties.Resources.sem_rojo;
                Thread.Sleep(800);
                //semaforo.Abort();
                //}
                //for (int i = 0; i < 15;i++)
                //{
                this.pictureBox18.Image = global::Semaforo.Properties.Resources.sem_rojo;
                this.pictureBox2.Image = global::Semaforo.Properties.Resources.sem_verde;
                this.pictureBox3.Image = global::Semaforo.Properties.Resources.sem_rojo;
                //}
                Thread.Sleep(800);

                this.pictureBox18.Image = global::Semaforo.Properties.Resources.sem_rojo;
                this.pictureBox2.Image = global::Semaforo.Properties.Resources.sem_rojo;
                this.pictureBox3.Image = global::Semaforo.Properties.Resources.sem_verde;
                Thread.Sleep(800);
            }           
        }
        public void Hilo2()
        {
            while (true)
            {
              
                    this.pictureBox21.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox5.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox4.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(800);

                    this.pictureBox21.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox5.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox4.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(800);

                    this.pictureBox21.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox5.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox4.Image = global::Semaforo.Properties.Resources.sem_verde;
                    Thread.Sleep(800);
            }
        }
        public void Hilo3()
        {
            while (true)
            {
                
                    this.pictureBox22.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox7.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox6.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(800);

                    this.pictureBox22.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox7.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox6.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(800);

                    this.pictureBox22.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox7.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox6.Image = global::Semaforo.Properties.Resources.sem_verde;
                    Thread.Sleep(800);
            }
        }
        public void Hilo4()
        {
            while (true)
            {
                
                    this.pictureBox24.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox9.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox8.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(800);

                    this.pictureBox24.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox9.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox8.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(800);

                    this.pictureBox24.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox9.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox8.Image = global::Semaforo.Properties.Resources.sem_verde;
                    Thread.Sleep(800);
            }
        }
        public void Hilo5()
        {
            while (true)
            {
                
                    this.pictureBox19.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox11.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox10.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(800);

                    this.pictureBox19.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox11.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox10.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(800);

                    this.pictureBox11.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox19.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox10.Image = global::Semaforo.Properties.Resources.sem_verde;
                    Thread.Sleep(800);
            }
        }
        public void Hilo6()
        {
            while (true)
            {
                
                    this.pictureBox20.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox13.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox12.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(800);

                    this.pictureBox20.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox13.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox12.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(800);

                    this.pictureBox20.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox13.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox12.Image = global::Semaforo.Properties.Resources.sem_verde;
                    Thread.Sleep(800);
            }
        }
        public void Hilo7()
        {
            while (true)
            {
                
                    this.pictureBox23.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox15.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox14.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(800);

                    this.pictureBox23.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox15.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox14.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(800);

                    this.pictureBox23.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox15.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox14.Image = global::Semaforo.Properties.Resources.sem_verde;
                    Thread.Sleep(800);
            }
        }
        public void Hilo8()
        {
            while (true)
            {
                
                    this.pictureBox25.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox17.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox16.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(800);

                    this.pictureBox25.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox17.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox16.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(800);

                    this.pictureBox25.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox17.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox16.Image = global::Semaforo.Properties.Resources.sem_verde;
                    Thread.Sleep(800);
            }
        }
 
    }

}
