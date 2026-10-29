# Relazione sul cifrario di Cesare in C# WPF

##Benkaref, Ravetti, Sileo, inglese, Quaglino, Manfrè, Alberto.

## Introduzione

Il progetto consiste nella realizzazione di un'applicazione desktop in C# utilizzando WPF, che permette di crittografare e decrittografare messaggi attraverso il cifrario di Cesare. Si tratta di un metodo di crittografia molto semplice, nel quale ogni lettera viene sostituita con un'altra lettera dell'alfabeto, spostata di un numero di posizioni stabilito da una chiave numerica.

## Struttura del programma

L'interfaccia grafica, realizzata nel file `MainWindow.xaml`, è suddivisa in due sezioni affiancate: una dedicata alla crittografia e l'altra alla decrittografia. Entrambe contengono campi di testo per inserire i dati, pulsanti per avviare le operazioni e campi in sola lettura per visualizzare i risultati.

Il file `MainWindow.xaml.cs` contiene invece la logica del programma, cioè le istruzioni che permettono di elaborare i messaggi.

## Funzionamento del codice

Il metodo principale è `TrasformaMessaggio()`, che riceve come parametri il messaggio e la chiave numerica. Attraverso un ciclo `foreach`, il programma analizza ogni carattere del testo. Se il carattere è una lettera maiuscola o minuscola, ne calcola la nuova posizione nell'alfabeto applicando la chiave. L'operatore modulo `% 26` permette di ricominciare dall'inizio dell'alfabeto quando si supera la lettera Z. Spazi, numeri e simboli di punteggiatura rimangono invariati.

La crittografia viene avviata dal metodo `BtnCrittografa_Click()`, collegato al relativo pulsante. Il programma controlla che la chiave inserita sia un numero valido e che il messaggio non sia vuoto. Successivamente normalizza la chiave nell'intervallo da 0 a 25, applica il cifrario e visualizza il risultato. Il messaggio crittografato viene anche copiato automaticamente nel campo della decrittografia.

La decrittografia viene eseguita dal metodo `BtnDecrittografa_Click()`. Dopo aver effettuato i controlli sui dati inseriti, il programma utilizza la chiave in forma negativa per spostare le lettere all'indietro e ottenere il testo decrittografato. Se viene inserita una chiave errata, il programma mostra comunque il risultato ottenuto, che può essere diverso dal messaggio originale.

## Conclusione

Questo progetto permette di comprendere i principi fondamentali della crittografia e di applicare concetti di programmazione come variabili, metodi, cicli, condizioni e gestione degli eventi. Il cifrario di Cesare ha finalità didattiche, poiché non garantisce un livello di sicurezza adeguato per proteggere dati reali.
