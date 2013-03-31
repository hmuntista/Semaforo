using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using STimer = System.Windows.Forms.Timer;

namespace Semaforo
{

    public partial class Form1 : Form
    {
        List<Point> Puntos = new List<Point>();
        STimer timer = new STimer();
        Dictionary<PictureBox, Carro> Carros = new Dictionary<PictureBox,Carro>();

        List<PictureBox> ListaCarros0 = new List<PictureBox>();
        List<PictureBox> ListaCarros1 = new List<PictureBox>();
        List<PictureBox> ListaCarros2 = new List<PictureBox>();
        List<PictureBox> ListaCarros3 = new List<PictureBox>();
        List<PictureBox> ListaCarros4 = new List<PictureBox>();
        List<PictureBox> ListaCarros5 = new List<PictureBox>();
        List<PictureBox> ListaCarros6 = new List<PictureBox>();
        List<PictureBox> ListaCarros7 = new List<PictureBox>(); 

        int time;

        Thread semaforo1;
        Thread semaforo2;
        Thread semaforo3;
        Thread semaforo4;
        Thread semaforo5;
        Thread semaforo6;
        Thread semaforo7;
        Thread semaforo8;

        bool SemaforoAvenidaIzquierda = false;
        bool SemaforoCalles = false;
        bool SemafotoAvenidaDerecha = false;

        int puntoAvenidaDerechaIzquierda1 = 995;
        int puntoAvenidaDerechaIzquierda2 = 995;

        int puntoAvenidaIzquierdaDerecha1 = 100;
        int puntoAvenidaIzquierdaDerecha2 = 100;

        int puntoCalleNorteSur1 = 105;
        int puntoCalleNorteSur2 = 105;

        int puntoCalleSurNorte1 = 553;
        int puntoCalleSurNorte2 = 553;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            Puntos.Add(new Point(210, 41));
            Puntos.Add(new Point(651, 41));
            Puntos.Add(new Point(1092, 189));
            Puntos.Add(new Point(1092, 424));
            Puntos.Add(new Point(883, 625));
            Puntos.Add(new Point(435, 617));
            Puntos.Add(new Point(12, 465));
            Puntos.Add(new Point(12, 232));

            ListaCarros0.Add(this.pictureBox30);
            ListaCarros0.Add(this.pictureBox34);
            ListaCarros0.Add(this.pictureBox35);

            ListaCarros1.Add(this.pictureBox28);
            ListaCarros1.Add(this.pictureBox38);
            ListaCarros1.Add(this.pictureBox39);

            ListaCarros2.Add(this.pictureBox51);
            ListaCarros2.Add(this.pictureBox50);
            ListaCarros2.Add(this.pictureBox49);
            ListaCarros2.Add(this.pictureBox48);
            ListaCarros2.Add(this.pictureBox47);
            ListaCarros2.Add(this.pictureBox26);

            ListaCarros3.Add(this.pictureBox61);
            ListaCarros3.Add(this.pictureBox60);
            ListaCarros3.Add(this.pictureBox59);
            ListaCarros3.Add(this.pictureBox58);
            ListaCarros3.Add(this.pictureBox57);
            ListaCarros3.Add(this.pictureBox32);

            ListaCarros4.Add(this.pictureBox41);
            ListaCarros4.Add(this.pictureBox40);
            ListaCarros4.Add(this.pictureBox27);

            ListaCarros5.Add(this.pictureBox37);
            ListaCarros5.Add(this.pictureBox36);
            ListaCarros5.Add(this.pictureBox29);

            ListaCarros6.Add(this.pictureBox33);
            ListaCarros6.Add(this.pictureBox52);
            ListaCarros6.Add(this.pictureBox53);
            ListaCarros6.Add(this.pictureBox54);
            ListaCarros6.Add(this.pictureBox55);
            ListaCarros6.Add(this.pictureBox56);

            ListaCarros7.Add(this.pictureBox31);
            ListaCarros7.Add(this.pictureBox42);
            ListaCarros7.Add(this.pictureBox43);
            ListaCarros7.Add(this.pictureBox44);
            ListaCarros7.Add(this.pictureBox45);
            ListaCarros7.Add(this.pictureBox46);
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

