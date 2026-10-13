using MaterialSkin;
using MaterialSkin.Controls;


namespace Student.Records.Query.Tool
{
    public partial class Form1 : MaterialForm
    {
        private List<StudentModel> _students;
        private string _input = string.Empty;
        public Form1()
        {
            InitializeComponent();
            InitializeMaterialDesign();

            _students = new()
            {
                new() { Id = "1", FirstName = "Michael", LastName = " Davis", GPA = "3.42", Program = "Robotic Systems Engineering"},
                new() { Id = "2", FirstName = "Linda", LastName = " Jones", GPA = "2.89", Program = "Robotic Systems Engineering"},
                new() { Id = "3", FirstName = "William", LastName = "  Moore", GPA = "3.95", Program = "Data Science and Analytics"},
                new() { Id = "4", FirstName = "Patricia", LastName = " Martin", GPA = "3.15", Program = "Robotic Systems Engineering"},
                new() { Id = "5", FirstName = "Susan", LastName = " Johnson", GPA = "4.00", Program = "Data Science and Analytics"},
                new() { Id = "6", FirstName = "James", LastName = " Wills", GPA = "2.71", Program = "Graphic Design and Visual Communication"},
                new() { Id = "7", FirstName = "John", LastName = " Jackson", GPA = "3.68", Program = "Robotic Systems Engineering"},
                new() { Id = "8", FirstName = "Joe", LastName = " Smith", GPA = "3.10", Program = "Graphic Design and Visual Communication"},
                new() { Id = "9", FirstName = "Thomas", LastName = " Clarke", GPA = "2.54", Program = "Robotic Systems Engineering"},
                new() { Id = "10", FirstName = "Kevin", LastName = " Thompson", GPA = "3.81", Program = "Graphic Design and Visual Communication"},
            };

            _students.UpdateUI(studentList);
            UpdateTotalCount();
            GetAverageGpa();

            searchTextBox.GotFocus += (s, e) => searchTextBox.PrefixSuffix = MaterialTextBox2.PrefixSuffixTypes.None;
            searchTextBox.LostFocus += (s, e) =>
            {
                _input = searchTextBox.Text;
                searchTextBox.Text = string.Empty;
                searchTextBox.PrefixSuffix = MaterialTextBox2.PrefixSuffixTypes.Prefix;
            };
        }

        private void InitializeMaterialDesign()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public void GetStudentsByProgram(string program)
        {
            var students = _students.FindAll(student => student.Program.Equals(program, StringComparison.InvariantCultureIgnoreCase));

            students.UpdateUI(studentList);
        }

        public void GetStudentsWithGpaAboveThisValue(string value)
        {
            var isValid = double.TryParse(value, out var result);

            if (isValid)
            {
                var students = _students.FindAll(student => double.Parse(student.GPA) >= result);

                students.UpdateUI(studentList);
            }

            if (isValid is false)
            {
                MessageBox.Show("Try entrying numbers only.", "Whoops!", MessageBoxButtons.OK);
            }
        }

        public void GetStudentById(string id)
        {
            var student = _students.FirstOrDefault(x => x.Id.Equals(id));

            if (student is not null)
            {
                new List<StudentModel>([student]).UpdateUI(studentList);
            }
            else
            {
                MessageBox.Show("Student not found.", "Whoops!", MessageBoxButtons.OK);
            }
        }

        public void SortStudentRecord(string sortOrder)
        {
            var itemsToSort = new List<StudentModel>();

            foreach(ListViewItem item in studentList.Items)
            {
                itemsToSort.Add(new StudentModel 
                {
                    Id = item.SubItems[0].Text,
                    FirstName = item.SubItems[1].Text,
                    LastName = item.SubItems[2].Text,
                    GPA = item.SubItems[3].Text,
                    Program = item.SubItems[4].Text,
                });
            }

            IOrderedEnumerable<StudentModel> sortedItems = itemsToSort.OrderBy(_ => string.Empty);

            if (sortOrder.Equals("id", StringComparison.OrdinalIgnoreCase))
            {
                sortedItems = itemsToSort.OrderBy(x => int.Parse(x.Id));
            }
            else if (sortOrder.Equals("firstname", StringComparison.OrdinalIgnoreCase))
            {
                sortedItems = itemsToSort.OrderBy(x => x.FirstName);
            }
            else if (sortOrder.Equals("lastname", StringComparison.OrdinalIgnoreCase))
            {
                sortedItems = itemsToSort.OrderBy(x => x.LastName);
            }
            else if (sortOrder.Equals("gpa", StringComparison.OrdinalIgnoreCase))
            {
                sortedItems = itemsToSort.OrderBy(x => double.Parse(x.GPA));
            }
            else if (sortOrder.Equals("program", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Sort by program not supported yet.", "Whoops!", MessageBoxButtons.OK);
            }

            sortedItems.ToList().UpdateUI(studentList);
        }

        public void GetAverageGpa()
        {
            double totalGpa = 0.00;

            _students.ForEach(x =>
            {
                foreach (var item in studentList.Items)
                {
                    if (((ListViewItem)item).Text == x.Id)
                    {
                        totalGpa += double.Parse(x.GPA);
                        break;
                    }
                }
            });

            averageGpa.Text = totalGpa.ToString("0.00");
        }

        public void UpdateTotalCount()
        {
            totalCount.Text = studentList.Items.Count.ToString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_input) is false)
            {

                switch (searchMode.SelectedItem)
                {
                    case "By program":
                        GetStudentsByProgram(_input);
                        break;

                    case "By gpa":
                        GetStudentsWithGpaAboveThisValue(_input);
                        break;

                    case "By id":
                        GetStudentById(_input);
                        break;

                    case "Sort by":
                        SortStudentRecord(_input);
                        break;

                    default:
                        MessageBox.Show("Undefined instruction", "Whoops!", MessageBoxButtons.OK);
                        break;
                };
            }

            UpdateTotalCount();
            GetAverageGpa();
        }

        private void resetSearch_Click(object sender, EventArgs e)
        {
            _students.UpdateUI(studentList);
            UpdateTotalCount();
            studentList.Sorting = SortOrder.None;
        }
    }

    public static class Extensions
    {
        public static void UpdateUI(this List<StudentModel> students, MaterialListView uiCollection)
        {
            uiCollection.Items.Clear();
            students.ToList().ForEach(student =>
            {
                var item = new ListViewItem([student.Id, student.FirstName, student.LastName, student.GPA, student.Program]);
                uiCollection.Items.Add(item);
            });
        }
    }
}
