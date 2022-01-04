using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPZLAB2.Classes;
namespace SPZLAB2
{
    public partial class Adding : Form
    {
        public Campus campus {get; set;} // чтоб мог обратиться с другой формы
        public Adding()
        {
            InitializeComponent();
        }

        private void AddiingCampBtn_Click(object sender, EventArgs e) // по кнопке
        {
            campus = new Campus(tbNameText.Text,tbAddressText.Text, // вызывает конструктор
                (int)tbRoomsNum.Value,(int)tbPersonalNum.Value,
                (int)tbStudentsNum.Value,(int)tbPaymentNum.Value);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
