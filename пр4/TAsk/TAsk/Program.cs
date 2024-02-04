using ConsoleApp18;

class Program 
{
    public static void Main()
    {
        Staff st1 = new Staff("Slava","Nakul","Igor",new DateTime(2006,08,08),"student",0);
        Staff st2 = new Staff("Ira", "Nakul", "Mixalovna", new DateTime(2004, 05, 25), "student", 0);
        Staff st3 = new Staff("Ula", "Chvigun", "Xd", new DateTime(2006, 05, 19), "student", 0);
        Staff st4 = new Staff("Artem", "Mutaf", "Mb", new DateTime(2006, 07, 21), "student", 0);

        Staff[] allStaff = new Staff[] { st1,st2,st3,st4};

        Staff.AgeAllStaff(allStaff);


    }
}
