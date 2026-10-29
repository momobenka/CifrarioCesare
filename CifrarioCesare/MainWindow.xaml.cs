
using System;
using System.Windows;

namespace CifrarioCesare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Metodo per crittografare e decrittografare
        private string TrasformaMessaggio(string messaggio, int chiave)
        {
            string risultato = "";

            foreach (char carattere in messaggio)
            {
                if (carattere >= 'A' && carattere <= 'Z')
                {
                    char nuovaLettera = (char)('A' +
                        (carattere - 'A' + chiave + 26) % 26);

                    risultato += nuovaLettera;
                }
                else if (carattere >= 'a' && carattere <= 'z')
                {
                    char nuovaLettera = (char)('a' +
                        (carattere - 'a' + chiave + 26) % 26);

                    risultato += nuovaLettera;
                }
                else
                {
                    risultato += carattere;
                }
            }

            return risultato;
        }

        // Pulsante Crittografa
        private void BtnCrittografa_Click(object sender, RoutedEventArgs e)
        {
            int chiave;

            if (!int.TryParse(txtChiaveCifra.Text, out chiave))
            {
                MessageBox.Show("Inserisci una chiave numerica valida.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMessaggio.Text))
            {
                MessageBox.Show("Inserisci un messaggio da crittografare.");
                return;
            }

            // Normalizziamo la chiave tra 0 e 25
            chiave = ((chiave % 26) + 26) % 26;

            string messaggio = txtMessaggio.Text;

            string risultato = TrasformaMessaggio(messaggio, chiave);

            txtRisultatoCifra.Text = risultato;

            // Copiamo il risultato nella sezione di decrittografia
            txtMessaggioCifrato.Text = risultato;
        }

        // Pulsante Decrittografa
        private void BtnDecrittografa_Click(object sender, RoutedEventArgs e)
        {
            int chiave;

            if (!int.TryParse(txtChiaveDecifra.Text, out chiave))
            {
                MessageBox.Show("Inserisci una chiave numerica valida.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMessaggioCifrato.Text))
            {
                MessageBox.Show("Inserisci il messaggio crittografato.");
                return;
            }

            // Normalizziamo la chiave tra 0 e 25
            chiave = ((chiave % 26) + 26) % 26;

            string messaggio = txtMessaggioCifrato.Text;

            // Usiamo la chiave inserita, anche se è sbagliata
            string risultato = TrasformaMessaggio(messaggio, -chiave);

            txtRisultatoDecifra.Text = risultato;
        }
    }
}
