using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Author: Fabrice GARCIA (20290 BORGO, Haute-Corse, France. October 14, 2018)
// You are free to include this code in your programs.
// It is provided to you freely and free of charge without any liability on my part.
// I only ask you to respect my copyright by keeping my name
// You can also send me a thank you email to fab2bprog@outlook.fr that will make me happy.



namespace WFSaisieExemple
{
    public partial class Win_Exemple : Form
    {
        public Win_Exemple()
        {
            InitializeComponent();
        }

        // --- [EVENTS: Txt_Code] ---------------------------------------- ----------------
        // IMPORTANT: Must be integrated TWO in the following types of events to be correctly managed and to be safe from user behavior
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

        // --- [EVENTS: Txt_CodeLower] ---------------------------------------- ----------------
        // IMPORTANT: Must be integrated into the following TWO types of events to be properly managed and to be safe from user behavior
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

        // --- [EVENTS: Txt_Int] ---------------------------------------- ----------------
        // IMPORTANT: Must be included in the following THREE types of events to be properly managed and to be safe from user behavior
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

        // --- [EVENTS: Txt_IntLimit] ---------------------------------------- ----------------
        // LIMIT the value with blocking between 0 and 100 in the example using the object property valmin and valmax.
        // IMPORTANT: Must be included in the following THREE types of events to be properly managed and to be safe from user behavior
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

        // --- [EVENTS: Txt_NumHexa] ---------------------------------------- ----------------
        // IMPORTANT: Must be integrated into the following TWO types of events to be properly managed and to be safe from user behavior
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

        // --- [EVENTS: Txt_Decim] ---------------------------------------- ----------------
        // IMPORTANT: Must be integrated into the following FOUR types of events to be properly managed and to be safe from user behavior
        // We can limit the value with blocking between X and Y using the property of the object valmin and valmax (see example for integers).
        // We can limit the number of decimal by using the NbrDecim property (example mycode.NbrDecim = 3)

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

        // --- [EVENTS: Txt_Monetaire] ---------------------------------------- ----------------
        // IMPORTANT: Must be included in the following THREE types of events to be properly managed and to be safe from user behavior
        // We can limit the value with blocking between X and Y using the property of the object valmin and valmax (see example for integers).
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

        // --- [EVENTS: Txt_Date] ---------------------------------------- ----------------
        // USE A MASKEDTEXTBOX AND NOT A TEXTBOX
        // IMPORTANT: Must be integrated into the following TWO types of events to be properly managed and to be safe from user behavior
        // For info the MaxLength property of the MaskedTextBox has been limited to 10 characters in the graphical interface, but it is not an obligation
        // In your project don't forget to right click on your MaskedTextBox and choose the date format (short format)
        private void Txt_Date_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChampDate monCode = new ChampDate();
            monCode.ScanCible = (MaskedTextBox)sender;
            monCode.eKeyPressEvArg = (KeyPressEventArgs)e;
            monCode.Valide_KeyPress();
        }

        private void Txt_Date_Validating(object sender, CancelEventArgs e)
        {
            ChampDate monCode = new ChampDate();
            monCode.ScanCible = (MaskedTextBox)sender;
            monCode.eCancelEvArgs = (CancelEventArgs)e;
            monCode.Valide_Validating();

        }

        // --- [EVENTS: Txt_Time] ---------------------------------------- ---------------------------
        // USE A MASKEDTEXTBOX AND NOT A TEXTBOX
        // IMPORTANT: Must be integrated into the following TWO types of events to be properly managed and to be safe from user behavior
        // FYI the MaxLength property of the MaskedTextBox has been limited to 5 characters in the GUI, but it's not a requirement.
        // In your project don't forget to right click on your MaskedTextBox and choose the Hour format

        private void Txt_Heure_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChampHeure monCode = new ChampHeure();
            monCode.ScanCible = (MaskedTextBox)sender;
            monCode.eKeyPressEvArg = (KeyPressEventArgs)e;
            monCode.Valide_KeyPress();
            
        }

        private void Txt_Heure_Validating(object sender, EventArgs e)
        {
            ChampHeure monCode = new ChampHeure();
            monCode.ScanCible = (MaskedTextBox)sender;
            monCode.Valide_Validating();
         
        }

        // --- [EVENTS: Txt_Email] ---------------------------------------- ----------------
        // IMPORTANT: Must be integrated into this type of events following to be correctly managed and to be safe from user behavior

        private void Txt_Email_LostFocus(object sender, EventArgs e)
        {
            ChampEMail monCode = new ChampEMail();
            monCode.ScanCible = (TextBox)sender;
            if (monCode.Valide_LostFocus()) return;

            MessageBox.Show("Email Non valide", "Adresse Email invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
            monCode.ScanCible.Focus();
        }



        private void Win_Exemple_Load(object sender, EventArgs e)
        {

        }



        private void Txt_Date_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Txt_Heure_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
