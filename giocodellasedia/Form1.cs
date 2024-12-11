namespace giocodellasedia
{
    public partial class Form1 : Form
    {
        static List<Thread> threads = new List<Thread>();
        static int numSedie;
        static int numSedieLibere;
        static object lockObject = new object();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAvviaGioco_Click(object sender, EventArgs e)
        {
            // Ottieni i numeri di bambini e sedie dalla TextBox
            int numBambini = int.Parse(txtBambini.Text);
            if (numBambini <= 0)
            {
                MessageBox.Show("Il numero di bambini deve essere maggiore di 0.");
                return;
            }

            Console.WriteLine("Benvenuti al gioco delle sedie musicali!");
            Console.WriteLine("Inserisci il numero di bambini: " + numBambini);

            int numSedie = int.Parse(txtSedie.Text);
            if (numSedie <= 0)
            {
                MessageBox.Show("Il numero di sedie deve essere maggiore di 0.");
                return;
            }

            numSedieLibere = numSedie;

            // Aggiungi il codice per avviare il gioco, avvia i thread per ogni bambino
            threads.Clear();
            listBoxGiocatori.Items.Clear();
            for (int i = 0; i < numBambini; i++)
            {
                Thread thread = new Thread(Play);
                thread.Name = "Bambino" + i;
                threads.Add(thread);
                listBoxGiocatori.Items.Add("Bambino" + i);
                thread.Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }

            lblStatoGioco.Text = "Il gioco è finito. Tutti i bambini hanno vinto!";
        }


        static void Play()
        {
            Random random = new Random();
            string nome = Thread.CurrentThread.Name;

            while (numSedieLibere > 1)
            {
                // La musica si ferma e il bambino cerca una sedia
                Invoke(new Action(() =>
                {
                    lblStatoGioco.Text = $"La musica si è fermata! {nome} si è seduto.";
                }));

                // Tempo in cui il bambino balla
                Thread.Sleep(random.Next(1000, 2000));

                lock (lockObject)
                {
                    if (numSedieLibere > 0)
                    {
                        numSedieLibere--;
                        Invoke(new Action(() =>
                        {
                            listBoxGiocatori.Items.Remove(nome); // Elimina il bambino che non è riuscito a sedersi
                        }));
                    }
                    else
                    {
                        Invoke(new Action(() =>
                        {
                            lblStatoGioco.Text = $"{nome} è eliminato.";
                        }));
                        break;
                    }
                }

            }
        }
    }
 

