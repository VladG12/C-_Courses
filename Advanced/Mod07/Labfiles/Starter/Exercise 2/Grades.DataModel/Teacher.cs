
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Grades.DataModel
{

using System;
    using System.Collections.Generic;
    
public partial class Teacher
{

    public Teacher()
    {

        this.Students = new HashSet<Student>();

    }


    public System.Guid UserId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Class { get; set; }



    public virtual ICollection<Student> Students { get; set; }

    public virtual User User { get; set; }

}

}
