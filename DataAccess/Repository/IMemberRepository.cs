using BusinessObject;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();

        Member GetMember(int memberId, string? email, string? password);

        void InsertMember(Member member);

        void UpdateMember(Member member);

        void DeleteMember(int memberId);
    }
}
