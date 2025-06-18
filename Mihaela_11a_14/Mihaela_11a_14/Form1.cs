using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Mihaela_11a_14.Controlers;
using Mihaela_11a_14.Data;

namespace Mihaela_11a_14
{
    public partial class Form1 : Form
    {
        private DishControler dishControler = new DishControler();
        private DishTypeControler dishtypeControler = new DishTypeControler();
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadRecord(Dish dish)
        {
           
            txtId.Text = dish.Id.ToString(); 
            txtName.Text = dish.Name;
            txtDesc.Text = dish.Description.ToString();
            txtPrice.Text = dish.Price.ToString(); ;
            txtWeigh.Text = dish.Weight.ToString();
            cmbDishType.SelectedValue = dish.DishTypeId;

        }
        private void ClearScreen()
        {
            txtId.Clear();
            txtName.Clear();
            txtDesc.Clear();
            txtPrice.Clear();
            txtWeigh.Clear();
            cmbDishType.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<DishType> allDishType = dishtypeControler.GetAllDishTypes();
            cmbDishType.DataSource = allDishType;
            cmbDishType.DisplayMember = "Name";
            cmbDishType.ValueMember = "Id";
            SelectAll(sender, e, dishControler);
        }

        private void SelectAll(object sender, EventArgs e, DishControler dishControler)
        {
            List<Dish> allDish = dishControler.GetAll();
            listBox1.Items.Clear();
            foreach (var item in allDish)
            {
                listBox1.Items.Add($"{item.Id}. {item.Name} - {item.Description}. {item.Price}. {item.Weight}. Тип на ястието:-  { item.DishTypes.Name}");
            }
        }
       
        private void lblDesc_Click(object sender, EventArgs e)
        {

        }

        private void cmbDishType_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || txtName.Text == "")
            {
                MessageBox.Show("Въведете данни!");
                txtName.Focus();
                return;
            }
            Dish dishes = new Dish();
            dishes.Name = txtName.Text;
            dishes.Description = txtDesc.Text;
            dishes.Price = decimal.Parse(txtPrice.Text);
            dishes.Weight = int.Parse(txtWeigh.Text);
            dishes.Id = int.Parse(txtId.Text);
            dishes.DishTypeId = (int)cmbDishType.SelectedValue;
            dishControler.Create(dishes);
            MessageBox.Show("Записът е успешно добавен!");
            ClearScreen();
            SelectAll(sender, e, dishControler);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int findId = 0;
            if (string.IsNullOrEmpty(txtId.Text) || !txtId.Text.All(char.IsDigit))
            {
                MessageBox.Show("Въведете номер за търсене!");
                txtId.Focus();
                return;
            }
            else
            {
                findId = int.Parse(txtId.Text);
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                Dish findeddish = dishControler.Get(findId);
                if (findeddish == null)
                {
                    MessageBox.Show("няма такова ястие!");
                    txtId.Focus();
                    return;
                }
                LoadRecord(findeddish);
            }
            else
            {
                Dish updatedish = new Dish();
                updatedish.Name = txtName.Text;
                updatedish.Description = txtDesc.Text;
                updatedish.Price = decimal.Parse(txtPrice.Text);
                updatedish.Weight = int.Parse(txtWeigh.Text);
                updatedish.DishTypeId = (int)cmbDishType.SelectedValue;
                updatedish.Id = int.Parse(txtId.Text); ;
                dishControler.Update(findId, updatedish);
            }
            SelectAll(sender, e, dishControler);
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
          int findId = 0;
            if (string.IsNullOrEmpty(txtId.Text) || !txtId.Text.All(char.IsDigit))
            {
                MessageBox.Show("Въведете номер за търсене!");
                txtId.Focus();
                return;
            }
            else
            {
                findId = int.Parse(txtId.Text);
            }
            Dish findeddish = dishControler.Get(findId);
            if (findeddish == null)
            {
                MessageBox.Show("няма такова ястие !");
                txtId.Focus();
                return;
            }
            LoadRecord(findeddish);

            DialogResult answer = MessageBox.Show("Наистина ли искате да изтриете запис No " + findId + "?", "PROMPT", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                dishControler.Delete(findId);
            }

            SelectAll(sender, e, dishControler);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int findId = 0;
            if (string.IsNullOrEmpty(txtId.Text) || !txtId.Text.All(char.IsDigit))
            {
                MessageBox.Show("Въведете Id за търсене!");
                txtId.Focus();
                return;
            }
            else
            {
                findId = int.Parse(txtId.Text);
            }
            Dish findeddish = dishControler.Get(findId);
            if (findeddish == null)
            {
                MessageBox.Show("НЯМА ТАКЪВ ЗАПИС в БД! \n Въведете Id за търсене!");
                txtId.Focus();
                return;
            }
            LoadRecord(findeddish);
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
    }
    }



    


