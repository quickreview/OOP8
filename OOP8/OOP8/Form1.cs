using System.Collections;

namespace OOP8
{
    public partial class Form1 : Form
    {

        static Book book1 = new Book("���� �����", "������ ��������� ����", "�������");
        static Book book2 = new Book("����� ���� � ����� �������", "���� ����� ������", "�������");
        static Book book3 = new Book("��� ���������", "���c�� ��������� ����", "�������");
        static Book book4 = new Book("������� ������", "��������� ����������", "�������");
        static Book book5 = new Book("����", "����� �����������", "�������");
        static Book book6 = new Book("���������� ������", "������ �����", "�������");
        static Book book7 = new Book("������������ ��������", "������ �������", "�������");
        static Book book8 = new Book("������ ��������� �����", "��� ����", "�������");
        static Book book9 = new Book("����� � ���", "��� �������", "�������");
        static Book book10 = new Book("���� � ����", "���� ��������", "�������");
        static Book book11 = new Book("������ � ���������", "������ ��������", "�������");
        static Book book12 = new Book("����������", "��������� ������", "�������");

        static Book book13 = new Book("�-������", "������ �������", "��������");
        static Book book14 = new Book("���� �������� �����", "������ �������", "��������");
        static Book book15 = new Book("������� ����", "����� ������", "��������");

        static Book book16 = new Book("Code.��������", "���� �����", "����������");
        static Book book17 = new Book("������ ����� �� ��������", "������ ����", "����������");
        static Book book18 = new Book("�������� �����", "����� ���� ����", "����������");
        static Book book19 = new Book("����� �� ����� � �����", "������� ��������", "����������");

        static Book book20 = new Book("��� ������ �� �����", "������� ��������", "�������");
        static Book book21 = new Book("�������� � ��������", "����� �����", "�������");

        static Book book22 = new Book("������ ���� �����", "����� �����", "�������");
        static Book book23 = new Book("������� ����", "����� C�����", "�������");
        static Book book24 = new Book("����� �������", "������ ����", "�������");

        static Book book25 = new Book("����� � �����", "�.��.���", "�����");

      
        static Book[] books = new Book[] {book1 , book2 , book3, book4, book5, book6, book7, book8, book9, book10, book11, book12, book13, book14, book15,
            book16, book17, book18 , book19 ,book20 , book21 ,book22 , book23 ,book24 , book25 };

        static ArrayList books2 = new ArrayList();

        static public Hashtable hashtable = new Hashtable(); 

        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
          
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = books.Length.ToString();
            int countClassic = 0;

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].styleBook == "�������") { books2.Add(books[i].nameAuthor); countClassic++; }
                hashtable.Add(books[i].nameAuthor, books[i].titleBook);
            }


            books2.Sort();

            label4.Text = countClassic.ToString();

          

            var column1 = new DataGridViewColumn();

            column1.HeaderText = "�������� �����"; //����� � �����
            column1.Width = 300; //������ �������
            column1.ReadOnly = true; //�������� � ���� ������� ������ �������
            column1.Name = "name"; //��������� ��� �������, ��� ����� ������������ ������ ��������� �� �������
            column1.Frozen = true; //����, ��� ������ ������� ������ ������������ �� ����� �����
            column1.CellTemplate = new DataGridViewTextBoxCell(); //��� ����� �������

            var column2 = new DataGridViewColumn();
           
            column2.HeaderText = "�����";
            column2.Width = 440;
            column2.Name = "price";
            column2.CellTemplate = new DataGridViewTextBoxCell();


            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
          

            dataGridView1.AllowUserToAddRows = false; //��������� ������������ ������ ��������� ������

            foreach (string book in books2)
            {
                //NameBook.Text += hashtable[book].ToString() + Environment.NewLine;
                dataGridView1.Rows.Add( book, hashtable[book].ToString());

            }
        
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}