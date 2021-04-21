using System;

namespace treino_csharp
{
    class Students {

    private String name { get; set; }
    private String email { get; set; }
    private Int64 phone {get; set; }
    

    public Students(){
    }

    public Students(String name, String email, Int64 phone) {

      this.name = name;
      this.email = email;
      this.phone = phone;

    }

        public override string ToString()
        {
            return  " \nName: " + name.ToString() 
                    +
                    " \nEmail: " + email.ToString()
                    +
                    " \nPhone: " + phone.ToString();

        }           
        



  

   

  }
}