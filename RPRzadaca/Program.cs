using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SvezaOrdinacije;
namespace RPRzadaca
{
    class Program
    {
        delegate void MojDelegat(Klinika klinika17818, NormalniPacijent n);
        static void VozackaDozvola (Klinika klinika17818, NormalniPacijent pacijent17818_1)
        {
            //automatski dobije sve
            //   pacijent17818_1.kartonPacijenta.PreglediPacijenta.Add(new Pregled(klinika17818.oftalmolog, pacijent17818_1));
            klinika17818.pregledi.Add(new Pregled(klinika17818.oftalmolog, pacijent17818_1));
            klinika17818.redoslijedOftalmolog.Add(new Pregled(klinika17818.oftalmolog, pacijent17818_1)); //specificno cekanje
                                                                                                          //znamo sve preglede koji su se desili dok brisemo samo one koji su u cekanju
            Console.WriteLine("Kod oftalmologa ste {0}. na redu.", klinika17818.redoslijedOftalmolog.Count);

            //pacijent17818_1.kartonPacijenta.PreglediPacijenta.Add(new Pregled(klinika17818.opcaPraksa, pacijent17818_1));
            klinika17818.pregledi.Add(new Pregled(klinika17818.opcaPraksa, pacijent17818_1));
            klinika17818.redoslijedOpcaPraksa.Add(new Pregled(klinika17818.opcaPraksa, pacijent17818_1));
            Console.WriteLine("Kod doktora opce prakse ste {0}. na redu.", klinika17818.redoslijedOpcaPraksa.Count);

            //pacijent17818_1.kartonPacijenta.PreglediPacijenta.Add(new Pregled(klinika17818.psiholog, pacijent17818_1));
            klinika17818.pregledi.Add(new Pregled(klinika17818.psiholog, pacijent17818_1));
            klinika17818.redoslijedPsiholog.Add(new Pregled(klinika17818.psiholog, pacijent17818_1));
            Console.WriteLine("Kod psihologa ste {0}. na redu.\n", klinika17818.redoslijedPsiholog.Count);
            
        }
        static void SamostalanIzbor(Klinika klinika17818, NormalniPacijent pacijent17818_1)
        {
            int izborDoktora;
            bool biraoOftalmologa = false, biraoOpcuPraksu = false, biraoPsihologa = false;
            do
            {
                Console.WriteLine("Za kojeg doktora ste zainteresirani?\n" +
                    "1-OFTALMOLOG\n" +
                    "2-DOKTOR OPCE PRAKSE\n" +
                    "3-PSIHOLOG\n" +
                    "4-ZAVRSI IZBOR DOKTORA");
                izborDoktora = Convert.ToInt32(Console.ReadLine());
                if (izborDoktora == 1)
                {
                    if (biraoOftalmologa)
                    {
                        Console.WriteLine("Vec ste jednom izabrali ovog doktora! Pregled nije registrovan.");
                        continue;
                    }
                    //pacijent17818_1.kartonPacijenta.PreglediPacijenta.Add(new Pregled(klinika17818.oftalmolog, pacijent17818_1));
                    klinika17818.pregledi.Add(new Pregled(klinika17818.oftalmolog, pacijent17818_1));
                    klinika17818.redoslijedOftalmolog.Add(new Pregled(klinika17818.oftalmolog, pacijent17818_1));
                    Console.WriteLine("Kod oftalmologa ste {0}. na redu.", klinika17818.redoslijedOftalmolog.Count);
                    biraoOftalmologa = true; //zastita od prekomjernog izbora
                }
                else if (izborDoktora == 2)
                {
                    if (biraoOpcuPraksu)
                    {
                        Console.WriteLine("Vec ste jednom izabrali ovog doktora! Pregled nije registrovan.");
                        continue;
                    }
                    //pacijent17818_1.kartonPacijenta.PreglediPacijenta.Add(new Pregled(klinika17818.opcaPraksa, pacijent17818_1));
                    klinika17818.pregledi.Add(new Pregled(klinika17818.opcaPraksa, pacijent17818_1));
                    klinika17818.redoslijedOpcaPraksa.Add(new Pregled(klinika17818.opcaPraksa, pacijent17818_1));
                    Console.WriteLine("Kod doktora opce prakse ste {0}. na redu.", klinika17818.redoslijedOpcaPraksa.Count);
                    biraoOpcuPraksu = true; //zastita od prekomjernog izbora
                }
                else if (izborDoktora == 3)
                {
                    if (biraoPsihologa)
                    {
                        Console.WriteLine("Vec ste jednom izabrali ovog doktora! Pregled nije registrovan.");
                        continue;
                    }
                    // pacijent17818_1.kartonPacijenta.PreglediPacijenta.Add(new Pregled(klinika17818.psiholog, pacijent17818_1));
                    klinika17818.pregledi.Add(new Pregled(klinika17818.psiholog, pacijent17818_1));
                    klinika17818.redoslijedPsiholog.Add(new Pregled(klinika17818.psiholog, pacijent17818_1));
                    Console.WriteLine("Kod psihologa ste {0}. na redu.", klinika17818.redoslijedPsiholog.Count);
                    biraoPsihologa = true; //zastita od prekomjernog izbora
                }
            } while (izborDoktora != 4);
        }
        static void PoslovniPregled(Klinika klinika17818, NormalniPacijent pacijent17818_1)
        {
            //automatski dobije sve
            //   pacijent17818_1.kartonPacijenta.PreglediPacijenta.Add(new Pregled(klinika17818.oftalmolog, pacijent17818_1));
            klinika17818.pregledi.Add(new Pregled(klinika17818.oftalmolog, pacijent17818_1));
            klinika17818.redoslijedOftalmolog.Add(new Pregled(klinika17818.oftalmolog, pacijent17818_1));
            Console.WriteLine("Kod oftalmologa ste {0}. na redu.", klinika17818.redoslijedOftalmolog.Count);

            // pacijent17818_1.kartonPacijenta.PreglediPacijenta.Add(new Pregled(klinika17818.opcaPraksa, pacijent17818_1));
            klinika17818.pregledi.Add(new Pregled(klinika17818.opcaPraksa, pacijent17818_1));
            klinika17818.redoslijedOpcaPraksa.Add(new Pregled(klinika17818.opcaPraksa, pacijent17818_1));
            Console.WriteLine("Kod doktora opce prakse ste {0}. na redu.\n", klinika17818.redoslijedOpcaPraksa.Count);

        }
        static void Registruj(Klinika klinika17818, NormalniPacijent n, bool hitanSlucaj)
        {
            Hitnislucaj hitan17818 = new Hitnislucaj(n);
            if (hitanSlucaj)
            {
                Console.WriteLine("Je li pruzena prva pomoc?");
                string prvaPomoc = Console.ReadLine();
                bool ispravanUnos = Boolean.TryParse(prvaPomoc, out bool pruzenaPrvaPomoc);
                Console.WriteLine("Opisite postupak koji je proveden nad pacijentom...");
                string postupakPrvePomoci = Console.ReadLine();
                Console.WriteLine("Pacijent je stabiliziran?\n1-DA\n2-NE");
                int stabilan = Convert.ToInt32(Console.ReadLine());
                hitan17818.Stabilan = (stabilan == 1);
                if (hitan17818.Stabilan == false)
                {
                    Console.WriteLine("Pacijent je mrtav?\n" +
                        "1-DA\n" +
                        "2-NE");
                    int DaLiJeMrtav = Convert.ToInt32(Console.ReadLine());
                    if (DaLiJeMrtav == 1)
                    {
                        Console.WriteLine("Unesite datum i vrijeme smrti...");
                        hitan17818.VrijemeSmrti = Console.ReadLine();
                        Console.WriteLine("Opisite postupak lijecenja pacijenta...");
                        hitan17818.PostupakLijecenja = Console.ReadLine();
                        Console.WriteLine("Koji je uzrok smrti pacijenta?");
                        hitan17818.UzrokSmrti = Console.ReadLine();
                        Console.WriteLine("Unesite rezultat obdukcije...");
                        hitan17818.Obdukcija = Console.ReadLine();
                    }
                }
            }
            Console.WriteLine("Unesite ime pacijenta...");
            n.Ime = Console.ReadLine();
            Console.WriteLine("Unesite prezime pacijenta...");
            n.Prezime = Console.ReadLine();
            Console.WriteLine("Unesite datum rodjenja pacijenta...");
            n.Datumrodjenja = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Unesite mat. broj pacijenta...");
            n.MaticniBroj = Console.ReadLine();
            Console.WriteLine("Kojeg je spola pacijent?");
            n.Spol = Console.ReadLine();
            Console.WriteLine("Unesite adresu pacijenta...");
            n.AdresaStanovanja = Console.ReadLine();
            NormalniPacijent pacijent17818_1; //od sada on preuzima da je lakse registrovati preglede
            if (hitanSlucaj == false)
            {
                klinika17818.pacijenti.Add(n);
                pacijent17818_1 = n;
            }
            else
            {
                klinika17818.pacijenti.Add(hitan17818);
                pacijent17818_1 = n;
            }
            Console.WriteLine("Dodan pacijent, sada ih ukupno ima {0}", klinika17818.pacijenti.Count());
            Console.Write(Environment.NewLine);
            Console.WriteLine("Za koje preglede ste zainteresirani?\n" +
                "1-VOZACKA DOZVOLA\n" +
                "2-SISTEMATSKI PREGLED\n" +
                "3-SAM/A ZELIM BIRATI");
            int zainteresiran = Convert.ToInt32(Console.ReadLine());
            switch (zainteresiran)
            {
                case 1:
                    MojDelegat delegat17818_1 =VozackaDozvola;
                    delegat17818_1(klinika17818,pacijent17818_1);
                    break;
                case 2:
                    MojDelegat delegat17818_2 = PoslovniPregled;
                    delegat17818_2(klinika17818, pacijent17818_1);
                    break;
                case 3:
                    MojDelegat delegat17818_3 = SamostalanIzbor;
                    delegat17818_3(klinika17818, pacijent17818_1);
                    break;
            }
        }
        static void StvoriKarton(Klinika klinika17818, NormalniPacijent pacijent17818_1)
        {
            Karton karton17818_1 = new Karton(pacijent17818_1);
            Console.WriteLine("Pocinje stvaranje kartona za pacijenta...");
            Console.WriteLine("Unesite podatke o prijasnjim bolestima pacijenta...");
            karton17818_1.Bolesti = Console.ReadLine();
            Console.WriteLine("Koje vakcine je pacijent primio?");
            karton17818_1.Vakcinacija = Console.ReadLine();
            Console.WriteLine("Unesite datum kreiranja kartona...");
            karton17818_1.DatumOtvaranjaKartona = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Pacijent je pusac?\n1-DA\n2-NE");
            int pacijentPusi = Convert.ToInt32(Console.ReadLine());
            karton17818_1.PacijentPusac = (pacijentPusi == 1);
            Console.WriteLine("Pacijent je alkoholicar?\n1-DA\n2-NE");
            int pacijentAlkohol = Convert.ToInt32(Console.ReadLine());
            karton17818_1.PacijentAlkohol = (pacijentAlkohol == 1);
            Console.WriteLine("Pacijent je uzivalac opojnih droga?\n1-DA\n2-NE");
            int pacijentDroga = Convert.ToInt32(Console.ReadLine());
            karton17818_1.PacijentDroga = (pacijentDroga == 1);
            Console.WriteLine("Kreiran karton za pacijenta {0} {1}, rodjenog {2}", pacijent17818_1.Ime, pacijent17818_1.Prezime, pacijent17818_1.Datumrodjenja);
            klinika17818.kartoniPacijenata.Add(karton17818_1);
        }
        static void PronadjiUKartonu(Klinika klinika17818, Karton karton17818)
        {
            Console.WriteLine("Odaberite kriterij pretrage...\n" +
                "1-DOKTOR KOJI JE PREGLEDAO PACIJENTA" +
                "2-PODACI O PRIJASNJIM BOLESTIMA" +
                "3-DATUM VRSENJA PREGLEDA" +
                "4-TIP DOKTORA KOJI JE PREGLEDAO PACIJENTA");
            int izborKriterija = Convert.ToInt32(Console.ReadLine());
            switch (izborKriterija)
            {
                case 1:
                    Console.WriteLine("Cije preglede zelite pronaci u kartonu pacijenta? Unesite ime doktora...");
                    string unosImeDoktora = Console.ReadLine();
                    Console.WriteLine("Cije preglede zelite pronaci u kartonu pacijenta? Unesite prezime doktora...");
                    string unosPrezimeDoktora = Console.ReadLine();
                    foreach (Pregled p in karton17818.PreglediPacijenta)
                        if (p.OdgovorniDoktor1.Ime1 == unosImeDoktora && p.OdgovorniDoktor1.Prezime1 == unosPrezimeDoktora)
                            Console.WriteLine("Doktor {0} je dana {1} pregledao pacijenta i propisao terapiju {2}. Rezultat pregleda je {3}", unosPrezimeDoktora, p.DatumPregleda1, p.Terapija, p.RezultatiPregleda1);
                    break;
                case 2:
                    Console.WriteLine("Unesite podatke o prijasnjim bolestima koje zelite pretraziti unutar kartona...");
                    string unosBolesti = Console.ReadLine();
                    foreach (Pregled p in karton17818.PreglediPacijenta)
                        if (karton17818.Bolesti.Contains(unosBolesti))
                            Console.WriteLine("Pronadjen podstring {0} u prijasnjim bolestima pacijenta\n{1}", unosBolesti, karton17818.Bolesti);
                    break;
                case 3:
                    Console.WriteLine("Na koji datum zelite pretraziti preglede?");
                    DateTime unosDatuma = Convert.ToDateTime(Console.ReadLine());
                    foreach (Pregled p in karton17818.PreglediPacijenta)
                    {
                        if (p.DatumPregleda1 == unosDatuma) Console.WriteLine("Ovo su pregledi na datum {0}:\n", unosDatuma);
                        Console.WriteLine("Doktor {0} je dana {1} pregledao pacijenta i propisao terapiju {2}. Rezultat pregleda je {3}", p.OdgovorniDoktor1.Prezime1, p.DatumPregleda1, p.Terapija, p.RezultatiPregleda1);
                    }
                    break;
                case 4:
                    Console.WriteLine("Kojeg tipa su doktori cije preglede zelite izlistati?");
                    string unosTipaDoktora = Console.ReadLine();
                    foreach (Pregled p in karton17818.PreglediPacijenta)
                        if (p.OdgovorniDoktor1.VrstaDoktora == unosTipaDoktora)
                            Console.WriteLine("Doktor {0} je dana {1} pregledao pacijenta i propisao terapiju {2}. Rezultat pregleda je {3}", p.OdgovorniDoktor1.Prezime1, p.DatumPregleda1, p.Terapija, p.RezultatiPregleda1);
                    break;
            }
        }
        static void RegistrujPregledPacijentu(Klinika klinika17818, NormalniPacijent n)
        {
            int brojac = 1, brojPregleda;
            bool tacanIndeks = true;
            Pregled pregled17818 = new Pregled();
            Doktor doktor17818 = new Doktor();
            if (klinika17818.pregledi.Count == 0) Console.WriteLine("Pacijent nema upisanih pregleda!");
            else
            {
                Console.WriteLine("Pacijent {0} {1} ima zakazane preglede:\n");
                foreach (Pregled p in klinika17818.pregledi) if (p.PacijentKojiSePregleda == n)
                    {
                        Console.WriteLine("{0} Pregled kod specijaliste {1}, {2} {3}", brojac, p.OdgovorniDoktor1.VrstaDoktora, p.OdgovorniDoktor1.Ime1, p.OdgovorniDoktor1.Prezime1);
                        doktor17818 = p.OdgovorniDoktor1;
                        brojac++;
                    }
                do
                {
                    Console.WriteLine("Unesite indeks pregleda koji zelite obaviti...");
                    brojPregleda = Convert.ToInt32(Console.ReadLine());
                    if (brojPregleda > brojac || brojPregleda < 1) Console.WriteLine("Neispravan indeks!");
                } while (tacanIndeks == false);
                brojac = 0;
                foreach (Pregled p in klinika17818.pregledi) if (p.PacijentKojiSePregleda == n)
                    {
                        if (brojPregleda == brojac) pregled17818 = p;
                    }
                Console.WriteLine("Koju vrstu pregleda zelite obaviti?");
                pregled17818.TipPregleda1 = Console.ReadLine();
                Console.WriteLine("Unesite datum na koji se obavlja pregled...");
                pregled17818.DatumPregleda1 = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Unesite rezultat pregleda...");
                pregled17818.RezultatiPregleda1 = Console.ReadLine();
                Console.WriteLine("Unesite preporucenu terapiju...");
                pregled17818.Terapija = Console.ReadLine();
                Console.WriteLine("Terapiju treba uzimati dugorocno?\n" +
                    "1-DA\n" +
                    "2-NE");
                int dugorocnaTerapija = Convert.ToInt32(Console.ReadLine());
                if (dugorocnaTerapija == 1) pregled17818.DugorocnaTerapija = true;
                string unosGarancije;
                do
                {
                    Console.WriteLine("Unesite svoju doktorsku garanciju...");
                    unosGarancije = Console.ReadLine();
                    if (unosGarancije != doktor17818.Mojagarancija) Console.WriteLine("Pristup odbijen! Pogresna garancija");
                } while (unosGarancije != doktor17818.Mojagarancija);
                n.postupci.Add(pregled17818.TipPregleda1);
                n.cijenePregleda.Add(doktor17818.ordinacijaDoktora.IznosNaplate());
                doktor17818.BrojPregledanihPacijenata1++;
            }
        }
        static void DajRacun(Klinika klinika17818, NormalniPacijent n)
        {
            bool imaBaremJedanPregled = false;
            double suma = 0;
            foreach (Pregled p in klinika17818.pregledi)
                if (p.PacijentKojiSePregleda == n) imaBaremJedanPregled = true;
            if (imaBaremJedanPregled == true)
            {
                Console.WriteLine("Sada cemo printati racun za pacijenta...\n" +
                    "Pacijent je koristio sljedece usluge...");
                for (int i = 0; i < n.postupci.Count; i++)
                    Console.Write("Procedura {0}...", n.postupci[i]);
                for (int i = 0; i < n.cijenePregleda.Count; i++)
                {
                    Console.WriteLine("cijena procedure", n.cijenePregleda[i]);
                    suma += n.cijenePregleda[i];
                }
                Console.WriteLine("Da li zelite platiti na rate ili gotovinski?\n" +
                    "1-PLACANJE NA RATE\n" +
                    "2-GOTOVINSKO PLACANJE");
                int izborPlacanja = Convert.ToInt32(Console.ReadLine());
                if (izborPlacanja == 1)
                {
                    n.BrojPosjetaKlinici++;
                    if (n.BrojPosjetaKlinici < 3) Console.WriteLine("Vi niste nas redovni pacijent, stoga nemate popust na gotovinsko placanje.");
                    else
                    {
                        suma /= 100;
                        suma *= 90; //10 posto
                    }
                    Console.WriteLine("___________________\n" +
                        "Vas ukupni saldo je {0}KM.", suma);
                }
                else if (izborPlacanja == 2)
                {
                    Console.WriteLine("Molimo unesite broj rata...");
                    int brojRata = Convert.ToInt32(Console.ReadLine());
                    n.BrojPosjetaKlinici++;
                    if (n.BrojPosjetaKlinici < 3)
                    {
                        Console.WriteLine("Vi niste nas redovni pacijent, stoga nazalost morate platiti 15% vise prilikom odlozenog placanja.");
                        suma /= 100;
                        suma *= 115;
                    }
                    Console.WriteLine("___________________\n" +
                        "Vas ukupni saldo je {0}KM.\n" +
                        "Iznos jedne rate je {1}KM, a preostaje vam jos {2} rata.", suma, suma / brojRata, brojRata - 1);
                }
            }
        }
        static void PrikaziRaspored(Klinika klinika17818, NormalniPacijent n)
        {
            string tipDoktora = "";
            List<int> sortiranjeIndeksa = new List<int>()
            {
                klinika17818.redoslijedOftalmolog.Count,
                klinika17818.redoslijedOpcaPraksa.Count,
                klinika17818.redoslijedPsiholog.Count
            };

            var sortiranaLista = sortiranjeIndeksa.Select((x, i) => new KeyValuePair<int, int>(x, i)).OrderBy(x => x.Key).ToList();
            List<int> raspored = sortiranaLista.Select(x => x.Key).ToList();
            List<int> indeksi = sortiranaLista.Select(x => x.Value).ToList();
            for (int i = 0; i < sortiranjeIndeksa.Count; i++)
            {
                switch (indeksi[i])
                {
                    case 1:
                        tipDoktora = "oftalmolog";
                        break;
                    case 2:
                        tipDoktora = "opca praksa";
                        break;
                    case 3:
                        tipDoktora = "psiholog";
                        break;
                }
                if (raspored[i] != 0) //bez nezakazanih
                    Console.WriteLine("{0}. Idete kod doktora {1}, na redu za ulazak ste {2}", i + 1, tipDoktora, raspored[i]);
            }
        }
        static void Main(string[] args)
        {
            //kontejnerska klinika_
            Klinika klinika17818 = new Klinika();
            NormalniPacijent n = new NormalniPacijent();
            Karton karton17818_1 = new Karton(n);
            bool postojiPacijent = false, postojiKartonPacijenta = false;
            int izbor;
            do
            {
                Console.WriteLine("Dobro dosli!Odaberite jednu od opcija:\n" +
                 "1.Registruj/Briši pacijenta\n" +
                 "2.Prikaži raspored pregleda pacijenta\n" +
                 "3.Kreiranje kartona pacijenta\n" +
                 "4.Pretraga kartona pacijenta\n" +
                 "5.Registruj novi pregled\n" +
                 "6.Analiza sadržaja\n" +
                 "7.Naplata\n" +
                 "8.Izlaz");
                izbor = Convert.ToInt32(Console.ReadLine());
                switch (izbor)
                {
                    case 1:
                        Console.WriteLine("Zelite li dodati pacijenta ili brisati?\n" +
                            "1-DODATI PACIJENTA\n" +
                            "2-BRISATI PACIJENTA");
                        int BrisiPisi = Convert.ToInt32(Console.ReadLine());
                        if (BrisiPisi == 1)
                        {
                            Console.WriteLine("Da li se radi o hitnom slucaju?\n1-DA\n2-NE");
                            int izborHitnogSlucaja = Convert.ToInt32(Console.ReadLine());
                            if (izborHitnogSlucaja == 1) Registruj(klinika17818, n, true);
                            else Registruj(klinika17818, n, false);
                        }
                        else if (BrisiPisi == 2)
                        {
                            if (klinika17818.pacijenti.Count == 0) Console.WriteLine("Nema pacijenata za brisanje");
                            else
                            {
                                Console.WriteLine("Kojeg pacijenta zelite brisati? Unesite ime...");
                                string unosImePacijenta = Console.ReadLine();
                                Console.WriteLine("Kojeg pacijenta zelite brisati? Unesite prezime...");
                                string unosPrezimePacijenta = Console.ReadLine();
                                foreach (NormalniPacijent pacijent17818_1 in klinika17818.pacijenti)
                                    //trazi postoji li taj pacijent
                                    if (pacijent17818_1.Ime == unosImePacijenta && pacijent17818_1.Prezime == unosPrezimePacijenta)
                                    {
                                        klinika17818.pacijenti.Remove(pacijent17818_1);
                                        Console.WriteLine("Obrisan pacijent!\n");
                                        break;
                                    }
                            }
                        }
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("Za kojeg pacijenta zelite prikazati preglede? Unesite ime...");
                            string unosImePacijenta = Console.ReadLine();
                            Console.WriteLine("Za kojeg pacijenta zelite prikazati preglede? Unesite prezime...");
                            string unosPrezimePacijenta = Console.ReadLine();
                            foreach (NormalniPacijent pacijent17818_1 in klinika17818.pacijenti)
                                //trazi postoji li taj pacijent
                                if (pacijent17818_1.Ime == unosImePacijenta && pacijent17818_1.Prezime == unosPrezimePacijenta)
                                {
                                    n = pacijent17818_1; //dodjela da ide u funkciju
                                    postojiPacijent = true;
                                }
                            if (postojiPacijent == false)
                            {
                                Console.WriteLine("Nije pronadjen pacijent {0} {1}.\n" +
                                "1-PONOVNI POKUSAJ\n" +
                                "2-ODUSTAJANJE OD PRIKAZA PREGLEDA", unosImePacijenta, unosPrezimePacijenta);
                                int ponovoProbaj = Convert.ToInt32(Console.ReadLine());
                                if (ponovoProbaj == 2) break;
                            }
                            else PrikaziRaspored(klinika17818, n);
                        } while (postojiPacijent == false);
                        break;
                    case 3:
                        do
                        {
                            Console.WriteLine("Kojem pacijentu zelite kreirati karton? Unesite ime...");
                            string unosImePacijenta = Console.ReadLine();
                            Console.WriteLine("Kojem pacijentu zelite kreirati karton? Unesite prezime...");
                            string unosPrezimePacijenta = Console.ReadLine();
                            foreach (NormalniPacijent pacijent17818_1 in klinika17818.pacijenti)
                                //trazi postoji li taj pacijent
                                if (pacijent17818_1.Ime == unosImePacijenta && pacijent17818_1.Prezime == unosPrezimePacijenta)
                                {
                                    n = pacijent17818_1; //dodjela da ide u funkciju
                                    postojiPacijent = true;
                                }
                            if (postojiPacijent == false)
                            {
                                Console.WriteLine("Nije pronadjen pacijent {0} {1}.\n" +
                                "1-PONOVNI POKUSAJ\n" +
                                "2-ODUSTAJANJE OD KREIRANJA KARTONA", unosImePacijenta, unosPrezimePacijenta);
                                int ponovoProbaj = Convert.ToInt32(Console.ReadLine());
                                if (ponovoProbaj == 2) break;
                            }
                            else StvoriKarton(klinika17818, n);
                        } while (postojiPacijent == false);
                        break;
                    case 4:
                        do
                        {
                            Console.WriteLine("Kojem pacijentu zelite pretraziti karton? Unesite ime...");
                            string unosImePacijenta = Console.ReadLine();
                            Console.WriteLine("Kojem pacijentu zelite pretraziti karton? Unesite prezime...");
                            string unosPrezimePacijenta = Console.ReadLine();
                            foreach (NormalniPacijent pacijent17818_1 in klinika17818.pacijenti)
                                //trazi postoji li taj pacijent
                                if (pacijent17818_1.Ime == unosImePacijenta && pacijent17818_1.Prezime == unosPrezimePacijenta)
                                {
                                    n = pacijent17818_1; //dodjela da ide u funkciju
                                    postojiPacijent = true;
                                    Console.WriteLine("Pronadjen pacijent!");
                                }
                            if (postojiPacijent == false)
                            {
                                Console.WriteLine("Nije pronadjen pacijent {0} {1} pa samim time niti njegov karton.\n" +
                                "1-PONOVNI POKUSAJ\n" +
                                "2-ODUSTAJANJE OD PRETRAGE KARTONA", unosImePacijenta, unosPrezimePacijenta);
                                int ponovoProbaj = Convert.ToInt32(Console.ReadLine());
                                if (ponovoProbaj == 2) break;
                            }
                            else
                            {
                                foreach (Karton k in klinika17818.kartoniPacijenata)
                                    if (k.Pacijent17818.Ime == unosImePacijenta && k.Pacijent17818.Prezime == unosPrezimePacijenta)
                                    {
                                        karton17818_1 = k;
                                        postojiKartonPacijenta = true;
                                        Console.WriteLine("Pronadjen karton pacijenta!");
                                    }
                                if (postojiKartonPacijenta == false)
                                {
                                    Console.WriteLine("Nije pronadjen karton pacijenta {0} {1}. Provjerite da ste kreirali karton pacijentu\n" +
                                    "1-PONOVNI POKUSAJ\n" +
                                    "2-ODUSTAJANJE OD PRETRAGE KARTONA", unosImePacijenta, unosPrezimePacijenta);
                                    int ponovoProbaj = Convert.ToInt32(Console.ReadLine());
                                    if (ponovoProbaj == 2) break;
                                }
                                else PronadjiUKartonu(klinika17818, karton17818_1);
                            }
                        } while (!postojiPacijent);
                        break;
                    case 5:
                        do
                        {
                            Console.WriteLine("Kojem pacijentu zelite registrovati pregled? Unesite ime...");
                            string unosImePacijenta = Console.ReadLine();
                            Console.WriteLine("Kojem pacijentu zelite registrovati pregled? Unesite prezime...");
                            string unosPrezimePacijenta = Console.ReadLine();
                            foreach (NormalniPacijent pacijent17818_1 in klinika17818.pacijenti)
                                //trazi postoji li taj pacijent
                                if (pacijent17818_1.Ime == unosImePacijenta && pacijent17818_1.Prezime == unosPrezimePacijenta)
                                {
                                    n = pacijent17818_1; //dodjela da ide u funkciju
                                    postojiPacijent = true;
                                    Console.WriteLine("Pronadjen pacijent!");
                                }
                            if (postojiPacijent == false)
                            {
                                Console.WriteLine("Nije pronadjen pacijent {0} {1} pa samim time niti njegov karton.\n" +
                                "1-PONOVNI POKUSAJ\n" +
                                "2-ODUSTAJANJE OD REGISTRACIJE PREGLEDA", unosImePacijenta, unosPrezimePacijenta);
                                int ponovoProbaj = Convert.ToInt32(Console.ReadLine());
                                if (ponovoProbaj == 2) break;
                            }
                            else
                            {
                                foreach (Karton k in klinika17818.kartoniPacijenata)
                                    if (k.Pacijent17818.Ime == unosImePacijenta && k.Pacijent17818.Prezime == unosPrezimePacijenta)
                                    {
                                        karton17818_1 = k;
                                        postojiKartonPacijenta = true;
                                        Console.WriteLine("Pronadjen karton pacijenta!");
                                    }
                                if (postojiKartonPacijenta == false)
                                {
                                    Console.WriteLine("Nije pronadjen karton pacijenta {0} {1}. Provjerite da ste kreirali karton pacijentu\n" +
                                    "1-PONOVNI POKUSAJ\n" +
                                    "2-ODUSTAJANJE OD REGISTRACIJE PREGLEDA", unosImePacijenta, unosPrezimePacijenta);
                                    int ponovoProbaj = Convert.ToInt32(Console.ReadLine());
                                    if (ponovoProbaj == 2) break;
                                }
                                else RegistrujPregledPacijentu(klinika17818, n);
                            }
                        } while (!postojiPacijent);
                        break;
                    case 6:
                        Console.WriteLine("Koju metodu analize poslovanja zelite?\n" +
                            "1-UDIO HITNIH SLUCAJEVA U UKUPNOM BROJU PACIJENATA\n" +
                            "2-NAJPOSJECENIJI DOKTORI U 2017. GODINI\n" +
                            "3-PROSJECNA STAROST PACIJENATA U KLINICI");
                        int izborAnalize = Convert.ToInt32(Console.ReadLine());
                        switch (izborAnalize)
                        {
                            case 1:
                                int brojacHitnih = 0;
                                if (klinika17818.pacijenti.Count == 0) Console.WriteLine("Nema pacijenata pa nije ni moguce analizirati procente");
                                else
                                {
                                    foreach (NormalniPacijent pacijent17818 in klinika17818.pacijenti) brojacHitnih++;
                                    Console.WriteLine("Od ukupno {0} pacijenata, {1} je hitnih, odnosno", klinika17818.pacijenti.Count, brojacHitnih, (brojacHitnih / klinika17818.pacijenti.Count) * 100);
                                }
                                break;
                            case 2:
                                int brojac = 0;
                                if (klinika17818.pregledi.Count == 0) Console.WriteLine("Nema pregleda pa nije ni moguce analizirati procente");
                                else
                                {
                                    foreach (Pregled pregled17818 in klinika17818.pregledi)
                                        if (pregled17818.DatumPregleda1.Year != 2017)
                                        {
                                            Doktor doktor17818_1 = pregled17818.OdgovorniDoktor1;
                                            if (pregled17818.OdgovorniDoktor1.BrojPregledanihPacijenata1 == 0) continue;
                                            pregled17818.OdgovorniDoktor1.BrojPregledanihPacijenata1--;
                                            brojac++;
                                            Console.WriteLine("Doktor {0} je pregledao {1} pacijenata u 2017. godini", doktor17818_1.Prezime1, pregled17818.OdgovorniDoktor1.BrojPregledanihPacijenata1);
                                            pregled17818.OdgovorniDoktor1.BrojPregledanihPacijenata1 += brojac;
                                        }
                                }
                                break;
                            case 3:
                                double sumaGodina = 0;
                                if (klinika17818.pacijenti.Count == 0) Console.WriteLine("Nema pacijenata pa nije ni moguce analizirati prosjecnu starost");
                                else
                                {
                                    foreach (NormalniPacijent pacijent17818 in klinika17818.pacijenti)
                                    {
                                        var danasnjiDatum = DateTime.Today;
                                        var starost = danasnjiDatum.Year - pacijent17818.Datumrodjenja.Year;
                                        if (pacijent17818.Datumrodjenja > danasnjiDatum.AddYears(-starost)) starost--;
                                        sumaGodina += starost;
                                    }
                                    Console.WriteLine("Prosjecna starost pacijenata u klinici je {0} godina", sumaGodina / klinika17818.pacijenti.Count);
                                }
                                break;
                        }
                        break;
                    case 7:
                        do
                        {
                            Console.WriteLine("Kojem pacijentu zelite printati racun? Unesite ime...");
                            string unosImePacijenta = Console.ReadLine();
                            Console.WriteLine("Kojem pacijentu zelite printati racun? Unesite prezime...");
                            string unosPrezimePacijenta = Console.ReadLine();
                            foreach (NormalniPacijent pacijent17818_1 in klinika17818.pacijenti)
                                //trazi postoji li taj pacijent
                                if (pacijent17818_1.Ime == unosImePacijenta && pacijent17818_1.Prezime == unosPrezimePacijenta)
                                {
                                    n = pacijent17818_1; //dodjela da ide u funkciju
                                    postojiPacijent = true;
                                    Console.WriteLine("Pronadjen pacijent!");
                                }
                            if (postojiPacijent == false)
                            {
                                Console.WriteLine("Nije pronadjen pacijent {0} {1} pa samim time niti njegov karton.\n" +
                                "1-PONOVNI POKUSAJ\n" +
                                "2-ODUSTAJANJE OD PRINTANJA RACUNA", unosImePacijenta, unosPrezimePacijenta);
                                int ponovoProbaj = Convert.ToInt32(Console.ReadLine());
                                if (ponovoProbaj == 2) break;
                            }
                            else
                            {
                                foreach (Karton k in klinika17818.kartoniPacijenata)
                                    if (k.Pacijent17818.Ime == unosImePacijenta && k.Pacijent17818.Ime == unosPrezimePacijenta)
                                    {
                                        karton17818_1 = k;
                                        postojiKartonPacijenta = true;
                                        Console.WriteLine("Pronadjen karton pacijenta!");
                                    }
                                if (postojiKartonPacijenta == false)
                                {
                                    Console.WriteLine("Nije pronadjen karton pacijenta {0} {1}. Provjerite da ste kreirali karton pacijentu\n" +
                                    "1-PONOVNI POKUSAJ\n" +
                                    "2-ODUSTAJANJE OD PRINTANJA RACUNA", unosImePacijenta, unosPrezimePacijenta);
                                    int ponovoProbaj = Convert.ToInt32(Console.ReadLine());
                                    if (ponovoProbaj == 2) break;
                                }
                                else DajRacun(klinika17818, n);
                            }
                        } while (!postojiPacijent);
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("Neispravan unos. Pokusajte ponovo.");
                        break;
                }
            } while (izbor != 8);
        }
    }
}
