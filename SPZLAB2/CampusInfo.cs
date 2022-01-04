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
    public partial class CampusInfo : Form
    {
        Campus camp; // чтоб сохранить передаваемый кампус
        public Campus temp; //для конирования
        public CampusInfo()
        {
            InitializeComponent();
        }
        public CampusInfo SetCampus(Campus campus) //устанавливает значения в лейблы после вызова с другой формы
        {
            labelName.Text = campus.UniversityName;
            labelAddress.Text = campus.Address;
            labelRooms.Text = campus.NumberOfRooms.ToString();
            labelPersonal.Text = campus.NumberOfStaff.ToString();
            labelStudents.Text = campus.NumberOfStudents.ToString();
            labelPayment.Text = campus.PaymentForAccommodation.ToString();
            camp = campus;
            return this;
        }

        private void button1_Click(object sender, EventArgs e)//увеличение количества комнат
        {
            camp.IncreaseNumberOfRooms((int)tbxIncreaseRooms.Value); //вызов метода
            labelRooms.Text = camp.NumberOfRooms.ToString(); // изменение текста лейбла
        }

        private void Populatebtn_Click(object sender, EventArgs e)//заселить
        {
            camp.PopulateStudents((int)tbxPopulateStud.Value);
            labelStudents.Text = camp.NumberOfStudents.ToString();
        }

        private void EvictBtn_Click(object sender, EventArgs e)//выселить
        {
            camp.EvictStudents((int)tbxEvictStud.Value);
            labelStudents.Text = camp.NumberOfStudents.ToString();
        }

        private void btnCopy_Click(object sender, EventArgs e)//копирование
        {
            temp = (Campus)camp.Clone();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)// просчитать доход
        {
            lblImcomeMouth.Text = camp.CalculateIncomeMouth().ToString();
            lblIncomeHalfOfYear.Text = camp.CalculateIncomeHalfYear().ToString();
            lblIncomeYear.Text = camp.CalculateIncomeYear().ToString();
        }

        private void btnAddDiningRoom_Click(object sender, EventArgs e)// добавить столовую расширяющим етодом
        {
            camp = MyExtensionMethods.AddDiningRoom(camp);
            labelPersonal.Text = camp.NumberOfStaff.ToString();
            labelPayment.Text = camp.PaymentForAccommodation.ToString();
        }
    }
}
