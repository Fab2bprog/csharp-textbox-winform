using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Auteur : Fabrice GARCIA ( 20290 BORGO, Haute-Corse. le  14 octobre 2018)
// Vous etes libre d'inclure ce code dans vos programmes.
// Il vous est fournis librement et gratuitement sans aucune responsabilité de ma part.
// Je vous demande seulement de respecter mon droit d'auteur en concervant mon nom
// Vous pouvez aussi m'envoyer un mail de remerciement à fab2bprog@outlook.fr  ca me fera plaisir.



namespace WFSaisieExemple
{
    public partial class Win_Exemple : Form
    {
        public Win_Exemple()
        {
            InitializeComponent();
        }

        //---[EVENEMENTS:Txt_Code]--------------------------------------------------------
        //IMPORTANT :  Doit etre integré DEUX aux types d'evenements suivant pour etre correctement géré et etre a l'abris des comportement utilisateurs 
        private void Txt_Code_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChampAlphaNum monCode = new ChampAlphaNum();
            monCode.ScanCible = (TextBox)sender;
            monCode.eKeyPressEvArg = (KeyPressEventArgs)e;
            monCode.Valide_KeyPress();
        }

        private void Txt_Code_TextChanged(object sender, EventArgs e)
        {
            ChampAlphaNum monCode = new ChampAlphaNum();
            monCode.ScanCible = (TextBox)sender;
            monCode.Valide_TextChanged();
        }

