using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServerBlazorEF.Models;

public class StudentService {
      SchoolDbContext _context;
      public StudentService(SchoolDbContext context) {
        _context = context;
      }

      public async Task<List<Student>> GetStudentsAsync() {
        var result = _context.Students;
        return await Task.FromResult(result.ToList());
      }

      public async Task<Student> GetStudentByIdAsync(int id) {
        return await _context.Students.FindAsync(id);
      }

      public async Task<Student> InsertStudentAsync(Student student) {
        _context.Students.Add(student);
        await _context.SaveChangesAsync();

        return student;
      }

      public async Task<Student> UpdateStudentAsync(int id, Student s) {
        var student = await _context.Students.FindAsync(id);
        
        if (student == null)
          return null;

        student.FirstName = s.FirstName;
        student.LastName = s.LastName;
        student.School = s.School;

        _context.Students.Update(student);
        await _context.SaveChangesAsync();

        return student;
      }

      public async Task<Student> DeleteStudentAsync(int id)
      {
        var student = await _context.Students.FindAsync(id);
        
        if (student == null)
          return null;

        _context.Students.Remove(student);
        await _context.SaveChangesAsync();

        return student;
      }

      private bool StudentExists(int id) {
        return _context.Students.Any(e => e.StudentId == id);
      }
}
