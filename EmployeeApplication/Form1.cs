
namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

          
            dataGridView2.ColumnCount = 4;
            dataGridView2.Columns[0].Name = "Employee ID";
            dataGridView2.Columns[1].Name = "First Name";
            dataGridView2.Columns[2].Name = "Last Name";
            dataGridView2.Columns[3].Name = "Position";
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(Fname.Text) || string.IsNullOrEmpty(Lname.Text) || string.IsNullOrEmpty(Position.Text) || string.IsNullOrEmpty(EmployeeID.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

          
            int employeeId;
            if (!int.TryParse(EmployeeID.Text, out employeeId))
            {
                MessageBox.Show("Invalid Employee ID. Please enter a numeric value.");
                return;
            }

           
            Employee employee = new Employee(employeeId, Fname.Text, Lname.Text, Position.Text);

           
            dataGridView2.Rows.Add(employee.EmployeeId, employee.FirstName, employee.LastName, employee.Position);

           
            Lname.Clear();
            Position.Clear();
            EmployeeID.Clear();
        }

       
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }

    public class Employee
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private string position;

       
        public int EmployeeId
        {
            get { return employeeId; }
            private set { employeeId = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

     
        public Employee(int employeeId, string firstName, string lastName, string position)
        {
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }

       
        public Employee(int employeeId, string firstName, string lastName)
        {
            this.employeeId = employeeId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = "Not specified";
        }
    }
}
