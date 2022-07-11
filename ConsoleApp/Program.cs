using BusinessObject;
using DataAccess.Repository;

namespace ConsoleApp;

public class Program
{
    public static IMemberRepository repository = new MemberRepository();

    public static void Process()
    {
        Member member = new Member()
        {
            MemberId = 8,
            Email = "8",
            City = "8",
            CompanyName = "8",
            Country = "8",
            Password = "8"
        };

        repository.InsertMember(member);

        Member member1 = new Member()
        {
            MemberId = 8,
            Email = "9999",
            City = "8",
            CompanyName = "8",
            Country = "8",
            Password = "8"
        };

        repository.UpdateMember(member1);
    }

    public static void Delete()
    {
        repository.DeleteMember(8);
    }

    public static void Main()
    {
        Process();
    }
}