using System;

    namespace IntroLib
{
    public class PersonModel
     {
                public string FirstName  { get; set; }
                public string LastName { get; set; }
                public int Age { get; set; }   
                public string  NameBuilder ()
                {
                  string output = "";
                  int j =0;
                  output +=FirstName.Substring(j,0).ToLower();

                    for (int i = 0; i < FirstName.Length; i++)
                    {
                        if (i % 2 ==0 )
                        {
                            output +=FirstName.Substring(i,1);
                            
                        }
                        else
                        {
                            output +=FirstName.Substring(i,1).ToUpper();
                        }
                    }  
                    return output;

                }     
    }
}