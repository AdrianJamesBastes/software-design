namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            BaseBookClass myBook = new Magazine
            {
                Title = "Tech Weekly",
                Author = "John Doe",
                IssueNumber = 45
            };
            MessageBox.Show(myBook.GetInfo());
        }

        public void DisplayBooks(List<BaseBookClass> books)
        {
            listBoxBooks.Items.Clear();
            foreach (var book in books)
            {
                listBoxBooks.Items.Add(book.GetInfo());
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<BaseBookClass> books = new List<BaseBookClass>
            {
                new BaseBookClass { Title = "How to develop your skills", Author = "John Doe" },
                new Ebook { Title = "Learn C#", Author = "Jane Doe", FileFormat = "PDF" },
                new Magazine { Title = "Tech Weekly", Author = "Editorial Team", IssueNumber = 45 }
            };

            DisplayBooks(books);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<BaseBookClass> books = new List<BaseBookClass>
            {
                new BaseBookClass { Title = "How to develop your skills", Author = "John Doe" },
                new Ebook { Title = "Learn C#", Author = "Jane Doe", FileFormat = "PDF" },
                new Magazine { Title = "Tech Weekly", Author = "Editorial Team", IssueNumber = 45 },
                new Textbook { Title = "SD 101", Author = "Prof. Jay Al", Subject = "Software Design" }, // New Textbook
                new AudioBook { Title = "The Art of Coding", Author = "Randy Angelia", Duration = 5.5, Narrator = "Hannah Angelia" } // New Audiobook
             };

            DisplayBooks(books);
        }
    }
}
