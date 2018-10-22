using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ne pas oublier d'ajouter cela dans votre projet
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Forms;
using System.ComponentModel;

// Auteur : Fabrice GARCIA ( 20290 BORGO, Haute-Corse. le  14 octobre 2018)
// Vous etes libre d'inclure ce code dans vos programmes.
// Il vous est fournis librement et gratuitement sans aucune responsabilité de ma part.
// Je vous demande seulement de respecter mon droit d'auteur en concervant mon nom
// Vous pouvez aussi m'envoyer un mail de remerciement à fab2bprog@outlook.fr  ca me fera plaisir.

//

namespace WFSaisieExemple
{

    public class ChampAlphaNum
    {
        // Auteur : Fabrice GARCIA ( 20290 BORGO, Haute-Corse. le  14 octobre 2018)

        public TextBox ScanCible;
        public KeyPressEventArgs eKeyPressEvArg;

        string typeCasse = "maj";

        public string TypeCasse
        {
            get { return typeCasse; }
            set { typeCasse = value.ToLower().Trim(); }
        }


        public bool Valide_KeyPress()
        {
            if (char.IsLetter(eKeyPressEvArg.KeyChar))
            {

                if (typeCasse == "maj") eKeyPressEvArg.KeyChar = char.ToUpperInvariant(eKeyPressEvArg.KeyChar);
                if (typeCasse == "min") eKeyPressEvArg.KeyChar = char.ToLowerInvariant(eKeyPressEvArg.KeyChar);

                return true;
            }

            if (char.IsDigit(eKeyPressEvArg.KeyChar)) return true;
            if (char.IsControl(eKeyPressEvArg.KeyChar)) return true;

            eKeyPressEvArg.Handled = true;
            return false;
        }

        public bool Valide_TextChanged()
        {

            if (ScanCible.Text.Length == 0) return true;

            if (typeCasse == "maj") ScanCible.Text = ScanCible.Text.ToUpper().Trim();
            if (typeCasse == "min") ScanCible.Text = ScanCible.Text.ToLower().Trim();

            foreach (char character in (ScanCible.Text.ToArray()))
            {
                if (!char.IsDigit(character) && !char.IsLetter(character))
                {
                    ScanCible.Text = string.Empty;
                    return false;
                }
            }

            return true;

        }

    }
    public class ChampHexa

    {
        // Auteur : Fabrice GARCIA ( 20290 BORGO, Haute-Corse. le  14 octobre 2018)

        public TextBox ScanCible;
        public KeyPressEventArgs eKeyPressEvArg;

        string typeCasse = "maj";

        char[] CaractAutorise = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'a', 'b', 'c', 'd', 'e', 'f' };


        public string TypeCasse
        {
            get { return typeCasse; }
            set { typeCasse = value.ToLower().Trim(); }
        }


        public bool Valide_KeyPress()
        {

            if (CaractAutorise.Contains(eKeyPressEvArg.KeyChar))
            {

                switch (typeCasse)
                {
                    case "min":
                        eKeyPressEvArg.KeyChar = char.ToLowerInvariant(eKeyPressEvArg.KeyChar);
                        break;

                    default:
                        eKeyPressEvArg.KeyChar = char.ToUpperInvariant(eKeyPressEvArg.KeyChar);
                        break;

                }

                return true;

            }

            eKeyPressEvArg.Handled = true;
            return false;

        }

