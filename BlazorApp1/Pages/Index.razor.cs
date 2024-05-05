using BlazorApp1.Data;

namespace BlazorApp1.Pages
{
    public partial class Index
    {
        public bool ShowCreate { get; set; }
        public Student? NewStudent { get; set; }
        public Student? StudentToUpdate { get; set; }
        public List<Student>? Students { get; set; }
        public bool ShowEdit { get; set; }
        public int EditId { get; set; }

        private StudentDbContext? context;

        protected override async void OnInitialized()
        {
            ShowCreate = false;
            ShowEdit = false;
            await ShowStudents();
        }

        public void ShowCreatForm()
        {
            NewStudent = new Student();
            ShowCreate = true;
        }

        public async Task ShowEditForm(Student student)
        {
            context = await StudentDbContextFactory.CreateDbContextAsync();
            StudentToUpdate = context.Students.FirstOrDefault(s => s.Id == student.Id);
            ShowEdit = true;
            EditId = student.Id;
        }

        public async Task UpdateStudent()
        {
            context = await StudentDbContextFactory.CreateDbContextAsync();
            if(StudentToUpdate != null)
            {
                context.Update(StudentToUpdate);
                await context.SaveChangesAsync();
            }
            ShowEdit = false;
            await ShowStudents();
        }

        public async Task CreateNewStudentAsync()
        {
            context = await StudentDbContextFactory.CreateDbContextAsync();

            if(NewStudent != null)
            {
                context.Add(NewStudent);
                context.SaveChanges();
            }            

            await ShowStudents();
            ShowCreate = false;
        }

        public async Task DeleteStudent(int studentId)
        {
            context = await StudentDbContextFactory.CreateDbContextAsync();

            if(context != null)
            {
                var studentToDelete = context.Students.FirstOrDefault(s => s.Id == studentId);                
                if(studentToDelete != null)
                {
                    context.Remove(studentToDelete);
                    context.SaveChanges();
                    await ShowStudents();
                }
            }
        }

        public async Task ShowStudents()
        {
            context = await StudentDbContextFactory.CreateDbContextAsync();

            if(context != null)
            {
                Students = context.Students.ToList();
                context.Dispose();
            }
        }
    }
}
