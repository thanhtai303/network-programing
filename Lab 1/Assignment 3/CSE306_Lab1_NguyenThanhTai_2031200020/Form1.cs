using System.Net.Sockets;
using System.Text;
using System.Text.Json;
namespace CSE306_Lab1_NguyenThanhTai_2031200020

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectChangePicture_Click(object sender, EventArgs e)
        {
            ofdPicture.FileName = null;
            ofdPicture.Filter = "JPG |*.jpg|All files |*.*";
            if (ofdPicture.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(ofdPicture.FileName);
            }
        }
        public void ClearAllField()
        {
            pictureBox.Image = null;
            txtFullName.Clear();
            txtStudentID.Clear();
            txtAddress.Clear();
            ofdBinary.FileName = null;
            sfdBinary.FileName = null;
            ofdJson.FileName = null;
            sfdJson.FileName = null;
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            sfdBinary.Filter = "Text Files |*.txt|All files |*.*";
            if (sfdBinary.ShowDialog() == DialogResult.OK)
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(new FileStream(sfdBinary.FileName, FileMode.Create, FileAccess.ReadWrite)))
                {
                    binaryWriter.Write(Int32.Parse(txtStudentID.Text));
                    binaryWriter.Write(txtFullName.Text);
                    binaryWriter.Write(dateTimePicker1.Value.ToString());
                    binaryWriter.Write(txtAddress.Text);
                    binaryWriter.Write(ofdPicture.FileName);
                }
                ClearAllField();
                MessageBox.Show("Successful", "Note");
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            ofdBinary.FileName = null;
            ofdBinary.Filter = "Text Files |*.txt|All files |*.*";
            if (ofdBinary.ShowDialog() == DialogResult.OK)
            {
                STUDENT student;
                using (BinaryReader binaryReader = new BinaryReader(new FileStream(ofdBinary.FileName, FileMode.Open, FileAccess.ReadWrite)))
                {
                    student = new STUDENT(
                        binaryReader.ReadInt32(),
                        binaryReader.ReadString(),
                        DateTime.Parse(binaryReader.ReadString()),
                        binaryReader.ReadString(),
                        binaryReader.ReadString()
                        );
                }
                txtStudentID.Text = student.id.ToString();
                txtFullName.Text = student.name;
                dateTimePicker1.Value = student.dob;
                txtAddress.Text = student.address;
                pictureBox.Image = Image.FromFile(student.avatar);
            }
        }

        private void btnSerializeAndSave_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT(
               Int32.Parse(txtStudentID.Text),
                txtFullName.Text,
                dateTimePicker1.Value,
                txtAddress.Text,
                ofdPicture.FileName
                );
            string jsonString = JsonSerializer.Serialize(student);
            sfdJson.Filter = "Text Files |*.txt|All Files |*.*";
            if (sfdJson.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfdJson.FileName, jsonString);
                ClearAllField();
                MessageBox.Show("Successful", "Note");
            }
        }

        private void btnReadAndDeserialize_Click(object sender, EventArgs e)
        {
            ofdJson.FileName = null;
            ofdJson.Filter = "Text Files |*.txt|All files |*.*";
            if (ofdJson.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(ofdJson.FileName, FileMode.Open, FileAccess.Read))
                {
                    string jsonString = File.ReadAllText(ofdJson.FileName);
                    STUDENT student = JsonSerializer.Deserialize<STUDENT>(jsonString);
                    txtStudentID.Text = student.id.ToString();
                    txtFullName.Text = student.name;
                    dateTimePicker1.Value = student.dob;
                    txtAddress.Text = student.address;
                    pictureBox.Image = Image.FromFile(student.avatar);
                }
            }
        }
    }

}
public class STUDENT
{
    public STUDENT(int id, string name, DateTime dob, string address, string avatar)
    {
        this.name = name;
        this.id = id;
        this.dob = dob;
        this.address = address;
        this.avatar = avatar;
    }
    public int id { get; set; }
    public string name { get; set; }
    public DateTime dob { get; set; }
    public string address { get; set; }
    public string avatar { get; set; }
}
