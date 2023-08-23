using BasicAPI.BL;
using BasicAPI.Data;
using BasicAPI.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BasicAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly AppDbCOntext context;
        public StudentController( AppDbCOntext cOntext)
        {
               this.context = cOntext;
        }
        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return context.Students.ToList();
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return  context.Students.FirstOrDefault(x => x.Id == id);
        }

        // POST api/<StudentController>
        [HttpPost]
   public void Post([FromBody] Student student )
        {
            context.Students.Add(student);  
            context.SaveChanges();
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student student)
        {
            var student1 = context.Students.FirstOrDefault(x => x.Id == id);
            if (student1 != null) 
            {
            student1.FirstName = student.FirstName;
                student1.LastName = student.LastName;
                student1.RollNo = student.RollNo;
                student1.MobileNo = student.MobileNo;
                student1.DOB = student.DOB;
                context.Students.Update(student1);
                context.SaveChanges();
              
            }

        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
          var student =  context.Students.FirstOrDefault(x => x.Id == id);

            if (student != null)
            {

                context.Students.Remove(student);
                context.SaveChanges();
            }

        }
    }
}
