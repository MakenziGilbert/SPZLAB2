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
    public partial class Form1 : Form
    {
        CampusList campusList = new CampusList(); //список кампусов
        public Form1()
        {
            InitializeComponent();
        }

        private void AddCampBtn_Click(object sender, EventArgs e) // добавление нового кампуса
        {
            var addingDialog = new Adding(); // новое диалоговое окно
            addingDialog.StartPosition = FormStartPosition.CenterParent;
            if(addingDialog.ShowDialog() == DialogResult.OK)//возвр. значение диалогового окна
            {
                lbxCampuses.Items.Clear();//очищение listbox
                campusList.AddCampus(addingDialog.campus);// добавить в список новый кампус
                lbxCampuses.Items.AddRange(campusList.Campuses.ToArray()); //вывести весь список
            }
        }

        private void lbxCampuses_DoubleClick(object sender, EventArgs e)// войти в информацию о кампусе
        {
            var campus = campusList.GetCampus(lbxCampuses.SelectedIndex);// обращение по индексу куда был даблклик
            var infoDialog = new CampusInfo().SetCampus(campus); // передает выбранный кампус
            if (infoDialog.ShowDialog() == DialogResult.OK) 
            {
                lbxCampuses.Items.Clear();
                campusList.AddCampus(infoDialog.temp);// при клонировании
                lbxCampuses.Items.AddRange(campusList.Campuses.ToArray());
            }
        }
    }
}