                this.pictureBox18.Image = global::Semaforo.Properties.Resources.sem_verde;
                this.pictureBox2.Image = global::Semaforo.Properties.Resources.sem_rojo;
                this.pictureBox3.Image = global::Semaforo.Properties.Resources.sem_rojo;

                SemaforoCalles = true;
                SemaforoAvenidaIzquierda = false;
                SemafotoAvenidaDerecha = false;
                
                puntoCalleSurNorte1 = 553;
                puntoCalleSurNorte2 = 553;
                puntoCalleNorteSur1 = 100;
                puntoCalleNorteSur2 = 100;

                Thread.Sleep(30000);// timer calle

                this.pictureBox18.Image = global::Semaforo.Properties.Resources.sem_rojo;
                this.pictureBox2.Image = global::Semaforo.Properties.Resources.sem_verde;
                this.pictureBox3.Image = global::Semaforo.Properties.Resources.sem_rojo;

                SemaforoCalles = false;
                SemaforoAvenidaIzquierda = true;
                SemafotoAvenidaDerecha = false;

                puntoAvenidaDerechaIzquierda1 = 995;
                puntoAvenidaDerechaIzquierda2 = 995;
              
                Thread.Sleep(30000);

                this.pictureBox18.Image = global::Semaforo.Properties.Resources.sem_rojo;
                this.pictureBox2.Image = global::Semaforo.Properties.Resources.sem_rojo;
                this.pictureBox3.Image = global::Semaforo.Properties.Resources.sem_verde;

                SemaforoCalles = false;
                SemaforoAvenidaIzquierda = false;
                SemafotoAvenidaDerecha = true;
                puntoAvenidaIzquierdaDerecha1 = 105;
                puntoAvenidaIzquierdaDerecha2 = 105;

