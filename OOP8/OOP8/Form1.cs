using System.Collections;

namespace OOP8
{
    public partial class Form1 : Form
    {

        static Book book1 = new Book("Граф Монте", "Кристо Александр Дюма", "Класика");
        static Book book2 = new Book("Время жить и время умирать", "Эрих Мария Ремарк", "Класика");
        static Book book3 = new Book("Три мушкетера", "Криcто Александр Дюма", "Класика");
        static Book book4 = new Book("Раковый корпус", "Александр Солженицын", "Класика");
        static Book book5 = new Book("Бесы", "Федор Достаевский", "Класика");
        static Book book6 = new Book("Нетерпение сердца", "Стефан Цвейг", "Класика");
        static Book book7 = new Book("Американская трагедия", "Теодор Драйзен", "Класика");
        static Book book8 = new Book("Атлант расправил плечи", "Айн Рэнд", "Класика");
        static Book book9 = new Book("Война и мир", "Лев Толстой", "Класика");
        static Book book10 = new Book("Отца и дети", "Иван Тургенев", "Класика");
        static Book book11 = new Book("Мастер и Маргарита", "Михаил Булгаков", "Класика");
        static Book book12 = new Book("Дубровский", "Александр Пушкин", "Класика");

        static Book book13 = new Book("Я-бездна", "Донато Карризи", "Детектив");
        static Book book14 = new Book("Совы охотятся ночью", "Энтони Горовиц", "Детектив");
        static Book book15 = new Book("Хорошая ночь", "Карин Слотер", "Детектив");

        static Book book16 = new Book("Code.Носители", "Джон Маррс", "Фантастика");
        static Book book17 = new Book("Птичий город за облаками", "Энтони Дорр", "Фантастика");
        static Book book18 = new Book("Железная вдова", "Сиран Джей Чжао", "Фантастика");
        static Book book19 = new Book("Башня из грязи и веток", "Ярослав Барсуков", "Фантастика");

        static Book book20 = new Book("Эти ведьмы не горят", "Изабель Стерлинг", "Мистика");
        static Book book21 = new Book("Мальчики с кладбища", "Эйден Томас", "Мистика");

        static Book book22 = new Book("Первый день весны", "Нэнси Такер", "Класика");
        static Book book23 = new Book("Хорошая дочь", "Карин Cлотер", "Класика");
        static Book book24 = new Book("Билли Саммерс", "Стивен Кинг", "Класика");

        static Book book25 = new Book("Играя с огнем", "Л.ДЖ.Шен", "Роман");

      
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
                if (books[i].styleBook == "Класика") { books2.Add(books[i].nameAuthor); countClassic++; }
                hashtable.Add(books[i].nameAuthor, books[i].titleBook);
            }


            books2.Sort();

            label4.Text = countClassic.ToString();

          

            var column1 = new DataGridViewColumn();

            column1.HeaderText = "Название книги"; //текст в шапке
            column1.Width = 300; //ширина колонки
            column1.ReadOnly = true; //значение в этой колонке нельзя править
            column1.Name = "name"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
           
            column2.HeaderText = "Автор";
            column2.Width = 440;
            column2.Name = "price";
            column2.CellTemplate = new DataGridViewTextBoxCell();


            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
          

            dataGridView1.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки

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