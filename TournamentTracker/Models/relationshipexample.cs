// namespace ProjectName.Models {
//   public class Class {
//     public Class() {
//       // many class to many other3
//       this.Other3s = new HashSet<Other3>(); 
//     }
//     public int ClassId {get; set;}
//     public string PropName {get; set;}

//     // one class to one other1
//     public int Other1Id {get; set;}
//     public virtual Other1 Other1 {get; set;} 

//     // one class to many other2
//     public virtual Other2 Other2 {get; set;}  // navigation properties of other2

//     // many class to many other3
//     public virtual ICollection<Other3> Other3s  {get; set;} 
//     // public virtual ApplicationUser User {get; set;}
//   }
// }


// //  dotnet ef migrations add Initial
// //  dotnet ef database update