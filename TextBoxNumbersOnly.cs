using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Otomasyon
{
    class TextBoxNumbersOnly : TextBox
    {
        bool numbersOnly;

        [Browsable(true)]
        [Category("Özel Davranış")]
        [Description("NumbersOnly özelliği True olarak ayarlanırsa TextBox içinde sadece sayılara izin verir. Multiline özelliği etkin değildir. ")]
        [DisplayName("NumbersOnly")]
        public bool NumbersOnly
        {
            get { return this.numbersOnly; }
            set
            {
                this.numbersOnly = value;
                if (value)
                {
                    this.KeyPress += new KeyPressEventHandler(TextBoxNumersOnly_KeyPress);
                    base.Multiline = false;

                    Decimal temp = 0;
                    if (!Decimal.TryParse(this.Text, out temp)) this.Text = "0";
                    //TextBox, NumbersOnly özelliğini etkinleştirmeden önce yalnızca rakam içermiyorsa, '0' metnine sahip olacaktır
                }
                else
                {
                    this.KeyPress -= new KeyPressEventHandler(TextBoxNumersOnly_KeyPress);
                }
            }
        }

        public override string Text
        {
            get { return base.Text; }
            set
            {
                if (!this.numbersOnly) base.Text = value;
                else
                {
                    Decimal temp = 0;
                    if (!Decimal.TryParse(value, out temp)) base.Text = "";
                    else base.Text = value;
                }
            }
        }

        public override bool Multiline
        {
            get { return base.Multiline; }
            set
            {
                if (!this.numbersOnly) base.Multiline = value;
            }
        }

        public TextBoxNumbersOnly()
        {
            NumbersOnly = true;
        }

        protected virtual void TextBoxNumersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ayrac = ',';// buraya istediğiniz bir ayracı yazabilirsiniz.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ayrac))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ayrac) && ((sender as TextBox).Text.IndexOf(ayrac) > -1))//İlk karakterin '.' olup olmadığını kontrol ediyoruz
            {
                e.Handled = true;//Değilse görmezden geliyoruz.
            }
        }


        public event EventHandler<NumberKeyPressEventArgs> NumberPressed;
        protected virtual void OnNumberPressed(NumberKeyPressEventArgs e)
        {
            EventHandler<NumberKeyPressEventArgs> handler = NumberPressed;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }

    public class NumberKeyPressEventArgs : KeyEventArgs
    {
        private Keys myKeys;
        public Keys MyKeys
        {
            get { return myKeys; }
        }
        public NumberKeyPressEventArgs(Keys keyData) : base(keyData)
        {
            this.myKeys = keyData;
        }
    }
}