                Thread.Sleep(30000);
            }           
        }
        public void Hilo2()
        {
            while (true)
            {
              
                    this.pictureBox21.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox5.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox4.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(30000);// timer calle

                    this.pictureBox21.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox5.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox4.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(30000);

                    this.pictureBox21.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox5.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox4.Image = global::Semaforo.Properties.Resources.sem_verde;
                    Thread.Sleep(30000);
            }
        }

        public void Hilo3()
        {
            while (true)
            {
                
                    this.pictureBox22.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox7.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox6.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(30000);// timer calle

                    this.pictureBox22.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox7.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox6.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(30000);

                    this.pictureBox22.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox7.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox6.Image = global::Semaforo.Properties.Resources.sem_verde;
                    Thread.Sleep(30000);
            }
        }

        public void Hilo4()
        {
            while (true)
            {
                
                    this.pictureBox24.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox9.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox8.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(30000);// timer calle

                    this.pictureBox24.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox9.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox8.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(30000);

                    this.pictureBox24.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox9.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox8.Image = global::Semaforo.Properties.Resources.sem_verde;
                    Thread.Sleep(30000);
            }
        }

        public void Hilo5()
        {
            while (true)
            {
                
                    this.pictureBox19.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox11.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox10.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(30000);// timer calle

                    this.pictureBox19.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox11.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox10.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(30000);

                    this.pictureBox11.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox19.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox10.Image = global::Semaforo.Properties.Resources.sem_verde;
                    Thread.Sleep(30000);
            }
        }

        public void Hilo6()
        {
            while (true)
            {
                
                    this.pictureBox20.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox13.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox12.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(30000);// timer calle

                    this.pictureBox20.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox13.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox12.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(30000);

                    this.pictureBox20.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox13.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox12.Image = global::Semaforo.Properties.Resources.sem_verde;
                    Thread.Sleep(30000);
            }
        }

        public void Hilo7()
        {
            while (true)
            {
                
                    this.pictureBox23.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox15.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox14.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(30000);// timer calle

                    this.pictureBox23.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox15.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox14.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(30000);

                    this.pictureBox23.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox15.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox14.Image = global::Semaforo.Properties.Resources.sem_verde;
                    Thread.Sleep(30000);
            }
        }

        public void Hilo8()
        {
            while (true)
            {
                
                    this.pictureBox25.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox17.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox16.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(30000);// timer calle

                    this.pictureBox25.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox17.Image = global::Semaforo.Properties.Resources.sem_verde;
                    this.pictureBox16.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    Thread.Sleep(30000);

                    this.pictureBox25.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox17.Image = global::Semaforo.Properties.Resources.sem_rojo;
                    this.pictureBox16.Image = global::Semaforo.Properties.Resources.sem_verde;
                    Thread.Sleep(30000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            timer.Tick += new EventHandler(llamarCoche);
            timer.Interval = (100) * (1);              // Timer will tick evert second
            timer.Enabled = true;                       // Enable the timer
            timer.Start(); 
        }


        void llamarCoche(object sender, EventArgs e)
        {
            time++;

            if (time % 50 == 0)
            {
                generarCarro();
            }

            foreach (KeyValuePair<PictureBox, Carro> pair in Carros)
            {
                

                if (verificarSemaforos(pair.Value))
                {
                    pair.Value.Mover();
                }

                pair.Key.Location = pair.Value.PosicionActual;
                pair.Key.Show();
            }

            
        }

        private bool verificarSemaforos(Carro carro)
        {

            #region Carros de sur a norte
            
            if (SemaforoCalles == false && carro.Direccion == 2) //Sur a Norte
            {
                
                if (carro.PosicionActual.Y >= 548 && carro.PosicionActual.Y <= puntoCalleSurNorte1 && carro.ListaInicial == 5 && carro.parado == false)
                {
                    carro.parado = true;
                    puntoCalleSurNorte1 += 26;
                    return false;
                }
                else if (carro.PosicionActual.Y >= 548 && carro.PosicionActual.Y <= puntoCalleSurNorte2 && carro.ListaInicial == 4 && carro.parado == false)
                {
                    carro.parado = true;
                    puntoCalleSurNorte2 += 26;
                    return false;
                }
                else if (carro.PosicionActual.Y >= 290 && carro.PosicionActual.Y <= puntoCalleSurNorte1-238 && carro.ListaInicial == 5 && carro.parado == false)
                {
                    carro.parado = true;
                    puntoCalleSurNorte1 += 26;
                    return false;
                }
                else if (carro.PosicionActual.Y >= 290 && carro.PosicionActual.Y <= puntoCalleSurNorte2-238 && carro.ListaInicial == 4 && carro.parado == false)
                {
                    carro.parado = true;
                    puntoCalleSurNorte2 += 26;
                    return false;
                }
                else if(carro.parado == true)
                {
                    return false;
                }

            }
            else if (SemaforoCalles == true && carro.Direccion == 2)
            {
                carro.parado = false;
            }
            #endregion

            #region Carros de norte a sur

            if (SemaforoCalles == false && carro.Direccion == 0) // Norte a Sur
            {

                if (carro.PosicionActual.Y >= puntoCalleNorteSur1 && carro.PosicionActual.Y <= 105 && carro.ListaInicial == 0 && carro.parado == false)
                {
                    carro.parado = true;
                    puntoCalleNorteSur1 -= 26;
                    return false;
                }
                else if (carro.PosicionActual.Y >= puntoCalleNorteSur2 && carro.PosicionActual.Y <= 105 && carro.ListaInicial == 1 && carro.parado == false)
                {
                    carro.parado = true;
                    puntoCalleNorteSur2 -= 26;
                    return false;
                }
                else if (carro.PosicionActual.Y >= puntoCalleNorteSur1 + 240 && carro.PosicionActual.Y <= 360 && carro.ListaInicial == 0 && carro.parado == false)
                {
                    carro.parado = true;
                    puntoCalleNorteSur1 -= 26;
                    return false;
                }
                else if (carro.PosicionActual.Y >= puntoCalleNorteSur2 + 240 && carro.PosicionActual.Y <= 360 && carro.ListaInicial == 1 && carro.parado == false)
                {
                    carro.parado = true;
                    puntoCalleNorteSur2 -= 26;
                    return false;
                }
                else if (carro.parado == true)
                {
                    return false;
                }

            }
            else if (SemaforoCalles == true && carro.Direccion == 0)
            {
                carro.parado = false;
            }

            #endregion

            #region Carros de derecha a izquierda

            if (SemaforoAvenidaIzquierda == false && carro.Direccion == 1) //Derecha a Izquierda
            {
                if (carro.PosicionActual.X >= 990 && carro.PosicionActual.X <= puntoAvenidaDerechaIzquierda1 && carro.ListaInicial == 2 && carro.parado == false)
                {
                    carro.parado = true;
                    puntoAvenidaDerechaIzquierda1 += 30;
                    return false;
                }
                else if (carro.PosicionActual.X >= 990 && carro.PosicionActual.X <= puntoAvenidaDerechaIzquierda2 && carro.ListaInicial == 3 && carro.parado == false)
                {
                    carro.parado = true;
                    puntoAvenidaDerechaIzquierda2 += 30;
                    return false;
                }
                else if (carro.parado == true)
                {
                    return false;
                }
            }
            else if (SemaforoAvenidaIzquierda == true && carro.Direccion == 1)
            {
                carro.parado = false;
            }

            #endregion

            #region Carros de izquierda a derecha

            if (SemafotoAvenidaDerecha == false && carro.Direccion == 3) //Izquierda a Derecha
            {
                if (carro.PosicionActual.X >= puntoAvenidaIzquierdaDerecha1 && carro.PosicionActual.X <= 105 && carro.ListaInicial == 7 && carro.parado == false)
                {
                    carro.parado = true;
                    puntoAvenidaIzquierdaDerecha1 -= 30;
                    return false;
                }
                else if (carro.PosicionActual.X >= puntoAvenidaIzquierdaDerecha2 && carro.PosicionActual.X <= 105 && carro.ListaInicial == 6 && carro.parado == false)
                {
                    carro.parado = true;
                    puntoAvenidaIzquierdaDerecha2 -= 30;
                    return false;
                }
                else if (carro.parado == true)
                {
                    return false;
                }
            }
            else if (SemafotoAvenidaDerecha == true && carro.Direccion == 3)
            {
                carro.parado = false;
            }

            #endregion

            return true;
        }

        public void generarCarro()
        {
            Carro carro = null;
            Random random = new Random();
            int randomN = random.Next(0, 8);
            Point punto = new Point();
            punto = Puntos[randomN];

            if (randomN == 0) // 0 = Norte a Sur
            {
                carro = new Carro(punto, 0, 0);
                Carros[ListaCarros0[0]] = carro;
                ListaCarros0.RemoveAt(0);
            }
            if (randomN == 1) // 0 = Norte a Sur
            {
                carro = new Carro(punto, 0, 1);
                Carros[ListaCarros1[0]] = carro;
                ListaCarros1.RemoveAt(0);
            }
            else if (randomN == 2) // 1 = Oriente a Poniente
            {
                carro = new Carro(punto, 1,2);
                Carros[ListaCarros2[0]] = carro;
                ListaCarros2.RemoveAt(0);
            }
            else if (randomN == 3) // 1 = Oriente a Poniente
            {
                carro = new Carro(punto, 1, 3);
                Carros[ListaCarros3[0]] = carro;
                ListaCarros3.RemoveAt(0);
            }
            else if (randomN == 4) // 2 = Sur a Norte
            {
                carro = new Carro(punto, 2, 4);
                Carros[ListaCarros4[0]] = carro;
                ListaCarros4.RemoveAt(0);
            }
            else if (randomN == 5) // 2 = Sur a Norte
            {
                carro = new Carro(punto, 2, 5);
                Carros[ListaCarros5[0]] = carro;
                ListaCarros5.RemoveAt(0);
            }
            else if (randomN == 6) // 3 = Poniente a Oriente
            {
                carro = new Carro(punto, 3, 6);
                Carros[ListaCarros6[0]] = carro;
                ListaCarros6.RemoveAt(0);
            }
            else if (randomN == 7) // 3 = Poniente a Oriente
            {
                carro = new Carro(punto, 3, 7);
                Carros[ListaCarros7[0]] = carro;
                ListaCarros7.RemoveAt(0);
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SemaforoCalles = false;
        }


    }

}
