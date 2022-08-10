using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (DatabaseConnection connection = new DatabaseConnection())
            {
                connection.collisionChecks.Add(new CollisionCheck()
                {
                    Meteor1X = 2,
                    Meteor1Y = 7,
                    Meteor2X = 5,
                    Meteor2Y = 78

                });

                connection.SaveChanges();
            }
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            using (DatabaseConnection connection = new DatabaseConnection())
            {
                string data = connection.collisionChecks
                    .Where
                    (
                        x => x.CollisionId == 7
                    )
                    .Select
                    (
                        x => "Data: " + x.Meteor1X + ", " +
                        x.Meteor2X + ", " +
                        x.Meteor1Y + ", " +
                        x.Meteor2Y + ", " +
                        (x.Checked == true ? "true" : "false")
                    )
                    .First();

                Readout.Text = data;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string meteor1Xvalue = Meteor1XInput.Text.Trim();
            string meteor1Yvalue = Meteor1YInput.Text.Trim();
            string meteor2Xvalue = Meteor2XInput.Text.Trim();
            string meteor2Yvalue = Meteor2YInput.Text.Trim();

            bool checkedvalue = CBisChecked.Checked;

            CollisionCheck[] collisions = null;

            using (DatabaseConnection connection = new DatabaseConnection())
            {

                collisions = connection.collisionChecks
                        .Where(x =>
                        (
                            meteor1Xvalue == ""
                            ||
                            x.Meteor1X.ToString() == meteor1Xvalue
                        )
                        &&
                     (
                            meteor1Yvalue == ""
                            ||
                            x.Meteor1Y.ToString() == meteor1Yvalue
                            )
                        &&
                        (
                            meteor2Xvalue == ""
                            ||
                            x.Meteor2X.ToString() == meteor2Xvalue
                            )
                        &&
                        (
                            meteor2Yvalue == ""
                            ||
                            x.Meteor2Y.ToString() == meteor2Yvalue
                            )

                        &&
                        (
                        x.Checked == checkedvalue
                        )

                        ).Take(20).ToArray();




            }

            TableView.DataSource = collisions;

            string x = "";
        }

        private void NumberOnlyKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void GenerateNumbers(object sender, EventArgs e)
        {
            Random rnd = new Random();
                                  
            CollisionCheck[] collisions = null;

            using (DatabaseConnection connection = new DatabaseConnection())
            {
                string textToValidate = NumberToGenerate.Text.Trim();

                if (textToValidate[0] == '-')
                {
                    Message.Text = "Invalid Number: Below zero";
                    return;
                }

                string maxIntValue = int.MaxValue.ToString();

                if (textToValidate.Length > maxIntValue.Length)
                {
                    Message.Text = "Invalid Number: Too big";
                    return;
                }

                if (textToValidate.Length == maxIntValue.Length)
                {

                    for (int i = 0; i < maxIntValue.Length; i++)
                    {
                        int inputValue = int.Parse(textToValidate[i].ToString());
                        int maxNumberValue = int.Parse(maxIntValue[i].ToString());

                        if (inputValue > maxNumberValue)
                        {
                            Message.Text = "Invalid Number: Too big";
                        }

                        if (inputValue < maxNumberValue)
                        {
                            break;
                        }
                    }
                }

                int x = 2;

                int numRecords = int.Parse(textToValidate);

                if (numRecords > 0 && numRecords <= 2147483647)
                {
                    for (int i = 0; i < numRecords; i++)
                    {
                        AmountDone.Text = 1 + i + "/" + numRecords.ToString();
                        Application.DoEvents();
                        connection.collisionChecks.Add(new CollisionCheck()
                        {
                            Meteor1X = rnd.Next(2000),
                            Meteor1Y = rnd.Next(2000),
                            Meteor2X = rnd.Next(2000),
                            Meteor2Y = rnd.Next(2000),
                            WhenCreated = DateTime.Now

                        });
                        connection.SaveChanges();
                    }

                }
                else 
                {
                    Message.Text = "Invalid Number";

                }

                
            }
            


        }
    }

    
}