        //---[EVENEMENTS:Txt_CodeLower]--------------------------------------------------------
        //IMPORTANT :  Doit etre integré aux DEUX types d'evenements suivant pour etre correctement géré et etre a l'abris des comportement utilisateurs 
        private void Txt_CodeLower_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChampAlphaNum monCode = new ChampAlphaNum();
            monCode.ScanCible = (TextBox)sender;
            monCode.eKeyPressEvArg = (KeyPressEventArgs)e;
            monCode.TypeCasse = "min";
            monCode.Valide_KeyPress();
        }

        private void Txt_CodeLower_TextChanged(object sender, EventArgs e)
        {
            ChampAlphaNum monCode = new ChampAlphaNum();
            monCode.ScanCible = (TextBox)sender;
            monCode.TypeCasse = "min";
            monCode.Valide_TextChanged();
        }

        //---[EVENEMENTS:Txt_Int]--------------------------------------------------------
        //IMPORTANT :  Doit etre integré aux TROIS types d'evenements suivant pour etre correctement géré et etre a l'abris des comportement utilisateurs 
        private void Txt_Int_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChampEntier monCode = new ChampEntier();
            monCode.ScanCible = (TextBox)sender;
            monCode.eKeyPressEvArg = (KeyPressEventArgs)e;
            monCode.Valide_KeyPress();
        }

        private void Txt_Int_TextChanged(object sender, EventArgs e)
        {
            ChampEntier monCode = new ChampEntier();
            monCode.ScanCible = (TextBox)sender;
            monCode.Valide_TextChanged();
        }

        private void Txt_Int_Leave(object sender, EventArgs e)
        {
            ChampEntier monCode = new ChampEntier();
            monCode.ScanCible = (TextBox)sender;
            monCode.Valide_Leave();
        }

        //---[EVENEMENTS:Txt_IntLimit]--------------------------------------------------------
        // LIMITATION de la valeur avec blocage entre 0 et 100 dans l'exemple en utilisant la propriété de l'objet valmin et valmax.
        //IMPORTANT :  Doit etre integré aux TROIS types d'evenements suivant pour etre correctement géré et etre a l'abris des comportement utilisateurs 
        private void Txt_IntLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChampEntier monCode = new ChampEntier();
            monCode.ScanCible = (TextBox)sender;
            monCode.eKeyPressEvArg = (KeyPressEventArgs)e;
            monCode.ValMin = 0;
            monCode.ValMax = 100;
            monCode.Valide_KeyPress();
        }

        private void Txt_IntLimit_TextChanged(object sender, EventArgs e)
        {
            ChampEntier monCode = new ChampEntier();
            monCode.ScanCible = (TextBox)sender;
            monCode.ValMin = 0;
            monCode.ValMax = 100;
            monCode.Valide_TextChanged();
        }

        private void Txt_IntLimit_Leave(object sender, EventArgs e)
        {
            ChampEntier monCode = new ChampEntier();
            monCode.ScanCible = (TextBox)sender;
            monCode.ValMin = 0;
            monCode.ValMax = 100;
            monCode.Valide_Leave();
        }

        //---[EVENEMENTS:Txt_NumHexa]--------------------------------------------------------
        //IMPORTANT :  Doit etre integré aux DEUX types d'evenements suivant pour etre correctement géré et etre a l'abris des comportement utilisateurs 
        private void Txt_NumHexa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChampHexa monCode = new ChampHexa();
            monCode.ScanCible = (TextBox)sender;
            monCode.eKeyPressEvArg = (KeyPressEventArgs)e;
            monCode.Valide_KeyPress();
        }

        private void Txt_NumHexa_TextChanged(object sender, EventArgs e)
        {
            ChampHexa monCode = new ChampHexa();
            monCode.ScanCible = (TextBox)sender;
            monCode.Valide_TextChanged();
        }

        //---[EVENEMENTS:Txt_Decim]--------------------------------------------------------
        //IMPORTANT :  Doit etre integré aux QUATRE types d'evenements suivant pour etre correctement géré et etre a l'abris des comportement utilisateurs 
        // On peut limiter la valeur avec blocage entre X et Y en utilisant la propriété de l'objet valmin et valmax (voir exemple pour les nombre entier ).
        // On peut limiter le nombre de decimal en utilisant la propriété NbrDecim (exemple moncode.NbrDecim = 3)

        private void Txt_Decim_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChampDecimal monCode = new ChampDecimal();
            monCode.ScanCible = (TextBox)sender;
            monCode.eKeyPressEvArg = (KeyPressEventArgs)e;
            monCode.Valide_KeyPress();
            
        }

        private void Txt_Decim_KeyUp(object sender, KeyEventArgs e)
        {
            ChampDecimal monCode = new ChampDecimal();
            monCode.ScanCible = (TextBox)sender;
            monCode.Valide_KeyUp();
        }

        private void Txt_Decim_LeaveFocus(object sender, EventArgs e)
        {
            ChampDecimal monCode = new ChampDecimal();
            monCode.ScanCible = (TextBox)sender;
            monCode.Valide_LeaveFocus();
      
        }

        private void Txt_Decim_TextChanged(object sender, EventArgs e)
        {
            ChampDecimal monCode = new ChampDecimal();
            monCode.ScanCible = (TextBox)sender;
            monCode.Valide_TextChanged();
        }

        //---[EVENEMENTS:Txt_Monetaire]--------------------------------------------------------
        //IMPORTANT :  Doit etre integré aux TROIS types d'evenements suivant pour etre correctement géré et etre a l'abris des comportement utilisateurs 
        // On peut limiter la valeur avec blocage entre X et Y en utilisant la propriété de l'objet valmin et valmax (voir exemple pour les nombre entier ).
        private void Txt_Monetaire_Enter(object sender, EventArgs e)
        {
            ChampMonetaire monCode = new ChampMonetaire();
            monCode.ScanCible = (TextBox)sender;
            monCode.Valide_Enter();
        }

        private void Txt_Monetaire_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChampMonetaire monCode = new ChampMonetaire();
            monCode.ScanCible = (TextBox)sender;
            monCode.eKeyPressEvArg = (KeyPressEventArgs)e;
            monCode.Valide_KeyPress();
        }

        private void Txt_Monetaire_Leave(object sender, EventArgs e)
        {
            ChampMonetaire monCode = new ChampMonetaire();
            monCode.ScanCible = (TextBox)sender;
            monCode.Valide_Leave();


        }

        //---[EVENEMENTS:Txt_Date]--------------------------------------------------------
        // Le code corrige automatiquement les dates erronnées
        //IMPORTANT :  Doit etre integré aux DEUX types d'evenements suivant pour etre correctement géré et etre a l'abris des comportement utilisateurs 
        // Pour info la propriete MaxLength de la textbox a été limité à 10 caracteres dans l'interface graphique , mais ce n'est pas une obligation
        private void Txt_Date_Validating(object sender, CancelEventArgs e)
        {
            ChampDate monCode = new ChampDate();
            monCode.ScanCible = (TextBox)sender;
            monCode.eCancelEvArgs = (CancelEventArgs)e;
            monCode.Valide_Validating();

        }

        private void Txt_Date_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChampDate monCode = new ChampDate();
            monCode.ScanCible = (TextBox)sender;
            monCode.eKeyPressEvArg = (KeyPressEventArgs)e;
            monCode.Valide_KeyPress();
        }

        //---[EVENEMENTS:Txt_Heure]-------------------------------------------------------------------
        //IMPORTANT :  Doit etre integré aux TROIS types d'evenements suivant pour etre correctement géré et etre a l'abris des comportement utilisateurs 
        // Pour info la propriete MaxLength de la textbox a été limité à 5 caracteres dans l'interface graphique , mais ce n'est pas une obligation.
        private void Txt_Heure_TextChanged(object sender, EventArgs e)
        {
            ChampHeure monCode = new ChampHeure();
            monCode.ScanCible = (TextBox)sender;
            monCode.Valide_TextChanged();

        }

        private void Txt_Heure_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChampHeure monCode = new ChampHeure();
            monCode.ScanCible = (TextBox)sender;
            monCode.eKeyPressEvArg = (KeyPressEventArgs)e;
            monCode.Valide_KeyPress();
        }

        private void Txt_Heure_Leave(object sender, EventArgs e)
        {
            ChampHeure monCode = new ChampHeure();
            monCode.ScanCible = (TextBox)sender;
            monCode.Valide_Leave();
        }

        //---[EVENEMENTS:Txt_Email]--------------------------------------------------------
        // IMPORTANT : Doit etre integré a ce type d'evenements suivant pour etre correctement géré et etre a l'abris des comportement utilisateurs 

        private void Txt_Email_LostFocus(object sender, EventArgs e)
        {
            ChampEMail monCode = new ChampEMail();
            monCode.ScanCible = (TextBox)sender;
            if (monCode.Valide_LostFocus()) return;

            MessageBox.Show("Email Non valide", "Adresse Email invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
            monCode.ScanCible.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Win_Exemple_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Date_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