        public bool Valide_TextChanged()
        {

            if (ScanCible.Text.Length == 0) return true;

            switch (typeCasse)
            {
                case "min":
                    ScanCible.Text = ScanCible.Text.ToLower().Trim();
                    break;

                default:
                    ScanCible.Text = ScanCible.Text.ToUpper().Trim();
                    break;

            }

            foreach (char character in (ScanCible.Text.ToArray()))
            {
                if (!CaractAutorise.Contains(character))
                {
                    ScanCible.Text = string.Empty;
                    return false;
                }
            }

            return true;

        }

    }
    public class ChampEntier

    {

        // Auteur : Fabrice GARCIA ( 20290 BORGO, Haute-Corse. le  14 octobre 2018)

        public TextBox ScanCible;
        public KeyPressEventArgs eKeyPressEvArg;

        char[] CaractAutorise = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-' };
        int valMin = int.MinValue;
        int valMax = int.MaxValue;

        public int ValMin
        {
            get { return valMin; }
            set { valMin = value; }
        }

        public int ValMax
        {
            get { return valMax; }
            set { valMax = value; }
        }

        public bool Valide_KeyPress()
        {

            Int32 PosCurseur = ScanCible.SelectionStart;
            int ResultConv;

            if (char.IsControl(eKeyPressEvArg.KeyChar)) return true;
            if (char.IsDigit(eKeyPressEvArg.KeyChar))
            {

                int.TryParse(ScanCible.Text, out ResultConv);
                if (PosCurseur == 0 && ResultConv < 0)
                {
                    ScanCible.SelectionStart = ScanCible.Text.Length;
                    return true;
                }

                return true;

            }

            if (eKeyPressEvArg.KeyChar == '-')
            {
                int.TryParse(ScanCible.Text, out ResultConv);
                ResultConv = ResultConv * -1;
                if (ResultConv < valMin) { ResultConv = valMin; }
                if (ResultConv > valMax) { ResultConv = valMax; }
                ScanCible.Text = ResultConv.ToString();
                ScanCible.SelectionStart = ScanCible.Text.Length;
                eKeyPressEvArg.Handled = true;
                return true;
            }

            eKeyPressEvArg.Handled = true;
            return false;

        }

        public bool Valide_TextChanged()
        {

            int nbsigne = 0;

            char[] CaractAutorise = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-' };
            ScanCible.Text = ScanCible.Text.Trim();

            if (ScanCible.Text.Length == 0) return true;

            if (ScanCible.Text.LastIndexOf('-') > 0)
            {
                ScanCible.Text = string.Empty;
                return false;
            }

            foreach (char character in (ScanCible.Text.ToArray()))
            {
                if (character == '-') { nbsigne++; }

                if (!CaractAutorise.Contains(character) || nbsigne > 1)
                {
                    ScanCible.Text = string.Empty;
                    return false;
                }

            }




            int.TryParse(ScanCible.Text, out int ResultConv);
            if (ResultConv < valMin) { ResultConv = valMin; ScanCible.Text = ResultConv.ToString(); }
            if (ResultConv > valMax) { ResultConv = valMax; ScanCible.Text = ResultConv.ToString(); }


            return true;

        }

        public bool Valide_Leave()
        {


            if (ScanCible.Text.Length == 0)
            {
                return true;
            }

            int.TryParse(ScanCible.Text, out int ResultConv);
            if (ResultConv < valMin) { ResultConv = valMin; }
            if (ResultConv > valMax) { ResultConv = valMax; }
            ScanCible.Text = ResultConv.ToString();

            return true;

        }

    }
    public class ChampEMail
    {

        // Auteur : Fabrice GARCIA ( 20290 BORGO, Haute-Corse. le  14 octobre 2018)

        public TextBox ScanCible;
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

        public bool Valide_LostFocus()
        {
            ScanCible.Text = ScanCible.Text.Trim();
            if (ScanCible.Text.Length == 0) return true;
            if (Regex.IsMatch(ScanCible.Text, pattern)) return true;

            return false;
        }


    }
    public class ChampDecimal
    {
        // Auteur : Fabrice GARCIA ( 20290 BORGO, Haute-Corse. le  14 octobre 2018)

        public TextBox ScanCible;
        public KeyPressEventArgs eKeyPressEvArg;
        public int nbrDecim = 5;
        double valMin = double.MinValue;
        double valMax = double.MaxValue;
        Char Separateur = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];


        public int NbrDecim
        {
            get { return nbrDecim; }
            set { nbrDecim = Math.Abs(value); }
        }

        public double ValMin
        {
            get { return valMin; }
            set { valMin = value; }
        }

        public double ValMax
        {
            get { return valMax; }
            set { valMax = value; }
        }



        public bool Valide_KeyPress()
        {

            Int32 PosSeparateur = ScanCible.Text.IndexOf(Separateur);
            Int32 PosCurseur = ScanCible.SelectionStart;
            double ResultConv;

            if (char.IsDigit(eKeyPressEvArg.KeyChar))
            {

                Double.TryParse(ScanCible.Text, out ResultConv);
                if (PosCurseur == 0 && ResultConv < 0)
                {
                    ScanCible.SelectionStart = ScanCible.Text.Length;
                    return true;
                }

                return true;

            }

            if (eKeyPressEvArg.KeyChar == (char)8) return true;

            if (eKeyPressEvArg.KeyChar == '.' || eKeyPressEvArg.KeyChar == ',')
            {
                eKeyPressEvArg.KeyChar = Separateur;

                if (PosSeparateur == -1 && ScanCible.Text.Length > 0 && PosCurseur > 0) { return true; }
                if (ScanCible.Text.Length == 0 || ScanCible.SelectionLength == ScanCible.Text.Length)
                {
                    ScanCible.Text = "0" + Separateur;
                    ScanCible.SelectionStart = 2;
                    eKeyPressEvArg.Handled = true;
                    return false;
                }

                if (PosSeparateur == -1 && ScanCible.Text.Length > 0 && PosCurseur == 0)
                {
                    ScanCible.Text = "0" + Separateur + ScanCible.Text;
                    ScanCible.SelectionStart = 2;
                    eKeyPressEvArg.Handled = true;
                    return false;
                }

                if (ScanCible.SelectedText.Contains(Separateur))
                {
                    ScanCible.SelectedText = Separateur.ToString();
                    eKeyPressEvArg.Handled = true;
                    return false;
                }



            }

            if (eKeyPressEvArg.KeyChar == '-')
            {
                Double.TryParse(ScanCible.Text, out ResultConv);
                ResultConv = ResultConv * -1;
                if (ResultConv < valMin) { ResultConv = valMin; }
                if (ResultConv > valMax) { ResultConv = valMax; }
                ScanCible.Text = ResultConv.ToString();
                ScanCible.SelectionStart = ScanCible.Text.Length;
                eKeyPressEvArg.Handled = true;
                return true;
            }

            eKeyPressEvArg.Handled = true;
            return false;

        }

        public bool Valide_KeyUp()
        {

            if (ScanCible.Text == Separateur.ToString())
            {
                ScanCible.Text = "";
                return false;
            }

            Double.TryParse(ScanCible.Text, out double ResultConv);
            if (ResultConv < valMin) { ResultConv = valMin; ScanCible.Text = ResultConv.ToString(); }
            if (ResultConv > valMax) { ResultConv = valMax; ScanCible.Text = ResultConv.ToString(); }

            return true;

        }

        public bool Valide_LeaveFocus()
        {


            if (ScanCible.Text.Length == 0)
            {
                return true;
            }

            if (ScanCible.Text == Separateur.ToString())
            {
                ScanCible.Text = "";
                return false;
            }

            Double.TryParse(ScanCible.Text, out double ResultConv);
            ResultConv = Math.Round(ResultConv, nbrDecim);
            if (ResultConv < valMin) { ResultConv = valMin; }
            if (ResultConv > valMax) { ResultConv = valMax; }
            ScanCible.Text = ResultConv.ToString();

            return true;

        }

        public bool Valide_TextChanged()
        {

            char[] CaractAutorise = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.', ',', '-' };
            ScanCible.Text = ScanCible.Text.Trim();

            if (ScanCible.Text.Length == 0)
            {
                return true;
            }

            foreach (char character in (ScanCible.Text.ToArray()))
            {
                if (!CaractAutorise.Contains(character))
                {
                    ScanCible.Text = "";
                    return false;
                }
            }

            return true;

        }

    }
    public class ChampMonetaire
    {
        // Auteur : Fabrice GARCIA ( 20290 BORGO, Haute-Corse. le  14 octobre 2018)

        public TextBox ScanCible;
        public KeyPressEventArgs eKeyPressEvArg;

        double valMin = double.MinValue;
        double valMax = double.MaxValue;

        public double ValMin
        {
            get { return valMin; }
            set { valMin = value; }
        }

        public double ValMax
        {
            get { return valMax; }
            set { valMax = value; }
        }

        public bool Valide_Enter()
        {
            char[] CaractAutorise = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.', ',', '-' };

            if (ScanCible.Text.Length == 0)
            {
                return true;
            }

            foreach (char character in (ScanCible.Text.ToArray()))
            {
                if (!CaractAutorise.Contains(character))
                {
                    ScanCible.Text = ScanCible.Text.Replace(character.ToString(), string.Empty);

                }
            }

            Double.TryParse(ScanCible.Text, out Double ResultConv);
            ScanCible.Text = ResultConv.ToString();
            return true;

        }

        public bool Valide_KeyPress()
        {
            Char Separateur = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            Int32 PosSeparateur = ScanCible.Text.IndexOf(Separateur);
            Int32 PosCurseur = ScanCible.SelectionStart;
            double ResultConv;


            if (char.IsDigit(eKeyPressEvArg.KeyChar))
            {

                Double.TryParse(ScanCible.Text, out ResultConv);
                if (PosCurseur == 0 && ResultConv < 0)
                {
                    ScanCible.SelectionStart = ScanCible.Text.Length;
                    return true;
                }

                return true;

            }

            if (eKeyPressEvArg.KeyChar == (char)8) { return true; }

            if (eKeyPressEvArg.KeyChar == '.' || eKeyPressEvArg.KeyChar == ',')
            {
                eKeyPressEvArg.KeyChar = Separateur;

                if (PosSeparateur == -1 && ScanCible.Text.Length > 0 && PosCurseur > 0) { return true; }
                if (ScanCible.Text.Length == 0 || ScanCible.SelectionLength == ScanCible.Text.Length)
                {
                    ScanCible.Text = "0" + Separateur;
                    ScanCible.SelectionStart = 2;
                    eKeyPressEvArg.Handled = true;
                    return false;
                }

                if (PosSeparateur == -1 && ScanCible.Text.Length > 0 && PosCurseur == 0)
                {
                    ScanCible.Text = "0" + Separateur + ScanCible.Text;
                    ScanCible.SelectionStart = 2;
                    eKeyPressEvArg.Handled = true;
                    return false;
                }

                if (ScanCible.SelectedText.Contains(Separateur))
                {
                    ScanCible.SelectedText = Separateur.ToString();
                    eKeyPressEvArg.Handled = true;
                    return false;
                }



            }

            if (eKeyPressEvArg.KeyChar == '-')
            {
                Double.TryParse(ScanCible.Text, out ResultConv);
                ResultConv = ResultConv * -1;
                if (ResultConv < valMin) { ResultConv = valMin; }
                if (ResultConv > valMax) { ResultConv = valMax; }
                ScanCible.Text = ResultConv.ToString();
                ScanCible.SelectionStart = ScanCible.Text.Length;
                eKeyPressEvArg.Handled = true;
                return true;
            }

            eKeyPressEvArg.Handled = true;
            return false;

        }

        public bool Valide_Leave()
        {

            Char Separateur = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];

            if (ScanCible.Text.Length == 0)
            {
                return true;
            }

            if (ScanCible.Text == Separateur.ToString())
            {
                ScanCible.Text = "";
                return true;
            }

            Double.TryParse(ScanCible.Text, out Double ResultConv);
            ResultConv = Math.Round(ResultConv, 2);
            if (ResultConv < valMin) { ResultConv = valMin; }
            if (ResultConv > valMax) { ResultConv = valMax; }
            ScanCible.Text = ResultConv.ToString("C");

            return true;

        }

    }
    public class ChampDate

    {

        // Auteur : Fabrice GARCIA ( 20290 BORGO, Haute-Corse. le  14 octobre 2018)

        public TextBox ScanCible;
        public KeyPressEventArgs eKeyPressEvArg;
        public CancelEventArgs eCancelEvArgs;

        bool verbose = true;
        bool corrigeLimite = true;
        bool corrigeCoherence = true;

        DateTime dateMin;
        DateTime dateMax;

        public ChampDate()
        {
            DateTime.TryParse("01/01/1900", out dateMin);
            DateTime.TryParse("31/12/9999", out dateMax);
        }

        public DateTime DateMin
        {
            get { return dateMin; }
            set { dateMin = value; }
        }

        public DateTime DateMax
        {
            get { return dateMax; }
            set { dateMax = value; }
        }

        public bool CorrigeLimite
        {
            get { return corrigeLimite; }
            set { corrigeLimite = value; }
        }

        public bool CorrigeCoherence
        {
            get { return corrigeCoherence; }
            set { corrigeCoherence = value; }
        }

        public bool Verbose
        {
            get { return verbose; }
            set { verbose = value; }
        }

        public bool Valide_KeyPress()
        {

            var dateSep = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.DateSeparator;
            eKeyPressEvArg.Handled = !(Char.IsDigit(eKeyPressEvArg.KeyChar) ||
                        (dateSep.IndexOf(eKeyPressEvArg.KeyChar) > -1) ||
                        Char.IsControl(eKeyPressEvArg.KeyChar));

            return true;

        }

        public bool Valide_Validating()
        {

            if (!DateEst_Coherente())
            {
                if (corrigeCoherence)
                {
                    if (!Corrige_Saisie())
                    {
                        if (verbose)
                        {
                            Aff_Erreur("Le Format de la date doit etre de type JJ/MM/AAAA (Jour/Mois/An)");
                        }
                        eCancelEvArgs.Cancel = true;
                        return false;
                    };
                }
                else
                {
                    eCancelEvArgs.Cancel = true;
                    return false;
                }

            }

            if (!DateDans_Limite())
            {
                if (corrigeLimite)
                {
                    if (!Corrige_SaisieLimite())
                    {
                        if (verbose)
                        {
                            Aff_Erreur("La date [ " + ScanCible.Text + " ] n'est pas située dans une periode valide");
                        }
                        eCancelEvArgs.Cancel = true;
                        return false;
                    };

                }
                else
                {
                    eCancelEvArgs.Cancel = true;
                    return false;
                }

            }

            MiseEnForme_Saisie();
            return true;

        }



        private bool DateEst_Coherente()
        {

            Regex reg = new Regex(@"^(\d{1,2})/(\d{1,2})/(\d{1,4})$");
            Match m = reg.Match(ScanCible.Text);

            if (!m.Success) { return false; }

            int jj = int.Parse(m.Groups[1].Value);
            int mm = int.Parse(m.Groups[2].Value);
            int aaaa = int.Parse(m.Groups[3].Value);

            if (aaaa <= 0) { return false; }
            if (mm < 1 || mm > 12) { return false; }

            if (jj < 1) { return false; }
            if (jj > DateTime.DaysInMonth(aaaa, mm)) { return false; }

            return true;

        }

        private bool MiseEnForme_Saisie()
        {

            Regex reg = new Regex(@"^(\d{1,2})/(\d{1,2})/(\d{1,4})$");
            Match m = reg.Match(ScanCible.Text);

            if (!m.Success)
            {
                return false;
            }

            int jj = int.Parse(m.Groups[1].Value);
            int mm = int.Parse(m.Groups[2].Value);
            int aaaa = int.Parse(m.Groups[3].Value);

            if (aaaa <= 0) { aaaa = 2000; }
            if (aaaa < 100) { aaaa = 2000 + aaaa; }
            if (aaaa < 1900) { aaaa = 1900; }

            if (DateTime.TryParse(jj + "/" + mm + "/" + aaaa, out DateTime DateMiseEnForme))
            {
                ScanCible.Text = DateMiseEnForme.ToString("dd/MM/yyyy");
            }
            else
            {
                return false;
            }

            return true;

        }

        private bool Corrige_Saisie(bool OnErrorAlignAujour = false)
        {

            Regex reg = new Regex(@"^(\d{1,2})/(\d{1,2})/(\d{1,4})$");
            Match m = reg.Match(ScanCible.Text);

            if (!m.Success)
            {
                if (OnErrorAlignAujour)
                {
                    ScanCible.Text = DateTime.Today.ToString("dd/MM/yyyy");
                    return true;
                }
                else
                {
                    return false;
                }
            }

            int jj = int.Parse(m.Groups[1].Value);
            int mm = int.Parse(m.Groups[2].Value);
            int aaaa = int.Parse(m.Groups[3].Value);

            if (aaaa <= 0) { aaaa = 2000; }
            if (aaaa < 100) { aaaa = 2000 + aaaa; }
            if (aaaa < 1900) { aaaa = 1900; }

            if (mm < 1) { mm = 1; }
            if (mm > 12) { mm = 12; }

            if (jj < 1) { jj = 1; }
            if (jj > DateTime.DaysInMonth(aaaa, mm))
            {
                jj = DateTime.DaysInMonth(aaaa, mm);
            };



            if (DateTime.TryParse(jj + "/" + mm + "/" + aaaa, out DateTime DateCorrecte))
            {
                ScanCible.Text = DateCorrecte.ToString("dd/MM/yyyy");
            }
            else
            {
                ScanCible.Text = DateTime.Today.ToString("dd/MM/yyyy");
            }

            return true;

        }

        private bool Corrige_SaisieLimite(string OnErrorAlign = "")
        {
            if (!DateTime.TryParse(ScanCible.Text, out DateTime dateval))
            {
                if (OnErrorAlign == "min")
                {
                    ScanCible.Text = DateMin.ToString("dd/MM/yyyy");
                    return true;
                }

                if (OnErrorAlign == "max")
                {
                    ScanCible.Text = DateMax.ToString("dd/MM/yyyy");
                    return true;
                }

                return false;

            }

            if (DateTime.Compare(dateval, DateMin) < 0) { ScanCible.Text = DateMin.ToString("dd/MM/yyyy"); return true; }
            if (DateTime.Compare(dateval, DateMax) > 0) { ScanCible.Text = DateMax.ToString("dd/MM/yyyy"); return true; }

            return true;

        }

        private bool DateDans_Limite()
        {
            if (!DateTime.TryParse(ScanCible.Text, out DateTime dateval)) { return false; }

            if (DateTime.Compare(dateval, DateMin) < 0) { return false; }
            if (DateTime.Compare(dateval, DateMax) > 0) { return false; }

            return true;
        }



        private bool Aff_Erreur(string contenu = "Date Invalide")
        {
            if (verbose)
            {
                if (MessageBox.Show(contenu, "Date invalide", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    return true;
            }

            return false;
        }


    }
    public class ChampHeure

    {

        // Auteur : Fabrice GARCIA ( 20290 BORGO, Haute-Corse. le  14 octobre 2018)

        public TextBox ScanCible;
        public KeyPressEventArgs eKeyPressEvArg;

        char[] CaractAutorise = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ':' };
        Char Separateur = ':';

        public bool Valide_KeyPress()
        {

            Int32 PosSeparateur = ScanCible.Text.IndexOf(Separateur);
            Int32 PosCurseur = ScanCible.SelectionStart;

            int ResultConv;

            if (char.IsControl(eKeyPressEvArg.KeyChar)) return true;
            if (char.IsDigit(eKeyPressEvArg.KeyChar))
            {

                int.TryParse(ScanCible.Text, out ResultConv);
                if (PosCurseur == 0 && ResultConv < 0)
                {
                    ScanCible.SelectionStart = ScanCible.Text.Length;
                    return true;
                }




                return true;

            }

            if (
                   eKeyPressEvArg.KeyChar == ':'
                || eKeyPressEvArg.KeyChar == 'h'
                || eKeyPressEvArg.KeyChar == 'H'
                || eKeyPressEvArg.KeyChar == '.'
                || eKeyPressEvArg.KeyChar == ','
                || eKeyPressEvArg.KeyChar == Separateur
                 )

            {
                eKeyPressEvArg.KeyChar = Separateur;

                if (PosSeparateur == -1 && ScanCible.Text.Length > 0 && PosCurseur > 0) { return true; }
                if (ScanCible.Text.Length == 0 || ScanCible.SelectionLength == ScanCible.Text.Length)
                {
                    ScanCible.Text = "00" + Separateur;
                    ScanCible.SelectionStart = 3;
                    eKeyPressEvArg.Handled = true;
                    return false;
                }

                if (PosSeparateur == -1 && ScanCible.Text.Length > 0 && PosCurseur == 0)
                {
                    ScanCible.Text = "00" + Separateur + ScanCible.Text;
                    ScanCible.SelectionStart = 2;
                    eKeyPressEvArg.Handled = true;
                    return false;
                }

                if (ScanCible.SelectedText.Contains(Separateur))
                {
                    ScanCible.SelectedText = Separateur.ToString();
                    eKeyPressEvArg.Handled = true;
                    return false;
                }



            }

            eKeyPressEvArg.Handled = true;
            return false;

        }

        public bool Valide_TextChanged()
        {

            int nbsigne = 0;

            char[] CaractAutorise = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ':' };
            ScanCible.Text = ScanCible.Text.Trim();

            if (ScanCible.Text.Length == 0) return true;

            //if (ScanCible.Text.LastIndexOf(':') > 1)
            //{
            //    ScanCible.Text = string.Empty;
            //    return false;
            //}

            foreach (char character in (ScanCible.Text.ToArray()))
            {
                if (character == ':') { nbsigne++; }

                if (!CaractAutorise.Contains(character) || nbsigne > 1)
                {
                    ScanCible.Text = string.Empty;
                    return false;
                }

            }


            return true;

        }

        public bool Valide_Leave()
        {


            if (ScanCible.Text.Length == 0)
            {
                return true;
            }

            ScanCible.Text = Corrige_Temps();

            return true;

        }



        private string Corrige_Temps()
        {
            string hh, mm;

            if (ScanCible.Text.LastIndexOf(Separateur) < 0 && ScanCible.Text.Length == 4)
            {

                hh = ScanCible.Text;
                hh = hh.Substring(0, 2);

                mm = ScanCible.Text;
                mm = mm.Substring(2, 2);

                ScanCible.Text = hh + Separateur + mm;

            }

            if (ScanCible.Text.LastIndexOf(Separateur) < 0 && ScanCible.Text.Length == 2)
            {

                hh = ScanCible.Text;
                hh = hh.Substring(0, 2);

                mm = "00";

                ScanCible.Text = hh + Separateur + mm;

            }

            hh = "00" + Extract_Heures();
            hh = hh.Substring(hh.Length - 2, 2);

            mm = "00" + Extract_Minutes();
            mm = mm.Substring(mm.Length - 2, 2);

            return hh + Separateur + mm;


        }

        private int Extract_Heures()
        {

            Regex reg = new Regex(@"^(\d{1,2})" + Separateur + @"(\d{1,2})$");
            Match m = reg.Match(ScanCible.Text);

            if (!m.Success) { return 0; }

            int hh = int.Parse(m.Groups[1].Value);

            if (hh < 0) { return 0; }
            if (hh > 23) { return 23; }

            return hh;

        }

        private int Extract_Minutes()
        {

            Regex reg = new Regex(@"^(\d{1,2})" + Separateur + @"(\d{1,2})$");
            Match m = reg.Match(ScanCible.Text);

            if (!m.Success) { return 0; }

            int mm = int.Parse(m.Groups[2].Value);

            if (mm < 0) { return 0; }
            if (mm > 59) { return 59; }


            return mm;

        }


    }


}
