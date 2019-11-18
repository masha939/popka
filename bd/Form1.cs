using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace bd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Cgroup> groupList = new List<Cgroup>();
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mashaDataSet.Users". При необходимости она может быть перемещена или удалена.
            //this.usersTableAdapter.Fill(this.mashaDataSet.Users);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                // User user1 = new User { Name = "Tom", Age = 12 };
                //  db.Users.Add(user1);
                // db.SaveChanges();
                Cgroup cgroup = new Cgroup { Name = "group" };
                User qwe = new User
                {

                    Name = textBox1.Text,
                    Cgroup = cgroup



                };
              //  db.Users.Add(qwe);
               // db.SaveChanges();

            }
        }
    }
}
